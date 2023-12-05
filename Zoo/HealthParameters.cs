using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class HealthParameters<T>
    {
        public string Name {  get; set; }
        public T Current { get; set; }
        public T Standard { get; set; }

        public float StressFactor(float stressfactor)
        {
            return stressfactor;
        }
        public override string ToString()
        {
            return "Name :" + Name;
        }

    }
}
