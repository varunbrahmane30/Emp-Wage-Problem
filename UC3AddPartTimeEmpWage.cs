using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage
{
    class UC3AddPartTimeEmpWage
    {
        public static void addPartTimeEmpWage()
        {
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HR = 20;

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();

            int empCheck = random.Next(0, 3);
            //Console.WriteLine(empCheck);

            if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
