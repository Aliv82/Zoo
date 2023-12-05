using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Parameters
    {
        public HealthParameters<int> TimeToStand {  get; set; }
        public HealthParameters<int> TimeToDeal {  get; set; }
        public HealthParameters<int> TimeToRelax {  get; set; }
        public HealthParameters<int> NumberOFMeal {  get; set; }
        public HealthParameters<int> NumberOFMilkProduction {  get; set; }
        public DateTime Date {  get; set; }
        public override string ToString()
        {
            return "TimeToStand : " + TimeToStand.ToString() + " " + "TimeToDeal : " + TimeToDeal.ToString() + " " + "TimeToRelax : " + TimeToRelax.ToString() + " " + "NumberOFMeal : " + NumberOFMeal.ToString() + " " + "NumberOFMilkProduction : " + NumberOFMilkProduction.ToString() + " ";
        }
    }
    
}
