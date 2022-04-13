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


            // Zmienna typu tablicowego - 1-wymiarowa
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

            // Zmienna typu tablicowego - 2-wymiarowa
            bool[,] board = new bool[8, 8];
            board[0, 1] = true;
            board[5, 2] = true;

            // Zmienna typu tablicowego - 3-wymiarowa
            string[,,] cube = new string[4, 4, 4];
            cube[0, 0, 0] = "green";
            cube[0, 0, 3] = "blue";
            cube[2, 1, 0] = "red";
            cube[1, 3, 2] = "green";
            cube[2, 3, 0] = "red";
            cube[2, 2, 2] = "blue";

            int maxX = cube.GetUpperBound(0);
            int maxY = cube.GetUpperBound(1);
            int maxZ = cube.GetUpperBound(2);

            for (int x = 0; x <= maxX ; x++)
            {
                for (int y = 0; y <= maxY; y++)
                {
                    for (int z = 0; z <= maxZ; z++)
                    {
                        string color = cube[x, y, z];
                        Console.WriteLine($"{x},{y},{z} = {color}");
                    }
                }
            }

        }
    }
}
