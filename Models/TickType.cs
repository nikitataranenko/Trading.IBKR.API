﻿/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

namespace Trading.IBKR.API.Models
{
    /**
    * @brief - DOC_TODO
    */
    public class TickType
    {
        public const int BID_SIZE = 0;
        public const int BID = 1;
        public const int ASK = 2;
        public const int ASK_SIZE = 3;
        public const int LAST = 4;
        public const int LAST_SIZE = 5;
        public const int HIGH = 6;
        public const int LOW = 7;
        public const int VOLUME = 8;
        public const int CLOSE = 9;
        public const int BID_OPTION = 10;
        public const int ASK_OPTION = 11;
        public const int LAST_OPTION = 12;
        public const int MODEL_OPTION = 13;
        public const int OPEN = 14;
        public const int LOW_13_WEEK = 15;
        public const int HIGH_13_WEEK = 16;
        public const int LOW_26_WEEK = 17;
        public const int HIGH_26_WEEK = 18;
        public const int LOW_52_WEEK = 19;
        public const int HIGH_52_WEEK = 20;
        public const int AVG_VOLUME = 21;
        public const int OPEN_INTEREST = 22;
        public const int OPTION_HISTORICAL_VOL = 23;
        public const int OPTION_IMPLIED_VOL = 24;
        public const int OPTION_BID_EXCH = 25;
        public const int OPTION_ASK_EXCH = 26;
        public const int OPTION_CALL_OPEN_INTEREST = 27;
        public const int OPTION_PUT_OPEN_INTEREST = 28;
        public const int OPTION_CALL_VOLUME = 29;
        public const int OPTION_PUT_VOLUME = 30;
        public const int INDEX_FUTURE_PREMIUM = 31;
        public const int BID_EXCH = 32;
        public const int ASK_EXCH = 33;
        public const int AUCTION_VOLUME = 34;
        public const int AUCTION_PRICE = 35;
        public const int AUCTION_IMBALANCE = 36;
        public const int MARK_PRICE = 37;
        public const int BID_EFP_COMPUTATION = 38;
        public const int ASK_EFP_COMPUTATION = 39;
        public const int LAST_EFP_COMPUTATION = 40;
        public const int OPEN_EFP_COMPUTATION = 41;
        public const int HIGH_EFP_COMPUTATION = 42;
        public const int LOW_EFP_COMPUTATION = 43;
        public const int CLOSE_EFP_COMPUTATION = 44;
        public const int LAST_TIMESTAMP = 45;
        public const int SHORTABLE = 46;
        public const int FUNDAMENTAL_RATIOS = 47;
        public const int RT_VOLUME = 48;
        public const int HALTED = 49;
        public const int BID_YIELD = 50;
        public const int ASK_YIELD = 51;
        public const int LAST_YIELD = 52;
        public const int CUST_OPTION_COMPUTATION = 53;
        public const int TRADE_COUNT = 54;
        public const int TRADE_RATE = 55;
        public const int VOLUME_RATE = 56;
        public const int LAST_RTH_TRADE = 57;
        public const int RT_HISTORICAL_VOL = 58;
        public const int IB_DIVIDENDS = 59;
        public const int BOND_FACTOR_MULTIPLIER = 60;
        public const int REGULATORY_IMBALANCE = 61;
        public const int NEWS_TICK = 62;
        public const int SHORT_TERM_VOLUME_3_MIN = 63;
        public const int SHORT_TERM_VOLUME_5_MIN = 64;
        public const int SHORT_TERM_VOLUME_10_MIN = 65;
        public const int DELAYED_BID = 66;
        public const int DELAYED_ASK = 67;
        public const int DELAYED_LAST = 68;
        public const int DELAYED_BID_SIZE = 69;
        public const int DELAYED_ASK_SIZE = 70;
        public const int DELAYED_LAST_SIZE = 71;
        public const int DELAYED_HIGH = 72;
        public const int DELAYED_LOW = 73;
        public const int DELAYED_VOLUME = 74;
        public const int DELAYED_CLOSE = 75;
        public const int DELAYED_OPEN = 76;
        public const int RT_TRD_VOLUME = 77;
        public const int CREDITMAN_MARK_PRICE = 78;
        public const int CREDITMAN_SLOW_MARK_PRICE = 79;
        public const int DELAYED_BID_OPTION = 80;
        public const int DELAYED_ASK_OPTION = 81;
        public const int DELAYED_LAST_OPTION = 82;
        public const int DELAYED_MODEL_OPTION = 83;
        public const int LAST_EXCH = 84;
        public const int LAST_REG_TIME = 85;
        public const int FUTURES_OPEN_INTEREST = 86;
        public const int AVG_OPT_VOLUME = 87;
        public const int DELAYED_LAST_TIMESTAMP = 88;
        public const int SHORTABLE_SHARES = 89;
        public const int DELAYED_HALTED = 90;
        public const int REUTERS_2_MUTUAL_FUNDS = 91;
        public const int ETF_NAV_CLOSE = 92;
        public const int ETF_NAV_PRIOR_CLOSE = 93;
        public const int ETF_NAV_BID = 94;
        public const int ETF_NAV_ASK = 95;
        public const int ETF_NAV_LAST = 96;
        public const int ETF_FROZEN_NAV_LAST = 97;
        public const int ETF_NAV_HIGH = 98;
        public const int ETF_NAV_LOW = 99;
        public const int SOCIAL_MARKET_ANALYTICS = 100;
        public const int ESTIMATED_IPO_MIDPOINT = 101;
        public const int FINAL_IPO_LAST = 102;
        public const int DELAYED_YIELD_BID = 103;
        public const int DELAYED_YIELD_ASK = 104;

