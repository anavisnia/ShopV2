﻿using ShopV2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopV2.Loggers
{
    public class ConsoleLogger : IWriter
    {
        public void Write(string input)
        {
            Console.WriteLine(input);
        }
    }
}