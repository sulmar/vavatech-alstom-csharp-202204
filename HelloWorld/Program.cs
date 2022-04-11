using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            // Komentarz linii

            // 1. Podstawy

            /* Komentarz blokowy
            
            Console.WriteLine("Hello World!");

            Console.WriteLine("What's your name?");

            Console.WriteLine(Console.ReadLine()); // odczytuje i wyświetla wartość z konsoli

            */

            // 2. Zmienne

            string name; // deklaracja zmiennej name typu string (typ tekstowy)

            name = "Marcin"; // przypisanie wartości

            Console.WriteLine(name);

            name = "Joasia";

            Console.WriteLine(name);

            name = "100";

            Console.WriteLine(name);

            byte experience = 25; // byte 0..255 (1 bajt)

            Console.WriteLine(experience);

            string firstName = "Marcin"; // Camel-Case

            // 3. Stałe (constant)
            const int MaxSpeed = 140;   // Pascal-Case
            const double Tax = 0.23;
            const double MinimalTemperatureInC = -273;


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();


        }
    }    
}
