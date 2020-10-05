using System;

namespace Employee_Wage_Calculation_Code
{
    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        static void Main(string[] args)
        {
            // variables
            int empHr = 0;
            int EmpWage = 0;
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
            EmpWage = empHr * EMP_RATE_PER_HR;
            Console.WriteLine(" Employee Wage is: " + EmpWage);
        }
    }
}
