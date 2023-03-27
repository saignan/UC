using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class UC_5_CalWagesForMonth
    {
        public static void GetAttendance()
        {
            const int IS_FULL_TIME = 1;
            const int IS_Part_Time = 2;
            const int TotalWorkingDays = 20;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            for (int i = 1; i <= TotalWorkingDays; i++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_Part_Time:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage :"+empWage);
            }

            Console.WriteLine("Total Emp Wage:" +totalEmpWage);
        }

    }
}
