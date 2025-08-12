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

        public float getTotalCostForBagels()
        {
            return ProductList.OfType<Bagel>().Sum(x => x.Price);
        }

        public float getTotalCost()
        {
            return ProductList.Sum(x => x.getTotalPrice());
        }

        public float getTotalPriceForAllFillings()
        {
            return (float)Math.Round(ProductList.OfType<Bagel>().Sum(x => x.costForFillings()), 2);
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
            itemCount = ProductList.GroupBy(x => x).ToDictionary(g => g.Key.SKU_NAME, g => g.Count());

            return itemCount;
        }

        public float caluculateDiscount()
        {
            Dictionary<string, int> itemCount = getItemCount();
            float discountPice = 0;
            if (checkIfBundleDealAvaiable(itemCount))
            {
                foreach (var item in itemCount)
                {
                    if (item.Value >= 6 && _inventory.inventory[item.Key].Type == Type.Bagel)
                    {
                        discountPice += getPriceForItemWithBundleDiscount(item.Key, item.Value);
                    }
                }
            }
            return discountPice;
        }

        public bool checkIfBundleDealAvaiable(Dictionary<string, int> dict)
        {
            foreach (var item in dict)
            {
                if (item.Value >= 6 && _inventory.inventory[item.Key].Type == Type.Bagel)
                {
                    return true;
                }
            }
            return false;
        }

        public bool checkIfCoffeeDealAvailable(Dictionary<string, int> dict)
        {
            return (ProductList.Any(x => _inventory.inventory[x.SKU_NAME].Type == Type.Bagel)
                && ProductList.Any(y => _inventory.inventory[y.SKU_NAME].Type == Type.Coffee));
        }

        public float getPriceForItemWithBundleDiscount(string bagel, int amount)
        {
            int twelveBundle = 0;
            int sixBundle = 0;
            int singles = 0;

            if (amount >= 12)
            {
                twelveBundle = amount/12;
                singles = amount%12;
                if (singles > 6)
                {
                    sixBundle = singles/6;
                    singles = singles%6;
                }
            }
            else if (amount > 6)
            {
                sixBundle = singles / 6;
                singles = singles % 6;

            }
            return twelveBundle * 3.99f + sixBundle * 2.49f + singles * _inventory.inventory[bagel].Price;
        }

    }
}
