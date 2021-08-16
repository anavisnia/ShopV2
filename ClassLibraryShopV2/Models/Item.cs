using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopV2.Models
{
    public class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public virtual string ToDescriptionString()
        {
            return $"Name: {Name} Quantity: { Quantity }";
        }
    }
}
