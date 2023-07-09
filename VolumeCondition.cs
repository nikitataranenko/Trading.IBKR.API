/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System.Globalization;

namespace Trading.IBKR.API
{
    /**
    * @brief Used with conditional orders to submit or cancel an order based on a specified volume change in a security. 
    */
    public class VolumeCondition : ContractCondition
    {
        public int Volume { get; set; }

        protected override string Value
        {
            get => Volume.ToString(NumberFormatInfo.InvariantInfo);
            set => Volume = int.Parse(value, NumberFormatInfo.InvariantInfo);
        }
    }
}
