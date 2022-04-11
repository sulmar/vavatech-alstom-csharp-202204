using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // # Typ logiczny (prawda-fałsz) 1-bit
            bool isSent = true;
            bool hasSalary = true;
            bool canPrint = false;

            // # Typy liczbowe

            // ## Liczy całkowite

            byte speed = 140; // 0..255  8-bit (1 bajt)
            Console.WriteLine($"byte: {byte.MinValue}...{byte.MaxValue}");

            sbyte temperature = -20;
            Console.WriteLine($"sbyte: {sbyte.MinValue}...{sbyte.MaxValue}");

            short altitude = -9000; // 16-bit (2 bajt)
            Console.WriteLine($"short: {short.MinValue}...{short.MaxValue}");
            
            ushort numberOfVisists = 10000; // 16-bit (2 bajt)
            Console.WriteLine($"ushort: {ushort.MinValue}...{ushort.MaxValue}");

            int customerId = -180000; // 32-bit (4 bajt)
            Console.WriteLine($"int: {int.MinValue}...{int.MaxValue}");

            uint productId = 180000; // 32-bit (4 bajt)
            Console.WriteLine($"uint: {uint.MinValue}...{uint.MaxValue}");

            long sensorId = 1000000; // 64-bit (8 bajt)
            Console.WriteLine($"long: {long.MinValue}...{long.MaxValue}");

            ulong measureId = 1000000; // 64-bit (8 bajt)
            Console.WriteLine($"ulong: {ulong.MinValue}...{ulong.MaxValue}");


            // # Liczby rzeczywiste
            float roomTemperature = 21.05f; // 16-bitowa liczba zmiennoprzecinkowa
            Console.WriteLine($"float: {float.MinValue}...{float.MaxValue}");

            double latitude = 10.000001; // 32-bitowa liczba zmiennoprzecinkowa
            Console.WriteLine($"double: {double.MinValue}...{double.MaxValue}");

            decimal unitPrice = 4.99m; // 64-bitowa liczba zmiennoprzecinkowa
            Console.WriteLine($"decimal: {decimal.MinValue}...{decimal.MaxValue}");

            // # Tekst
            string name = "John";

            // # Znak
            char sign = 'A';

            char initial = name[0];


            // # Data
            DateTime currentDate = DateTime.Now;


            // # Czas
            TimeSpan beginHour = new TimeSpan(9, 0, 0);


        }
    }
}
