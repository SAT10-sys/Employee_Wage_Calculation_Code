using System;

namespace Employee_Wage_Calculation_Code
{
    class Program
    {

        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public const int EMP_RATE_PER_HR = 20;
        public const int NUM_WRKNG_DAYS = 2;
        public const int MAX_HRS = 10;
        public static int computeWage()
        {
            //variables
            int empHr = 0;
            int totalEmpHr = 0;
            int totalWrkDay = 0;
            while (totalEmpHr <= MAX_HRS && totalWrkDay < NUM_WRKNG_DAYS)
            {
                totalWrkDay++;
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
                totalEmpHr += empHr;
                Console.WriteLine(" Days: " + totalWrkDay + " Employee Hours: " + empHr);
            }
            int totEmpWage = totalEmpHr * EMP_RATE_PER_HR;
            Console.WriteLine(" Total Employee Wage is: " + totEmpWage);
            return totEmpWage;
        }
        static void Main(string[] args)
        {
            computeWage();
        }
    }

}
