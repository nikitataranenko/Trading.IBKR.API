/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;
using System.IO;

namespace Trading.IBKR.API.Models
{
    public abstract class ContractCondition : OperatorCondition
    {
        private const string delimiter = " of ";

        protected ContractCondition()
        {
            ContractResolver = (conid, exch) => conid + "(" + exch + ")";
        }

        public int ConId { get; set; }
        public string Exchange { get; set; }

        public Func<int, string, string> ContractResolver { get; set; }

        public override string ToString()
        {
            return Type + delimiter + ContractResolver(ConId, Exchange) + base.ToString();
        }

        public override bool Equals(object obj)
        {
            var other = obj as ContractCondition;

            if (other == null)
            {
                return false;
            }

            return base.Equals(obj) && ConId == other.ConId && Exchange.Equals(other.Exchange);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + ConId.GetHashCode() + Exchange.GetHashCode();
        }

        public override void Deserialize(IDecoder inStream)
        {
            base.Deserialize(inStream);

            ConId = inStream.ReadInt();
            Exchange = inStream.ReadString();
        }

        public override void Serialize(BinaryWriter outStream)
        {
            base.Serialize(outStream);
            outStream.AddParameter(ConId);
            outStream.AddParameter(Exchange);
        }

        protected override bool TryParse(string cond)
        {
            try
            {
                if (cond.Substring(0, cond.IndexOf(delimiter, StringComparison.InvariantCultureIgnoreCase)) != Type.ToString())
                {
                    return false;
                }

                cond = cond.Substring(cond.IndexOf(delimiter, StringComparison.InvariantCultureIgnoreCase) + delimiter.Length);

                if (!int.TryParse(cond.Substring(0, cond.IndexOf("(", StringComparison.InvariantCultureIgnoreCase)), out var conid))
                {
                    return false;
                }

                ConId = conid;
                cond = cond.Substring(cond.IndexOf("(", StringComparison.InvariantCultureIgnoreCase) + 1);
                Exchange = cond.Substring(0, cond.IndexOf(")", StringComparison.InvariantCultureIgnoreCase));
                cond = cond.Substring(cond.IndexOf(")", StringComparison.InvariantCultureIgnoreCase) + 1);

                return base.TryParse(cond);
            }
            catch
            {
                return false;
            }
        }
    }
}
