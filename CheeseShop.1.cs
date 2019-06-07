using System;
using System.Collections.Generic;

namespace Store
{
    public class CheeseBasketShop : IShop<Basket<Cheese>>
    {

        private Dictionary<string, Basket<Cheese>> _inventory =
            new Dictionary<string, Basket<Cheese>>();

        private Dictionary<string, double> _prices =
            new Dictionary<string, double>();

        public void AddProductToSell(
            string name, double price, Basket<Cheese> cheese)
        {
            _inventory.Add(name, cheese);
            _prices.Add(name, price);
        }

        public Basket<Cheese> Sell(string name, double payment)
        {
            double price = _prices[name];
            if (payment >= price)
            {
                return _inventory[name];
            }
            throw new Exception("Not enough payment!");
        }
    }
}
