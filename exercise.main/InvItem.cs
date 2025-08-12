using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class InvItem
    {
        private int _id;
        private float _price;
        private Type _type;

        public InvItem(int setId, float setPrice, Type type)
        {
            _price = setPrice;
            _id = setId;
            _type = type;
        }

        public int ID { get { return _id; } }
        public float Price { get { return _price; } }
        public Type Type { get { return _type; } }
        


    }
}
