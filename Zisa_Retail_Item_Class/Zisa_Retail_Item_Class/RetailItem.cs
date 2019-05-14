using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zisa_Retail_Item_Class
{
    public class RetailItem
    {
        public string Description { get; set; }
        public string UnitsOnHand { get; set; }
        public string Price { get; set; }

        public RetailItem(string description, string unitsOnHand, string price)
        {
            Description = description;
            UnitsOnHand = unitsOnHand;
            Price = price;
        }
    }
}
