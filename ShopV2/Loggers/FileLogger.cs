using ShopV2.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopV2.Loggers
{
    public class FileLogger : IWriter
    {
        public void Write(string input)
        {
            File.WriteAllText("path", input);
        }
    }
}
