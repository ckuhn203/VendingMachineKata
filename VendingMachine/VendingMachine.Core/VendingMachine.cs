﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending.Core
{
    public enum Coin { Nickel }

    public class VendingMachine
    {
        List<Coin> _coins = new List<Coin>();

        public string GetDisplayText()
        {
            if (!_coins.Any())
            {
                return "INSERT COIN";
            }

            return $"{CurrentTotal():C}";
        }

        private decimal CurrentTotal()
        {
            //note: can't just _coins.Sum because coins don't know their value
            return (_coins.Count*5.0m)/100;
        }

        public void Accept(Coin coin)
        {
            _coins.Add(coin);
        }
    }
}
