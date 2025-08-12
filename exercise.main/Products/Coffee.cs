using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Products
{
    public class Coffee : IProduct
    {
        private string _name;
        private float _price;
        private Type _type;

        public Coffee(string name, Inventory inventory)
        {
            _name = name;
            _price = inventory.inventory[name].Price;
            _type = inventory.inventory[name].Type;
        }
        public string SKU_NAME { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Price { get { return _price; } set { _price = value; } }

        public Type type { get { return _type; } }

        public float getTotalPrice()
        {
            return _price;
        }
    }
}
