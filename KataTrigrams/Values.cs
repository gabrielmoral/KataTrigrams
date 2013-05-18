using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataTrigrams
{
    public class Values
    {
        IList<String> values = new List<String>();

        public bool Contains(string value)
        {
            return values.Contains(value);
        }

        public void Add(string value)
        {
            values.Add(value);
        }
    }
}
