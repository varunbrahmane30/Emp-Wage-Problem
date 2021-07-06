﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage
{
    class UC6CalWageTillCondition
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int NO_OF_WORKING_DAYS = 3;
        public const int MAX_HRS_IN_A_MONTH = 10;

        public static void calWageTillConditionReached()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= MAX_HRS_IN_A_MONTH && totalWorkingDays < NO_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();

                int empCheck = random.Next(0, 3);

                switch (empCheck)
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
                Console.WriteLine("Days#: " + totalWorkingDays + "Emp Hrs :  " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Total Emp wage : " + totalEmpWage);
        }
    }
}
