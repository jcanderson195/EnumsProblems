using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsProblems
{
    class DaysOfWeek
    {

        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        enum Forcast
        {
            Foggy = 0,
            Sunny = 1,
            Rainy = 2,
            Cloudy = 4,
        }

        public void DisplayDaysForcast()
        {
            
            Console.WriteLine(Days.Sunday +": "+Forcast.Rainy);
            Console.WriteLine(Days.Monday + ": " + Forcast.Rainy);
            Console.WriteLine(Days.Tuesday + ": " + Forcast.Cloudy);
            Console.WriteLine(Days.Wednesday + ": " + Forcast.Cloudy);
            Console.WriteLine(Days.Thursday + ": " + Forcast.Sunny);
            Console.WriteLine(Days.Friday + ": " + Forcast.Cloudy);
            Console.WriteLine(Days.Saturday + ": " + Forcast.Foggy);
        }

        
    }
}
