﻿/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System.Globalization;

namespace Trading.IBKR.API.Models
{
    /**
    * @brief Used with conditional orders to place or submit an order based on a percentage change of an instrument to the last close price.
    */
    public class PercentChangeCondition : ContractCondition
    {
        public double ChangePercent { get; set; }

        protected override string Value
        {
            get => ChangePercent.ToString(NumberFormatInfo.InvariantInfo);
            set => ChangePercent = double.Parse(value, NumberFormatInfo.InvariantInfo);
        }
    }
}