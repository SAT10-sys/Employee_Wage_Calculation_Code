using System;

namespace Employee_Wage_Calculation_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageCalc mart = new EmpWageCalc("Mart", 10, 2, 20);
            EmpWageCalc reliance = new EmpWageCalc("Reliance", 10, 4, 20);
            mart.computeWage();
            Console.WriteLine(mart.toString());
            reliance.computeWage();
            Console.WriteLine(reliance.toString());
        }
            
    }

}
