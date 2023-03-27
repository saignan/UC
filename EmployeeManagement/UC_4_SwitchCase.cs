using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class UC_4_SwitchCase
    {
        public static void GetAttendance()
        {
            const int IS_FULL_TIME = 1;
            const int IS_Part_Time = 2;
            const int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch(empCheck)
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
            Console.WriteLine("Emp Wage:" + empWage);
        }

    }
}
