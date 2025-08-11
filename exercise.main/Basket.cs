using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Basket
    {

        private int _basketSize;
        public List<IProduct> ProductList = new List<IProduct>();

        public Basket(int basketSize)
        {
            _basketSize = basketSize;
        }

        public void Add(IProduct product)
        {
            ProductList.Add(product);
        }

        public void Remove(int id)
        {
            ProductList.RemoveAt(id);
        }

        public bool IsFull()
        {
            return ProductList.Count < _basketSize ? false : true;
        }
    }
}
