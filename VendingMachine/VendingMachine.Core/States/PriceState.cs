﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Vending.Core.States
{
    public class PriceState : VendingMachineState
    {
        private readonly decimal _priceInCents;

        public PriceState(VendingMachineState state, int priceInCents)
            :this(state.Context, state.ReturnTray, state.Coins, state.ProductInfoRepository, state.Output, priceInCents)
        {
        }

        public PriceState(StateContext context, List<Coin> returnTray, List<Coin> coins, ProductInfoRepository productInfoRepository, List<string> output, int priceInCents)
            :base(context, returnTray, coins, productInfoRepository, output)
        {
            _priceInCents = priceInCents;
        }

        public override string Display()
        {
            return $"PRICE: {_priceInCents/100:C}";
        }

        protected override void DispenseCallback(string sku)
        {
            // no op
        }
    }
}
