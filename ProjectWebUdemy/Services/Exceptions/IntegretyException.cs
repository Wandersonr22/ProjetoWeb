﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebUdemy.Services.Exceptions
{
    public class IntegretyException : ApplicationException
    {
        public IntegretyException(string message) : base(message)
        {
        }
    }
}
