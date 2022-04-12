using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainMadness
{
    class Section
    {
        public string name;

        public bool? occupancy;

        public Signal signal;

        public void Display()
        {
            if (occupancy.HasValue)
            {
                if (occupancy.Value)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
            }

            
            Console.WriteLine(new string(' ', 15));

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"   {name}   ");
            Console.ResetColor();

            if (signal!=null)
            {
                signal.Display();
            }
        }
    }


}
