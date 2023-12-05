using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Animal
    {
        // Attribute
        public DateTime BirthDate { get; init; }
        public static readonly int Maxlife;
        public List<Enviroment> enviroment;
        public float Weight;
        public bool Gender;
        public string Name;

        //Method

        public float stressFactor(float streesfactor)
        {
            return streesfactor;
        }
        public int Life(int life) 
        {
            return life;
        }
        public int TimeToDie(int timetodie) 
        {
            return timetodie;
        }
        public float KillPriority(int killpriority)
        {
            return killpriority;
        }
        public int CostPerDay(int costperday) 
        {
            return costperday;
        }
        public int ValuePerDay(int valueperday)
        {
            return valueperday;
        }

    }
}
