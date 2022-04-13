using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            // # Wyrażenia warunkowe

            // ## 1. if else

            int hour = 19;

            if (hour >= 6 && hour < 12)    // && - AND (iloczyn logiczny)
            {
                Console.WriteLine("Good morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Good afternoon");
            }
            else
            {
                Console.WriteLine("Good evenining");
            }


            string color = "red";

            if (color == "red" || color == "yellow") // || - OR (suma logiczna)
            {
                Console.WriteLine("Track occupate");
            }
            else
            {
                Console.WriteLine("Track free");
            }

            bool isOccupate = true;

            if (!isOccupate) // ! - NOT (negacja logiczna)
            {

            }


            if (color != "red")  // nie jest równe
            {

            }

            // ## 2. switch case

            string role = "Guest";

            /* 
             
            if (role == "guest")
            {
                Console.WriteLine("Guest User");
            }
            else if (role == "modetator")
            {
                Console.WriteLine("User Moderator");
            }
            else
            {
                Console.WriteLine("Unknow User");
            }
            */

            switch (role)
            {
                case "guest": Console.WriteLine("Guest User"); break;
                case "modetator": Console.WriteLine("User Moderator"); break;
                default: Console.WriteLine("Unknow User"); break;
            }

            switch (color)
            {
                case "red":
                case "yellow":
                    isOccupate = true; break;

                case "green":
                    isOccupate = false; break;

                default:
                    isOccupate = true; break;

            }


            // # Pętle


            // ## Pętla for - określona ilość przejść

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{i} Hello World!");
            }

            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine($"{i} Hello World!");
            }

            Console.WriteLine("Liczby parzyste: ");
            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }

            // ## Pętla while

            bool isConnected = true;

            int connection = 0;

            while (isConnected)
            {
                Console.WriteLine("Connected.");

                connection++;

                if (connection > 10)
                {
                    isConnected = false;
                }
            }

            // # Pętla do-while

            isConnected = false;

            byte tryNumber = 1;

            do
            {
                Console.WriteLine($"Connecting... try {tryNumber}");

                tryNumber++;

                if (tryNumber>10)
                {
                    isConnected = true;
                }
            }
            while (!isConnected);
           






        }
    }
}
