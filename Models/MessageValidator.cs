﻿/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

//Hint. we could separate the message validation from the Socket client class...

namespace Trading.IBKR.API.Models
{
    public class MessageValidator
    {
        public MessageValidator(int serverVersion)
        {
            ServerVersion = serverVersion;
        }

        public int ServerVersion { get; set; }
    }
}
