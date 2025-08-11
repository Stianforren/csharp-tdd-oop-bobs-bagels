using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public interface IProduct
    {
        int SKU_ID { get; set; }
        string SKU_NAME { get; set; }

        float Price { get; set; }
    }
}
