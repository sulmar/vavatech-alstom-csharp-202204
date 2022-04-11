using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal baseSalary1 = 5000;
            byte overtime1 = 10;
            decimal amountPerHour1 = 100;

            // decimal salary1 = CalculateSalary(baseSalary1, overtime1, amountPerHour1);

            decimal salary1 = CalculateSalary(baseSalary1, 2);

            Display(baseSalary1, overtime1, amountPerHour1, salary1);

            decimal baseSalary2 = 7000;
            byte overtime2 = 5;
            decimal amountPerHour2 = 200;
            
            decimal salary2 = CalculateSalary(baseSalary2, overtime2, amountPerHour2, 2);

            Display(baseSalary2, overtime2, amountPerHour2, salary2);
        }


        // Metoda / funkcja
        static void Display(decimal baseSalary, byte overTime, decimal amountPerHour, decimal salary)
        {
            Console.WriteLine($"Base salary: {baseSalary}");
            Console.WriteLine($"Overtime: {overTime}");
            Console.WriteLine($"Amount Per Hour: {amountPerHour}");
            Console.WriteLine($"Salary: {salary}");
        }

        static decimal CalculateSalary(decimal baseSalary, byte overTime, decimal amountPerHour, byte numberOfChildren = 0)
        {
            decimal salary = baseSalary + overTime * amountPerHour + numberOfChildren * 500;

            return salary;
        }

        static decimal CalculateSalary(decimal baseSalary, byte numberOfChildren = 0)
        {
            decimal salary = baseSalary + numberOfChildren * 500;

            return salary;
        }

        static decimal CalculateSalary(decimal baseSalary, decimal bonus )
        {
            decimal salary = baseSalary + bonus;

            return salary;
        }
    }
}
