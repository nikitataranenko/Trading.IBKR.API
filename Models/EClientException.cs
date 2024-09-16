/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;

namespace Trading.IBKR.API.Models
{
    public class EClientException : Exception
    {
        public EClientException(CodeMsgPair err)
        {
            Err = err;
        }

        public EClientException(CodeMsgPair err, string text) : this(err)
        {
            Text = text;
        }

        public CodeMsgPair Err { get; }
        public string Text { get; }
    }
}
