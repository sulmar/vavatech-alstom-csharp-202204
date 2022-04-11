using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Debuger 
            // Pułapka (breakpoint) F9 + F5

            const decimal BonusPerYear = 1000;

            Console.WriteLine("Podaj imię: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Wpisz ile masz lat doświadczenia: ");
            string experienceString = Console.ReadLine();

            byte experience = byte.Parse(experienceString); // Konwersja tekstu na liczbę

            decimal salary = experience * BonusPerYear;

            if (experience > 10)
            {
                // salary = salary * 2;
                salary *= 2;
            }
            else
            {
                // salary = salary - 500;
                salary -= 500;
            }

            // Konkatenacja (łączenie)
            // string message = "Witaj " + firstName + " " + lastName + "! Otrzymujesz premię w wysokości: " + salary;

            // Formatowanie tekstu
            // string message = string.Format("Witaj {0} {1}! Otrzymujesz premię w wysokości: {2}", firstName, lastName, salary);

            // Interpolacja 
            string message = $"Witaj {firstName} {lastName}! Otrzymujesz premię w wysokości: {salary}";


            Console.WriteLine(message);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
