using System;

namespace Employee_Wage_Calculation_Code
{
    class Program
    {
        // constants
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public const int EMP_RATE_PER_HR = 20;
        public const int NUM_WRKNG_DAYS = 2;
        static void Main(string[] args)
        {
            // variables
            int empHr = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            for (int day = 0; day < NUM_WRKNG_DAYS; day++)
            {
                Random random = new Random();
                int empChk = random.Next(0, 3);
                switch (empChk)
                {
                    case IS_PART_TIME:
                        empHr = 4;
                        break;
                    case IS_FULL_TIME:
                        empHr = 8;
                        break;
                    default:
                        empHr = 0;
                        break;
                }
                empWage = empHr * EMP_RATE_PER_HR;
                totalEmpWage += empWage;
                Console.WriteLine(" Employee Wage is: " + empWage);
            }
            Console.WriteLine(" Total Employee Wage: " + totalEmpWage);
        }
    }
}
