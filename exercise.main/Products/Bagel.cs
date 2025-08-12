using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Products
{

    public class Bagel : IProduct
    {
        private string _NAME;
        private List<Filling> fillings;
        private float _cost;
        private Type _type;

        public Bagel(string name, Inventory inventory)
        {
            _NAME = name;
            fillings = new List<Filling>();
            _cost = inventory.inventory[name].Price;
            _type = inventory.inventory[name].Type;
        }
        public string SKU_NAME { get { return _NAME; } set { _NAME = value; } }
        public float Price { get { return _cost; } set { _cost = value; } }
        public List<Filling> Fillings { get { return fillings; } }

        public Type type { get { return _type; } }

        public void addFilling(Filling filling)
        {
            fillings.Add(filling);
        }
        public float costForFillings()
        {
            return fillings.Sum(x => x.Price);
        }
        public float getTotalPrice()
        {
            return costForFillings() + _cost;
        }
    }
}
