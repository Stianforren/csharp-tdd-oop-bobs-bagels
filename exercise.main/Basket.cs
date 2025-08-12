using exercise.main.Products;
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
        private Inventory _inventory;

        public Basket(int basketSize, Inventory inventory)
        {
            _inventory = inventory;
            _basketSize = basketSize;
        }

        public void Add(IProduct product)
        {
            if (!IsFull())
            {
                ProductList.Add(product);
            }
        }

        public void Remove(int placeInList)
        {
            ProductList.RemoveAt(placeInList);
        }

        public bool IsFull()
        {
            return ProductList.Count < _basketSize ? false : true;
        }

        public int BasketSize { get { return _basketSize; } set { _basketSize = value; } }

        public bool ItemInBasket(string type)
        {
            return ProductList.Any(x => x.SKU_NAME == type);
        }

        public float getBagelCost(string bagelSKU)
        {
            return _inventory.inventory[bagelSKU].Price;
        }

        public float getTotalCost()
        {
            return ProductList.Sum(x => x.getTotalPrice());
        }

        public float getTotalPriceForAllFillings()
        {
            return (float)Math.Round(ProductList.OfType<Bagel>().Sum(x => x.costForFillings()),2);
        }

        public float getFillingCost(string fillingSKU)
        {
            return _inventory.getFillingCost(fillingSKU);
        }

        public bool inInventory(string item)
        {
            return _inventory.inInventory(item);
        }
        
        public Dictionary<string, int> getItemCount()
        {
            Dictionary<string, int> itemCount = new Dictionary<string, int>();
            itemCount = ProductList.GroupBy(x => x).ToDictionary(g => g.Key.SKU_NAME, g =>  g.Count());

            return itemCount;
        }
    }
}
