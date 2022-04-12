using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string partipiciant = "Joanna";

            string[] participiants = new string[] { "Joanna", "Łukasz", "Michał", "Marcin" };

            string person = participiants[1];

            participiants[0] = "Asia";

            Console.WriteLine("Lista uczestników: ");

            for (int i = 0; i < participiants.Length; i++)
            {
                person = participiants[i];

                Console.WriteLine($"{i} - {person}");
            }

            int?[] happyNumbers = new int?[10];

            happyNumbers[0] = 10;
            happyNumbers[1] = 20;

            bool[,] board = new bool[8, 8];
            board[0, 1] = true;
            board[5, 2] = true;

        }
    }
}
