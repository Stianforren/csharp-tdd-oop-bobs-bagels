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
        public List<IProduct> ProductList { get; set; }

        public Basket(int basketSize)
        {
            _basketSize = basketSize;
        }


        public void Add(IProduct product)
        {

        }
    }
}
