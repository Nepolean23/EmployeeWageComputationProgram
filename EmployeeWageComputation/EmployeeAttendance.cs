using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeAttendance
    {
        public static void Attendance()
        {
            //Constants
            int Is_Full_Time = 1;
            Random random = new Random();
            //Computation
            int empcheck = random.Next(0, 2);
            if (empcheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is present");

            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
