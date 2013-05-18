using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataTrigrams
{
    public class Trigram
    {
        private IDictionary<String, Values> trigram = new Dictionary<String, Values>();

        public string GetKey(string key)
        {
            if (ContainsKey(key))
            {
                return key;       
            }

            throw new KeyNotFoundException(key);
        }      

        public Values GetValues(string key)
        {
            if (ContainsKey(key))
            {
                return trigram[key];
            }
            throw new KeyNotFoundException(key);
        }

        public void Pull(string key, string value)
        {
            if (!ContainsKey(key))
            {
                trigram.Add(key, new Values());
            }
            trigram[key].Add(value);
        }

        private bool ContainsKey(string key)
        {
            return trigram.ContainsKey(key);
        }
    }
}
