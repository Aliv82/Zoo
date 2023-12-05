using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Enviroment
    {
        public HealthParameters<float> TDS { get; set; }
        public HealthParameters<float> Temp { get; set; }
        public HealthParameters<float> Density { get; set; }
        public HealthParameters<float> DB { get; set; }
        public HealthParameters<float> AQI { get; set; }
        public HealthParameters<float> OX { get; set; }

        public DateTime Date { get; set; }

        public override string ToString()
        {
            return "TDS : " + TDS.ToString() + " " + Temp.ToString() + " " + Density.ToString() + " " + DB.ToString() + " " + AQI.ToString() + " " + OX.ToString();
        }
    }
}
