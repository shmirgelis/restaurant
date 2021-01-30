using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Restaurant
{
    public class Soup
    {
        private readonly string[] _ingridients;
        private readonly string _stock;
        public string Name { get; }
        public Soup(string name, string stock, string[] ingridients)
        {
            Name = name;
            _stock = stock;
            _ingridients = ingridients;
        }

        public void MakeSoup()
        {
            Console.WriteLine($"Making {Name} soup");
            AddStock();
            AddIngridients();
            Cook();
            Console.WriteLine("Soup is ready, n'joy!!!\n");
        }

        private void Cook()
        {
            for(int i = 0; i<2; i++)
            {
                Console.WriteLine("Cooking..");
                Thread.Sleep(500);
            }
            Console.WriteLine($"Cooked !!!");
            Thread.Sleep(500);
        }

        private void AddStock()
        {
            Console.WriteLine($"Pouring {_stock} stock..");
            Thread.Sleep(500);
        }

        private void AddIngridients()
        {
            foreach (string ingridient in _ingridients)
            {
                Console.WriteLine($"Adding {ingridient}..");
                Thread.Sleep(1000);
            }
        }
    }
}
