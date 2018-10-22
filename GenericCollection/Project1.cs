using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    public struct Project1<T>
    {
        public readonly string Key;
        public readonly T Value;

        public Project1(string key, T value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
