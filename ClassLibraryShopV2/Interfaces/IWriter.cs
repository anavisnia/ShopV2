using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopV2.Interfaces
{
    public interface IWriter
    {
        void Write(string input);

        string Read();

        void Clear();
    }


}
