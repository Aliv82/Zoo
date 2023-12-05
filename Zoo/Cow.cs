using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Zoo;

namespace Zoo
{
    public class Cow : Animal, IComparable, IEnumerable
    {
        public static int Number {  get; set; }
        List<Parameters> cowlist { get; set; } 

        public override string ToString()
        {
           return Number.ToString();
            foreach (Parameters cow in cowlist)
            {
                return cow.ToString();
            }
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
