﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class NotAvailableException:Exception
    {
        public NotAvailableException(string message):base(message)
        {

        }
    }
}
