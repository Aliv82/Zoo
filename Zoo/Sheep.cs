using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Zoo
{
    public class Sheep : Animal, IComparable, IEnumerable
    {
        public static int Number;

        List<Parameters> sheeplist = new List<Parameters>();

        public override string ToString()
        {
            return Number.ToString();
            foreach (Parameters sheep in sheeplist) 
            {
                return sheep.ToString();
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
