using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CalculatingWagesOnHrsAndDays
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int TOTAL_WORKING_HOURS = 100;
        public static void WagesOnHrsAndDays()
        {
            //variables
            int empHrs = 0; int empWage = 0; int totalWorkingDays = 0; int totalEmpHrs = 0;
            //Computation
            while(totalEmpHrs<EMP_RATE_PER_HOUR && totalWorkingDays<NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random= new Random();
                int empCheck=random.Next(0,3);
                switch(empCheck) 
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHrs+=empHrs;
                Console.WriteLine("Days#:"+totalWorkingDays+ "EmpHrs :"+empHrs);

            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("totalEmpWage :" + totalEmpWage);
           

        }
    }
}
