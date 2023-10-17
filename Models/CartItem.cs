using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13.Models
{
    internal class CartItem
    { int count = 1;
        public int ID { get; }
        public string Name { get; set; }
        public int Quentity { get; set; }
        public double Price { get; set; }

        public CartItem(string name,int quantity,double price)
        {
            ID = count++;
            Name = name;
            Quentity = quantity;
            Price = price;

        }
    }
}
