using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69CoffeeShop.Class
{
    public class Product
    {
        public string productID { get; set; }
        public string productName { get; set; }
        public string unitPrice { get; set; }
        public string unitCost { get; set; }
        public string imageURL { get; set; }

        public Product(string productID, string productName, string unitPrice, string unitCost, string imageURL)
        {
            this.productID = productID;
            this.productName = productName;
            this.unitPrice = unitPrice;
            this.unitCost = unitCost;
            this.imageURL = imageURL;
        }
    }
}
