using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static void Main()
        {
            List<Pizza> OrderQueue = GetOrders();
            foreach (var item in OrderQueue)
            {
                item.Prepare();
            }
        }

        private static List<Pizza> GetOrders()
        {
            var orders = new List<Pizza>()
            {
                new Pizza("Margherita", new string[] { "tomatoes", "basil", "mozzarella" }),
                new Pizza("Pepperoni", new string[] { "pepperoni", "mozzarella" }),
            };
            return orders;
        }
    }
}
