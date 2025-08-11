using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Products
{
    public class Filling : IProduct
    {
        private string _name;
        private float _cost;

        public Filling(string name)
        {
            _name = name;
        }
        public int SKU_ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SKU_NAME { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
