/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

namespace Trading.IBKR.API
{
    /**
     * @class OrderComboLeg
     * @brief Allows to specify a price on an order's leg
     * @sa Order, ComboLeg
     */
    public class OrderComboLeg
    {
        public OrderComboLeg()
        {
            Price = double.MaxValue;
        }

        public OrderComboLeg(double p_price)
        {
            Price = p_price;
        }

        /**
         * @brief The order's leg's price
         */
        public double Price { get; set; }

        public override bool Equals(object other)
        {
            var theOther = other as OrderComboLeg;
            if (theOther == null)
            {
                return false;
            }

            if (this == other)
            {
                return true;
            }

            return Price == theOther.Price;
        }

        public override int GetHashCode()
        {
            return -814345894 + Price.GetHashCode();
        }
    }
}
