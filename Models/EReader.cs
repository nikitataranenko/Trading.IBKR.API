﻿/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Trading.IBKR.API.Models
{
    /**
    * @brief Captures incoming messages to the API client and places them into a queue.
    */
    public class EReader
    {
        private const int defaultInBufSize = ushort.MaxValue / 8;

        private static readonly EWrapper defaultWrapper = new DefaultEWrapper();
        private readonly EClientSocket eClientSocket;
        private readonly EReaderSignal eReaderSignal;
        private readonly Queue<EMessage> msgQueue = new Queue<EMessage>();
        private readonly EDecoder processMsgsDecoder;

        private readonly List<byte> inBuf = new List<byte>(defaultInBufSize);

        public EReader(EClientSocket clientSocket, EReaderSignal signal)
        {
            eClientSocket = clientSocket;
            eReaderSignal = signal;
            processMsgsDecoder = new EDecoder(eClientSocket.ServerVersion, eClientSocket.Wrapper, eClientSocket);
        }

        private bool UseV100Plus => eClientSocket.UseV100Plus;

        public void Start()
        {
            new Thread(() =>
            {
                try
                {
                    while (eClientSocket.IsConnected())
                    {
                        if (!eClientSocket.IsDataAvailable())
                        {
                            Thread.Sleep(1);

                            continue;
                        }

                        if (!putMessageToQueue())
                        {
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    eClientSocket.Wrapper.error(ex);
                    eClientSocket.eDisconnect();
                }

                eReaderSignal.issueSignal();
            })
            {
                IsBackground = true,
            }.Start();
        }

        public void processMsgs()
        {
            var msg = getMsg();

            while (msg != null && processMsgsDecoder.ParseAndProcessMsg(msg.GetBuf()) > 0)
            {
                msg = getMsg();
            }
        }

        public bool putMessageToQueue()
        {
            try
            {
                var msg = readSingleMessage();

                if (msg == null)
                {
                    return false;
                }

                lock (msgQueue)
                {
                    msgQueue.Enqueue(msg);
                }

                eReaderSignal.issueSignal();

                return true;
            }
            catch (Exception ex)
            {
                if (eClientSocket.IsConnected())
                {
                    eClientSocket.Wrapper.error(ex);
                }

                return false;
            }
        }

        private EMessage getMsg()
        {
            lock (msgQueue)
            {
                return msgQueue.Count == 0 ? null : msgQueue.Dequeue();
            }
        }

        private EMessage readSingleMessage()
        {
            var msgSize = 0;

            if (UseV100Plus)
            {
                msgSize = eClientSocket.ReadInt();

                if (msgSize > Constants.MaxMsgSize)
                {
                    throw new EClientException(EClientErrors.BAD_LENGTH);
                }

                return new EMessage(eClientSocket.ReadByteArray(msgSize));
            }

            if (inBuf.Count == 0)
            {
                AppendInBuf();
            }

            while (true)
            {
                try
                {
                    msgSize = new EDecoder(eClientSocket.ServerVersion, defaultWrapper).ParseAndProcessMsg(inBuf.ToArray());

                    break;
                }
                catch (EndOfStreamException)
                {
                    if (inBuf.Count >= inBuf.Capacity * 3 / 4)
                    {
                        inBuf.Capacity *= 2;
                    }

                    AppendInBuf();
                }
            }

            var msgBuf = new byte[msgSize];

            inBuf.CopyTo(0, msgBuf, 0, msgSize);
            inBuf.RemoveRange(0, msgSize);

            if (inBuf.Count < defaultInBufSize && inBuf.Capacity > defaultInBufSize)
            {
                inBuf.Capacity = defaultInBufSize;
            }

            return new EMessage(msgBuf);
        }

        private void AppendInBuf()
        {
            inBuf.AddRange(eClientSocket.ReadAtLeastNBytes(inBuf.Capacity - inBuf.Count));
        }
    }
}
