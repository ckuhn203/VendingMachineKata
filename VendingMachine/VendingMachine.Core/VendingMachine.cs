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

            //note: can't just _coins.Sum because coins don't know their value
            var total = (_coins.Count*5.0)/100;
            return $"{total:C}";
        }

        public void Accept(Coin coin)
        {
            _coins.Add(coin);
        }
    }
}
