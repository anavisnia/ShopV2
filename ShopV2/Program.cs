using ShopV2.Interfaces;
using ShopV2.Loggers;
using System;

namespace ShopV2
{
    class Program
    {
        static void Main(string[] args)
        {
            IWriter logger = new ConsoleLogger();

            var shop = new Shop(logger);

            shop.AddItem("Apple", 20);
            shop.AddItem("Pen", 60);
            shop.AddItem("Book", 10);
            shop.ListItems();
        }
    }
}
