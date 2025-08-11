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
        private Inventory inventory = new Inventory();

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

        public int BasketSize { get { return _basketSize; } set { _basketSize = value; } }

        public bool ItemInBasket(int sku_id)
        {
            return ProductList.Any(x => x.SKU_ID == sku_id);
        }
    }
}
