using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCalculation
{
    internal class Employee
    {
        int isPrasent = 1;
        Random random = new Random();
        int emphrs = 0, Wageperhts = 20;
        public void Attendence()
        {

            int result = random.Next(0, 2);
            if (result == isPrasent)
            {
                Console.WriteLine("employee is present");
                emphrs += 8;
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
        public int DailyWage()
        {
            return emphrs * Wageperhts;
        }
    }
}
