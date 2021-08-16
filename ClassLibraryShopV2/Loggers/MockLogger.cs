using ShopV2.Interfaces;
using System;

namespace ShopV2.Loggers
{
    public class MockLogger : IWriter
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
            //Do nothing
        }
    }
}
