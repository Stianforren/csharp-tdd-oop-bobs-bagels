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
        private int _id;
        public int Id { get { return _id; } set { _id = value; } }
    }
}
