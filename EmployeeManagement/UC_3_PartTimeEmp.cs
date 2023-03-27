
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class UC_3_PartTimeEmp
    {
        public static void GetAttendance()
        {
            int IS_FULL_TIME = 1;
            int IS_Part_Time = 2;

            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else if(empCheck== IS_Part_Time)
            {
                empHrs = 4;

            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage:" + empWage);
        }

    }
}
