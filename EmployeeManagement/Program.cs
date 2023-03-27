namespace EmployeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            //EmployeeAttendance.GetAttendance();
            //EmpWage.GetAttendance();
            //PartTimeEmp.GetAttendance();
            //SwitchCase.GetAttendance();
            //CalWagesForMonth.GetAttendance();
            //WorkingHrs100orMaxDays20.CalculatedWage();
            //computeEmpWage.CalculatedWage();
            //UC-8
            //EmpWageForMultipleCompany.computeEmpWage("Dmart", 20, 20, 50);
            //EmpWageForMultipleCompany.computeEmpWage("Reliance", 10, 21, 100);
            //UC-9
            UC_9_TotalWageForEachCompany dMart = new UC_9_TotalWageForEachCompany("DMart", 20, 20, 50);
            UC_9_TotalWageForEachCompany reliance = new UC_9_TotalWageForEachCompany("Reliance", 10, 21, 100);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}