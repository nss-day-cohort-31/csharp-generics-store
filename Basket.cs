using System.Collections.Generic;

namespace Store
{
    public class Basket<T>
    {
        public List<T> Items { get; set; } = new List<T>();
    }
}