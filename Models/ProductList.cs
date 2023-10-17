using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace task13.Models
{
    internal class ProductList
    {
        
        Product[] _products = new Product[0];
       
        public int Length { get { return _products.Length; } }
        public Product this[int index]
        {
            get
            {
                return _products[index];

            }
        }
        public void Add(Product product)
        {
            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length - 1] = product;
        }
        public void Remove(int id)
        {
            foreach (Product product in _products)
            {
                if (product.ID == id)
                {
                   
                }
            }
        }
    }
}
