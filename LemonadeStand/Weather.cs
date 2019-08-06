using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //member variables
        public int temperature;
        Random random = new Random();
        public string[] conditions;
        public string condition;
        //construct

        //methods
        public int GenerateTemp()
        {
            temperature = random.Next(55, 95);
            return temperature;

        }
        public string GenerateConditions()
        {
            conditions = new string[5];
            conditions[0] = "Sunny";
            conditions[1] = "Overcast";
            conditions[2] = "Rainy";
            conditions[3] = "Partly Cloudy";
            conditions[4] = "Storming";
            int pickConditions = random.Next(conditions.Length);
            condition = conditions[pickConditions];
            return condition;
        }

    }
}
