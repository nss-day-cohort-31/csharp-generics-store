using System;
using System.Collections.Generic;

namespace Store {
    public class CellPhoneShop : IShop<CellPhone>
    {
        private readonly double _price = 250.00;
        private Dictionary<string, CellPhone> _inventory =
            new Dictionary<string, CellPhone>();

        public void AddProductToSell(
            string name, double price, CellPhone product)
        {
            _inventory.Add(name, product);
        }

        public CellPhone Sell(string name, double payment)
        {
            if (payment >= _price) {
                return _inventory[name];
            }
            throw new Exception("bad payment");
        }
    }
}