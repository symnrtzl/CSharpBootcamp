using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Dictionary<Tkey, Tvalue>
    {
        Tkey[] keys;
        Tvalue[] values;
        public Dictionary()
        {
            keys = new Tkey[0];
            values = new Tvalue[0];
        }

        public void Add(Tkey key, Tvalue value)
        {
            Tkey[] tempKeys = keys;
            Tvalue[] tempValues = values;

            keys = new Tkey[tempKeys.Length + 1];
            values = new Tvalue[tempValues.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            keys[keys.Length - 1] = key;

            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }
            values[keys.Length - 1] = value;
        }


        public int ValuesLength
        {
            get { return values.Length; }
        }
        public int KeysLength
        {
            get { return values.Length; }
        }

        public Tkey[] Keys
        {
            get { return keys; }
        }

        public Tvalue[] Values
        {
            get { return values; }
        }

        
    }
}
