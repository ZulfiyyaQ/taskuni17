using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13.Models
{
    internal class OnlineMarket
    {
        int count = 1;
        public CartItemList Cart { get; private set; }
        public ProductList Products { get;private  set; }

        public string Name { get; set; }
        public int ID { get; }


        public OnlineMarket(string name)
        {
            ID = count++;
            Name = name;

        }

        public void AddToCart ()
        {

        }
    }
}
