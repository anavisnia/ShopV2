using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopV2.Helpers
{
    public class HelperFunctions
    {
        public static bool UpperOrLower(string text)
        {
            if (char.IsUpper(text[0]))
            {
                return true;
            }
            else if (string.IsNullOrEmpty(text))
            {
                return false;
            }
            else
            {
                return false;
            };

        }
        public static string ToUpperCase(string text)
        {
            return char.ToUpper(text[0]) + text.Substring(1);
        }
    }
}
