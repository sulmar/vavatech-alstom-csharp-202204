using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DermitPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Podaj prędkość [km/h]: ");
                byte speed = byte.Parse(Console.ReadLine());

                CheckSpeed(speed);
            }
        }

        static void CheckSpeed(byte speed)
        {
            const byte SpeedLimit = 70; // km/h
            const byte PenaltyPointPerSpeed = 5;
            const byte LicenceDriverPenaltyPointLimit = 12;

            if (speed > SpeedLimit)
            {
                int overSpeed = speed - SpeedLimit;

                double penaltyPoints = (double)overSpeed / (double)PenaltyPointPerSpeed;

                penaltyPoints = Math.Ceiling(penaltyPoints); // zaokrąglenie w górę

                Console.WriteLine($"Ilość punktów karnych: {penaltyPoints} ");

                if (penaltyPoints > LicenceDriverPenaltyPointLimit)
                {
                    Console.WriteLine("Zabieramy prawo jazdy.");
                }
            }
            else
            {
                Console.WriteLine("OK");
            }
        }
    }
}
