using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Inventory
    {
        public Dictionary<string, int> toSkuId = new Dictionary<string, int>();


        public Inventory()
        {
            toSkuId.Add("BGLO", 0);
            toSkuId.Add("BGLP", 1);
            toSkuId.Add("BGLE", 2);
            toSkuId.Add("BGLS", 3);
        }


    }
}
