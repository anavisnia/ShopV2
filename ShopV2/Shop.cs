using ShopV2.Interfaces;
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

        public Shop(IWriter logger)
        {
            _logger = logger;
        }

        public void Buy(string itemName)
        {
            //Extra logic
            //Console.WriteLine($"{itemName} has been bought");
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
