﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDSA2018.Lecture08.Models.ChainOfResponsibility
{
    public class Purchase
    {
        public int Number { get; set; }

        public double Amount { get; set; }

        public string Purpose { get; set; }

        public Purchase(int number, double amount, string purpose)
        {
            Number = number;
            Amount = amount;
            Purpose = purpose;
        }
    }
}
