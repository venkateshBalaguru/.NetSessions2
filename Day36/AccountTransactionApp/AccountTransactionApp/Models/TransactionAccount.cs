﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTransactionApp.Models
{
    internal class TransactionAccount
    {
        public string Type { get; set; }
        public double Amount { get; set; }

        public DateTime Date { get; set; }

    }
}