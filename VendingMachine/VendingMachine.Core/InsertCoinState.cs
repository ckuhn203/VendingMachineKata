﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending.Core
{
    public class InsertCoinState : VendingMachineState
    {
        public string Display()
        {
            return "INSERT COIN";
        }
    }
}