using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionary<TKey,TValue>
    {
        List<TKey> keys;
        List<TValue> values;

        public TValue this[TKey key]
        {
            get
            {
                return Get(key);
            }
            set
            {
                values[keys.IndexOf(key)] = value;
            }
        }
        public MyDictionary()
        {
            keys = new List<TKey>();
            values = new List<TValue>();
        }

        public TValue Get(TKey key)
        {
            if (keys.Contains(key))
            {
                return values[keys.IndexOf(key)];
            }
            throw new Exception("Anahtar Bulunumadı");
        }
        public void Add(TKey key, TValue value)
        {
            keys.Add(key);
            values.Add(value);
        }
        public void Remove(TKey key)
        {
            int index = keys.IndexOf(key);
            if(index != -1)
            {
                keys.RemoveAt(index);
                values.RemoveAt(index);
            }
        }
        public void Clear()
        {
            keys.Clear();
            values.Clear();
        }
        public bool ContainsKey(TKey key)
        {
            foreach (var item in keys)
            {
                if (item.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }

        public void PrintAll()
        {
            foreach (var item in keys)
            {
                Console.WriteLine("Key: "+item+"  /   Value :"+Get(item));
            }
        }
    }
}
