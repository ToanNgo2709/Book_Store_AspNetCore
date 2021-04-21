﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreAspNetCore.Utilities
{
    public class MyException : Exception
    {
        public MyException()
        {

        }

        public MyException(string message) : base(message)
        {

        }

        public MyException(string message, Exception inner) : base(message, inner)
        {

        }

    }
}
