using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13.Models
{
    internal class CartItemList
    {
        CartItem[] _cartitem = new CartItem[0];

        public int Length { get { return _cartitem.Length; } }
        public CartItem this[int index]
        {
            get
            {
                return _cartitem[index];

            }

        }
    }
}
