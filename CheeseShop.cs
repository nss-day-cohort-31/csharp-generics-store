using System;
using System.Collections.Generic;

namespace Store
{
    public class CheeseShop : IShop<Cheese>
    {

        private Dictionary<string, Cheese> _inventory =
            new Dictionary<string, Cheese>();

        private Dictionary<string, double> _prices =
            new Dictionary<string, double>();

        public void AddProductToSell(
            string name, double price, Cheese cheese)
        {
            _inventory.Add(name, cheese);
            _prices.Add(name, price);
        }

        public Cheese Sell(string name, double payment)
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
