using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{

    public class Bagel : IProduct
    {
        private int _SKU_ID;
        public int SKU_ID { get { return _SKU_ID; } set { _SKU_ID = value; } }

        public Bagel(string name)
        {
            
        }
    }
}
