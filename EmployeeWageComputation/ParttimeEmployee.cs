using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class ParttimeEmployee
    {
        public static void Parttime()
        {
            //Constants
            int IS_FULL_TIME = 1;
            int IS_PARTTIME = 2;
            int EMP_WAGE_PER_HOUR = 8;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random= new Random();
            //Computation
            int empCheck=random.Next(0,3);
            if(empCheck==IS_PARTTIME)
            {
                empHrs = 4;
            }
            else if(empCheck==IS_FULL_TIME) 
            {
                empHrs = 8;
            }
            else
            {
                empHrs= 0;
            }
            empWage = empHrs * EMP_WAGE_PER_HOUR;
            Console.WriteLine("EmpWage :"+empWage);

        }

    }
}
