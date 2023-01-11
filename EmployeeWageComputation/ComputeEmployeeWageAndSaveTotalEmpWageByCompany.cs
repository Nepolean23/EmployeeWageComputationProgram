using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class ComputeEmployeeWageAndSaveTotalEmpWageByCompany
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        

        public ComputeEmployeeWageAndSaveTotalEmpWageByCompany(string company,int empRatePerHour,int numOfWorkingDays,int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth=maxHoursPerMonth;

        }

        public void ComputeEmployeeWage()
        {
            //variables
            int empHrs=0, totalEmpHrs = 0, totalWorkingDays = 0;

            //computation

            while(totalEmpHrs<=this.maxHoursPerMonth&& totalWorkingDays < this.numOfWorkingDays)
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#"+totalWorkingDays+"is"+"Emp Hrs :"+empHrs);

            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total EmpWage For Company :"+company+" is:"+totalEmpWage);


            
        }
        public String ToString()
        {
            return "Total EmpWage For Company :" + company + " is:" + totalEmpWage;
        }

        class Program
        {
            static void Main(string[] args)
            {
                ComputeEmployeeWageAndSaveTotalEmpWageByCompany dmart = new ComputeEmployeeWageAndSaveTotalEmpWageByCompany("DMart", 20, 2, 10);
                ComputeEmployeeWageAndSaveTotalEmpWageByCompany reliance = new ComputeEmployeeWageAndSaveTotalEmpWageByCompany("RELIANCE", 20, 2, 10);
                dmart.ComputeEmployeeWage();
                Console.WriteLine(dmart.ToString());
                reliance.ComputeEmployeeWage();
                Console.WriteLine(reliance.ToString());
            }

        }
        


        
    }
}
