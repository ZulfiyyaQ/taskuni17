using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13.Models
{
    internal class Product
    {
        int count = 1;
        public int ID{ get;}
        public string Name { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }

        public Product(string name,int stock,double price)
        {
            ID = count++;
            Name = name;
            Stock = stock;
            Price = price;

        }
    }
}
