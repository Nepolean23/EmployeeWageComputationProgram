using EmployeeWageComputation;
//Employee Attendance
//EmployeeAttendance.Attendance();

//Employee Wage Calculation
//EmployeeWageCalculation.EmployeeWage();

//Parttime Employee Wage Calculation
//ParttimeEmployee.Parttime();

//Calculating Employee Wage Using SwitchCase
//CalculatingEmployeeWage.CalEmployeeWage();

//Calculating Employee Wage For 20 Days
//CalculatingWagesForAMonth.WagePerMonth();

//Calculating Employee Wage For Max 100hrs and 20days
//CalculatingWagesOnHrsAndDays.WagesOnHrsAndDays();

//Final solution for EmployeeWage Program
EmpWageBuilder empWageBuilder = new EmpWageBuilder();
empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
empWageBuilder.computeEmpWage();
Console.WriteLine("Total Wage for Dmart company: " + empWageBuilder.getTotalWage("Dmart"));










