﻿/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System.Globalization;

namespace Trading.IBKR.API.Models
{
    /**
    * @class MarginCondition
    * @brief This class represents a condition requiring the margin cushion reaching a given percent to be fulfilled.
    * Orders can be activated or canceled if a set of given conditions is met. A MarginCondition is met whenever the margin penetrates the given percent.
    */
    public class MarginCondition : OperatorCondition
    {
        private const string header = "the margin cushion percent";

        /**
        * @brief Margin percent to trigger condition.
        */
        public int Percent { get; set; }

        protected override string Value
        {
            get => Percent.ToString(NumberFormatInfo.InvariantInfo);
            set => Percent = int.Parse(value, NumberFormatInfo.InvariantInfo);
        }

        public override string ToString()
        {
            return header + base.ToString();
        }

        protected override bool TryParse(string cond)
        {
            if (!cond.StartsWith(header))
            {
                return false;
            }

            cond = cond.Replace(header, "");

            return base.TryParse(cond);
        }
    }
}
