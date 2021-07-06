using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage
{
    class UC5CalWageForMonth
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int NO_OF_WORKING_DAYS = 3;

        public static void calWageForMonth()
        {
            int empHrs = 0, empWage = 0, totalEmpWage = 0;

            for (int day = 0; day < NO_OF_WORKING_DAYS; day++)
            {


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

                empWage = empHrs * EMP_RATE_PER_HR;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage : " + empWage);
            }
            Console.WriteLine("Total Emp wage : " + totalEmpWage);
        }
    }
}
