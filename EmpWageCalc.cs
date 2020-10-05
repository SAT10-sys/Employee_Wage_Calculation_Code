using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Calculation_Code
{
    class EmpWageCalc
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;
        public EmpWageCalc(string company, int empRateperHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRateperHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void computeWage()
        {
            int empHr = 0, totEmpHrs = 0, totWorkingDays = 0;
            while (totEmpHrs <= this.maxHoursPerMonth && totWorkingDays < this.numOfWorkingDays)
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
            int totEmpWage = totEmpHrs * this.empRatePerHour;
            Console.WriteLine(" Total Employee Wage for company: " + company + " is: " + totEmpWage);
        }
        public string toString()
        {
            return "Total Employee Wage For Company: " + company + " is: " + totalEmpWage;
        }
    }
}
