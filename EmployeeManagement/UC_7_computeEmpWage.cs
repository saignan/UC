﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class UC_7_computeEmpWage
    {
        public static int CalculatedWage()
        {
            const int IS_FULL_TIME = 1;
            const int IS_Part_Time = 2;
            const int TotalWorkingDays = 20;
            const int EMP_RATE_PER_HOUR = 20;
            const int MaxHours = 100;
            int empHrs = 0;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= MaxHours && totalWorkingDays < TotalWorkingDays)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day : " + (totalWorkingDays) + ",Emp Working Hrs :" + empHrs);
            }
            totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage:" + totalEmpWage);
            return totalEmpWage;
        }

    }
}