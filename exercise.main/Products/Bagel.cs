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

        public Bagel(string name)
        {
            _NAME = name;
        }
        public int SKU_ID { get { return _SKU_ID; } set { _SKU_ID = value; } }
        public string SKU_NAME { get { return _NAME; } set { _NAME = value; } }

        public float cost { get => throw new NotImplementedException();}
    }
}
