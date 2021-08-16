using ShopV2.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopV2.Loggers
{
    public class MockLogger : IWriter
    {
        public void Clear()
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
