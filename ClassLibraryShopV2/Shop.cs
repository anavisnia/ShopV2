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

        private string userInput;

        private int itemQuantity;

        private bool exit = false;

        public List<Item> Items { get; set; }

        public Shop(IWriter logger)
        {
            _logger = logger;
            Items = new List<Item>();
            AddItem("Cup", 20);
            AddItem("Candy", 40);
            AddItem("Book", 70);
            _logger.Clear();
        }

        public void Start()
        {
            _logger.Write("===== Console Shop =====");
            do
            {
                _logger.Write("List of commands:");
                _logger.Write("Write 'Add' to add products to the store:'Add Cup 80' and press enter");
                _logger.Write("Write 'Buy' to buy products: 'Buy Cup 80' and press enter");
                _logger.Write("Write 'List' to see all available products, their price and quantity: 'List' and press enter");
                _logger.Write("Write 'Exit' and press enter to stop the program");
                userInput = _logger.Read().Trim();

                List<string> userInputList = userInput.Trim().Split(' ').ToList();
                userInputList = userInputList.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

                //int itemQuantity;
                switch (userInputList[0])
                {
                    case "List":
                        ListItems();
                        break;
                    case "Add":
                        Int32.TryParse(userInputList[2], out itemQuantity);
                        AddItem(userInputList[1], itemQuantity);
                        break;
                    case "Buy":
                        Int32.TryParse(userInputList[2], out itemQuantity);
                        Buy(userInputList[1], itemQuantity);
                        break;
                    case "Exit":
                        exit = true;
                        break;
                    default:
                        _logger.Write("Nothing related was writen...");
                        break;
                }
            } while (!exit);
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

        public void ListItems()
        {
            _logger.Write("List of items:");
            foreach (var item in Items)
            {
                if (item.Quantity != 0)
                {
                    _logger.Write(item.ToDescriptionString());
                }
            }
        }

        public void Buy(string name, int quantity)
        {
            bool isUpperCase = HelperFunctions.UpperOrLower(name);
            if (!isUpperCase)
            {
                name = HelperFunctions.ToUpperCase(name);
            }

            bool doExist = Items.Any(p => p.Name == name);
            if (doExist)
            {
                try
                {
                    foreach (var item in Items)
                    {
                        if (item.Name == name && item.Quantity != 0)
                        {
                            if (quantity > item.Quantity)
                            {
                                _logger.Write($"You can't buy more than {item.Quantity}");
                                return;
                            }
                            item.Quantity -= quantity;
                            _logger.Write($"You succsessfully bought {quantity} {name}");
                        }
                        else if (item.Name == name && item.Quantity == 0)
                        {
                            _logger.Write("There are no products left");
                        };
                        if (item.Quantity == 0)
                        {
                            Items.Remove(item);
                        }
                    }
                }
                catch (Exception)
                {
                    //Console.WriteLine("catched");
                }
            }
            else
            {
                _logger.Write("Such product do not exist...");
            }
        }
    }
}
