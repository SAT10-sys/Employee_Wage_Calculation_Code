using System;

namespace Employee_Wage_Calculation_Code
{
    class Program
    {
        // constants
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public static int computeWage(string company, int empRatePerHour, int numWorkingDay, int maxHrsPerMonth)
        {
            int empHr = 0, totEmpHrs = 0, totWorkingDays = 0;
            while (totEmpHrs <= maxHrsPerMonth && totWorkingDays < numWorkingDay)
            {
                totWorkingDays++;
                Random random = new Random(0);
                int empChk = random.Next(0, 2);
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
                totEmpHrs += empHr;
                Console.WriteLine(" Days: " + totWorkingDays + " Employee Hours: " + empHr);
            }
            int totEmpWage = totEmpHrs * empRatePerHour;
            Console.WriteLine(" Total Employee Wage for company: " + company + " is: " + totEmpWage);
            return totEmpWage;
        }
        static void Main(string[] args)
        {
            computeWage("Mart", 20, 2, 10);
            computeWage("Reliance", 10, 4, 20);
        }
    }

}
