﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class ConsumerCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Consumer Credit payment plan has been calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
