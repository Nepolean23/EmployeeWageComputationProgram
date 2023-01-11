using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class AbilityToManageEmployeeWageOfMultipleCompany
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numofcompany = 0;
        private CompanyEmpWage[] CompanyEmpWageArray;

        public AbilityToManageEmployeeWageOfMultipleCompany()
        {
            this.CompanyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string company,int empRatePerHour,int numofworkingdays,int maxHoursPerMonth)
        {
            CompanyEmpWageArray[this.numofcompany]=new CompanyEmpWage(company,empRatePerHour,numofworkingdays,maxHoursPerMonth);
            numofcompany++;
        }

        public void ComputeEmpWage()
        {
            for(int i=0;i<numofcompany;i++) 
            {
                CompanyEmpWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.CompanyEmpWageArray[i]));
                Console.WriteLine(this.CompanyEmpWageArray[i].tostring());
            }
        }

        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            //varaibles
            int empHrs = 0, totalEmpHrs = 0,totalWorkingDays = 0;

            //computation

            while(totalEmpHrs<=companyEmpWage.maxHoursPerMonth && totalWorkingDays<companyEmpWage.numofworkingDays)
            {
                totalWorkingDays++;
                Random random=new Random();
                int empCheck = random.Next(0, 3);
                switch(empCheck) 
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

                    case IS_FULL_TIME:
                        empHrs = 5;
                        break;

                    default: 
                        empHrs = 0; 
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#:" + totalWorkingDays + "Emp Hrs: " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
        
    }

    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int maxHoursPerMonth;
        public int numofworkingDays;
        public int totalEmpWage;

        public CompanyEmpWage(string company,int empRatePerHour,int numofworkingDays, int maxHoursPerMonth) 
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.numofworkingDays=numofworkingDays;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage=totalEmpWage;
        }

        public string tostring()
        {
            return "Total Emp Wage for Company :" + this.company + " is:" + this.totalEmpWage;
        }
    }
}