        public static string getField(int tickType)
        {
            switch (tickType)
            {
                case BID_SIZE:
                    return "bidSize";
                case BID:
                    return "bidPrice";
                case ASK:
                    return "askPrice";
                case ASK_SIZE:
                    return "askSize";
                case LAST:
                    return "lastPrice";
                case LAST_SIZE:
                    return "lastSize";
                case HIGH:
                    return "high";
                case LOW:
                    return "low";
                case VOLUME:
                    return "volume";
                case CLOSE:
                    return "close";
                case BID_OPTION:
                    return "bidOptComp";
                case ASK_OPTION:
                    return "askOptComp";
                case LAST_OPTION:
                    return "lastOptComp";
                case MODEL_OPTION:
                    return "modelOptComp";
                case OPEN:
                    return "open";
                case LOW_13_WEEK:
                    return "13WeekLow";
                case HIGH_13_WEEK:
                    return "13WeekHigh";
                case LOW_26_WEEK:
                    return "26WeekLow";
                case HIGH_26_WEEK:
                    return "26WeekHigh";
                case LOW_52_WEEK:
                    return "52WeekLow";
                case HIGH_52_WEEK:
                    return "52WeekHigh";
                case AVG_VOLUME:
                    return "AvgVolume";
                case OPEN_INTEREST:
                    return "OpenInterest";
                case OPTION_HISTORICAL_VOL:
                    return "OptionHistoricalVolatility";
                case OPTION_IMPLIED_VOL:
                    return "OptionImpliedVolatility";
                case OPTION_BID_EXCH:
                    return "OptionBidExchStr";
                case OPTION_ASK_EXCH:
                    return "OptionAskExchStr";
                case OPTION_CALL_OPEN_INTEREST:
                    return "OptionCallOpenInterest";
                case OPTION_PUT_OPEN_INTEREST:
                    return "OptionPutOpenInterest";
                case OPTION_CALL_VOLUME:
                    return "OptionCallVolume";
                case OPTION_PUT_VOLUME:
                    return "OptionPutVolume";
                case INDEX_FUTURE_PREMIUM:
                    return "IndexFuturePremium";
                case BID_EXCH:
                    return "bidExch";
                case ASK_EXCH:
                    return "askExch";
                case AUCTION_VOLUME:
                    return "auctionVolume";
                case AUCTION_PRICE:
                    return "auctionPrice";
                case AUCTION_IMBALANCE:
                    return "auctionImbalance";
                case MARK_PRICE:
                    return "markPrice";
                case BID_EFP_COMPUTATION:
                    return "bidEFP";
                case ASK_EFP_COMPUTATION:
                    return "askEFP";
                case LAST_EFP_COMPUTATION:
                    return "lastEFP";
                case OPEN_EFP_COMPUTATION:
                    return "openEFP";
                case HIGH_EFP_COMPUTATION:
                    return "highEFP";
                case LOW_EFP_COMPUTATION:
                    return "lowEFP";
                case CLOSE_EFP_COMPUTATION:
                    return "closeEFP";
                case LAST_TIMESTAMP:
                    return "lastTimestamp";
                case SHORTABLE:
                    return "shortable";
                case FUNDAMENTAL_RATIOS:
                    return "fundamentals";
                case RT_VOLUME:
                    return "RTVolume";
                case HALTED:
                    return "halted";
                case BID_YIELD:
                    return "bidYield";
                case ASK_YIELD:
                    return "askYield";
                case LAST_YIELD:
                    return "lastYield";
                case CUST_OPTION_COMPUTATION:
                    return "custOptComp";
                case TRADE_COUNT:
                    return "trades";
                case TRADE_RATE:
                    return "trades/min";
                case VOLUME_RATE:
                    return "volume/min";
                case LAST_RTH_TRADE:
                    return "lastRTHTrade";
                case RT_HISTORICAL_VOL:
                    return "RTHistoricalVol";
                case IB_DIVIDENDS:
                    return "IBDividends";
                case BOND_FACTOR_MULTIPLIER:
                    return "bondFactorMultiplier";
                case REGULATORY_IMBALANCE:
                    return "regulatoryImbalance";
                case NEWS_TICK:
                    return "newsTick";
                case SHORT_TERM_VOLUME_3_MIN:
                    return "shortTermVolume3Min";
                case SHORT_TERM_VOLUME_5_MIN:
                    return "shortTermVolume5Min";
                case SHORT_TERM_VOLUME_10_MIN:
                    return "shortTermVolume10Min";
                case DELAYED_BID:
                    return "delayedBid";
                case DELAYED_ASK:
                    return "delayedAsk";
                case DELAYED_LAST:
                    return "delayedLast";
                case DELAYED_BID_SIZE:
                    return "delayedBidSize";
                case DELAYED_ASK_SIZE:
                    return "delayedAskSize";
                case DELAYED_LAST_SIZE:
                    return "delayedLastSize";
                case DELAYED_HIGH:
                    return "delayedHigh";
                case DELAYED_LOW:
                    return "delayedLow";
                case DELAYED_VOLUME:
                    return "delayedVolume";
                case DELAYED_CLOSE:
                    return "delayedClose";
                case DELAYED_OPEN:
                    return "delayedOpen";
                case RT_TRD_VOLUME:
                    return "rtTrdVolume";
                case CREDITMAN_MARK_PRICE:
                    return "creditmanMarkPrice";
                case CREDITMAN_SLOW_MARK_PRICE:
                    return "creditmanSlowMarkPrice";
                case DELAYED_BID_OPTION:
                    return "delayedBidOptComp";
                case DELAYED_ASK_OPTION:
                    return "delayedAskOptComp";
                case DELAYED_LAST_OPTION:
                    return "delayedLastOptComp";
                case DELAYED_MODEL_OPTION:
                    return "delayedModelOptComp";
                case LAST_EXCH:
                    return "lastExchange";
                case LAST_REG_TIME:
                    return "lastRegTime";
                case FUTURES_OPEN_INTEREST:
                    return "futuresOpenInterest";
                case AVG_OPT_VOLUME:
                    return "avgOptVolume";
                case DELAYED_LAST_TIMESTAMP:
                    return "delayedLastTimestamp";
                case SHORTABLE_SHARES:
                    return "shortableShares";
                case DELAYED_HALTED:
                    return "delayedHalted";
                case REUTERS_2_MUTUAL_FUNDS:
                    return "reuters2MutualFunds";
                case ETF_NAV_CLOSE:
                    return "etfNavClose";
                case ETF_NAV_PRIOR_CLOSE:
                    return "etfNavPriorClose";
                case ETF_NAV_BID:
                    return "etfNavBid";
                case ETF_NAV_ASK:
                    return "etfNavAsk";
                case ETF_NAV_LAST:
                    return "etfNavLast";
                case ETF_FROZEN_NAV_LAST:
                    return "etfFrozenNavLast";
                case ETF_NAV_HIGH:
                    return "etfNavHigh";
                case ETF_NAV_LOW:
                    return "etfNavLow";
                case SOCIAL_MARKET_ANALYTICS:
                    return "socialMarketAnalytics";
                case ESTIMATED_IPO_MIDPOINT:
                    return "estimatedIPOMidpoint";
                case FINAL_IPO_LAST:
                    return "finalIPOLast";
                case DELAYED_YIELD_BID:
                    return "delayedYieldBid";
                case DELAYED_YIELD_ASK:
                    return "delayedYieldAsk";
                default:
                    return "unknown";
            }
        }
    }
}
