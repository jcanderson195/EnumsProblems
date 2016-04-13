using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeek view = new DaysOfWeek();
            view.DisplayDaysForcast();
            Console.ReadKey();
            Console.WriteLine();
            HumaneSociety newTracker = new HumaneSociety();
            newTracker.DisplayTracker();
            Console.ReadKey();
        }
    }
}
