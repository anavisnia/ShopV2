using ShopV2.Interfaces;
using System;
using System.IO;

namespace ShopV2.Loggers
{
    public class FileLogger : IWriter
    {
        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void ListAllCommands()
        {
            throw new NotImplementedException();
        }

        public string Read()
        {
            throw new NotImplementedException();
        }

        public void Write(string input)
        {
            File.WriteAllText("path", input);
        }


    }
}
