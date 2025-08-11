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
        private int _SKU_ID;
        private string _NAME;
        private List<Filling> fillings;
        private float _cost;

        public Bagel(string name, Inventory inventory)
        {
            _NAME = name;
            fillings = new List<Filling>();
            _cost = inventory.inventory[name].Price;
        }
        public int SKU_ID { get { return _SKU_ID; } set { _SKU_ID = value; } }
        public string SKU_NAME { get { return _NAME; } set { _NAME = value; } }
        public float Price { get { return _cost; } set { _cost = value; } }
        public List<Filling> Fillings { get { return fillings; } }

        public void addFilling(Filling filling)
        {
            fillings.Add(filling);
        }
    }
}
