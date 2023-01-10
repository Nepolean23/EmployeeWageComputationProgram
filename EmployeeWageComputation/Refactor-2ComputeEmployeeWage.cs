using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class Refactor_2ComputeEmployeeWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static int ComputeEmpWage(string Company, int empRatePerHour,int numofWorkingDays, int maxHourPerMonth)
        {
            //Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            //Computation
            while (totalEmpHrs <= maxHourPerMonth&& totalWorkingDays < numofWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empChk = random.Next(0, 3);

                switch (empChk)
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
                totalEmpHrs+= empHrs;
                Console.WriteLine("Days# :"+totalWorkingDays+"Emp Hrs :"+empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for Company :"+Company +" is "+ totalEmpWage);
            return totalEmpWage;
        }

        public static void Main(string[] args)
        {
            ComputeEmpWage("Dmart", 20, 2, 10);
            ComputeEmpWage("Reliance", 10, 4, 20);

        }
    }

}
