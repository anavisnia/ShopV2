using ShopV2.Interfaces;
using System;

namespace ShopV2.Loggers
{
    public class ConsoleLogger : IWriter
    {
        public void Write(string input)
        {
            Console.WriteLine(input);
        }

        public void ListAllCommands()
        {
            Write("List of commands:");
            Write("Write 'Add' to add products to the store:'Add Cup 80' and press enter");
            Write("Write 'Buy' to buy products: 'Buy Cup 80' and press enter");
            Write("Write 'List' to see all available products, their price and quantity: 'List' and press enter");
            Write("Write 'Exit' and press enter to stop the program");
        }

        public string Read()
        {
            return Console.ReadLine();
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}
