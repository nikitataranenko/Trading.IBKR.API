/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System.IO;

namespace Trading.IBKR.API
{
    public abstract class OperatorCondition : OrderCondition
    {
        private const string header = " is ";
        public bool IsMore { get; set; }
        protected abstract string Value { get; set; }

        public override string ToString()
        {
            return header + (IsMore ? ">= " : "<= ") + Value;
        }

        public override bool Equals(object obj)
        {
            var other = obj as OperatorCondition;

            if (other == null)
            {
                return false;
            }

            return base.Equals(obj) && Value.Equals(other.Value) && IsMore == other.IsMore;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + Value.GetHashCode() + IsMore.GetHashCode();
        }

        public override void Deserialize(IDecoder inStream)
        {
            base.Deserialize(inStream);

            IsMore = inStream.ReadBoolFromInt();
            Value  = inStream.ReadString();
        }

        public override void Serialize(BinaryWriter outStream)
        {
            base.Serialize(outStream);
            outStream.AddParameter(IsMore);
            outStream.AddParameter(Value);
        }

        protected override bool TryParse(string cond)
        {
            if (!cond.StartsWith(header))
            {
                return false;
            }

            try
            {
                cond = cond.Replace(header, "");

                if (!cond.StartsWith(">=") && !cond.StartsWith("<="))
                {
                    return false;
                }

                IsMore = cond.StartsWith(">=");

                if (base.TryParse(cond.Substring(cond.LastIndexOf(" "))))
                {
                    cond = cond.Substring(0, cond.LastIndexOf(" "));
                }

                Value = cond.Substring(3);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
