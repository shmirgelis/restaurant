using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static void Main()
        {
            List<IPrepareFood> OrderQueue = GetOrders();
            foreach (var item in OrderQueue)
            {
                System.Console.WriteLine(item.Name);
                item.Prepare();
                             
            }
        }

        private static List<IPrepareFood> GetOrders()
        {
            var orders = new List<IPrepareFood>()
            {
                new Pizza("Margherita", new string[] { "tomatoes", "basil", "mozzarella" }),
                new Pizza("Margherita", new string[] { "tomatoes", "basil", "mozzarella" }),  
                new Pizza("Pepperoni", new string[] { "pepperoni", "mozzarella" }), 
                new Soup("Morku", "Darzoviu", new string[] {"morkos", "svogunai", "mesa", "pipirai", "druska" })
            };
            return orders;
        }
    }
}
