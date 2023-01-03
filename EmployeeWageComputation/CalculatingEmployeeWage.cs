using LanguageExt.TypeClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CalculatingEmployeeWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_PART_DATE = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public static void CalEmployeeWage()
        {
            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random= new Random();
            //Computation
            int empCheck = random.Next(0, 3);
            switch(empCheck) 
            {
                case 1:
                    empHrs = 4;
                break;

                case 2:
                    empHrs = 8;
                break;

                default:
                    empHrs = 0; 
                break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("EmpWage :"+empWage);

        }
    }
}
