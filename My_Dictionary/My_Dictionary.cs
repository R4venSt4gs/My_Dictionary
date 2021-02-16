using System;
using System.Collections.Generic;
using System.Text;

namespace My_Dictionary
{
    class My_Dictionary<xKey, xValue>
    {
        xKey[] keys;
        xValue[] values;

        public My_Dictionary()
        {
            keys = new xKey[0];
            values = new xValue[0];
        }

        public void Add(xKey key, xValue value)
        {
            xKey[] temp_Key = keys;
            xValue[] temp_Value = values;

            keys = new xKey[keys.Length + 1];
            values = new xValue[values.Length + 1];

            for (int i = 0; i < temp_Key.Length; i++)
            {
                keys[i] = temp_Key[i];
                values[i] = temp_Value[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + ":" + values[i]);
            }
        }

        public int Count()
        {
            return values.Length;
        }
    }
}
