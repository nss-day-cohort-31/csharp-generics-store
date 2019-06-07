using System;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            CheeseShop shop = new CheeseShop();
            Cheese gouda = new Cheese() {
                Name = "gouda",
                IsFunky = false,
                AgeInMonths = 2
            };

            shop.AddProductToSell(gouda.Name, 14.00, gouda);
            Cheese purchased = shop.Sell("gouda", 20.00);
            Console.WriteLine($"I bought some {purchased.Name}");

            CellPhoneShop phoneShop = new CellPhoneShop();
            CellPhone phone = new CellPhone() {
                Name = "Razor",
                IsFlip = true,
                Provider = "T-Mobile"
            };

            phoneShop.AddProductToSell(phone.Name, 0.0, phone);
            CellPhone purchasedPhone = phoneShop.Sell("Razor", 300.00);
            Console.WriteLine($"I bought a {purchasedPhone.Name}");

            CellPhone anotherPhone = phoneShop.Sell("Razor", 2);
            Console.WriteLine($"I bought a {anotherPhone.Name}");
        }
    }
}
