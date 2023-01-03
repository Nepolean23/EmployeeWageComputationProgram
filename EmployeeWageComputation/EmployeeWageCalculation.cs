using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWageCalculation
    {
        public static void EmployeeWage()
        {
            //Constants
            int IS_FULL_TIME = 1;
            int EMP_PER_HOUR = 20;
            //Variables
            int empHrs = 8;
            int empWage = 0;
            //Computation
            Random random=new Random();
            int empCheck=random.Next(0,2);
            if(empCheck==1)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            
             empWage=empHrs*EMP_PER_HOUR;
            Console.WriteLine("Emp Wage :"+empWage);

        }
    }
}
