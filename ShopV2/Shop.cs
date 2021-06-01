using ShopV2.Interfaces;
using ShopV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopV2
{
    public class Shop
    {
        //absrtakcija
        private IWriter _logger;

        public List<Item> Items { get; set; }

        public Shop(IWriter logger)
        {
            _logger = logger;
            Items = new List<Item>();
        }

        public void Buy()
        {
            //Extra logic
            //Console.WriteLine($"{itemName} has been bought");
            string itemName = _logger.Read();
            _logger.Write($"{itemName} has been bought");
        }

        public void Stockup(string itemName)
        {
            //Extra logic
            //Console.WriteLine($"{itemName} has been stocked up");
            _logger.Write($"{itemName} has been stocked up");
        }
    }
}
