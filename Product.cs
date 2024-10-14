using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Product_1
{
    class Product
    {
        public string Name;
        public string BrandName;
        public int Price;

        public Product()
        {

        }
        public Product(string name, string brandname)
        {
            this.BrandName = brandname;
        }
        public Product(string name, string brandname, int price = 17)
        {
            this.Name = name;
            this.BrandName = brandname;
            this.Price = price;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {BrandName} {Price}");
        }
    }
}
