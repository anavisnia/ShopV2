using ShopV2.Helpers;
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

        public void AddItem(string name, int quantity)
        {
            bool isUpperCase = HelperFunctions.UpperOrLower(name);
            if (!isUpperCase)
            {
                name = HelperFunctions.ToUpperCase(name);
            }

            bool doExist = Items.Any(p => p.Name == name);
            if (doExist)
            {
                _logger.Write($"Item with this name already exist: {name}.");
                return;
            }

            Item toAddItem = new Item() { Name = name, Quantity = quantity };
            this.Items.Add(toAddItem);
            _logger.Write($"Item added: {name}, quantity {quantity}");
        }

        public void Buy()
        {
            string itemName;
            //Extra logic
            //Console.WriteLine($"{itemName} has been bought");
            itemName = _logger.Read();
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
