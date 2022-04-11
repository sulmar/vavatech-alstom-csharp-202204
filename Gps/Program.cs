using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gps
{
    class Program
    {
        static void Main(string[] args)
        {
            SendMessage("C#", "marcin.sulecki@gmail.com", "john.smith@domain.com", "Hello World!");
            SendMessage("C#", "marcin.sulecki@gmail.com", "ann.smith@domain.com", "Welcome!");
            SendMessage("C#", "marcin.sulecki@gmail.com", "bart.smith@domain.com", "Code with me!");            

            bool isLanscape = IsLanscape(50, 150);

            if (isLanscape)
            {
                Console.WriteLine("Landscape");
            }
            else
            {
                Console.WriteLine("Portrait");
            }


            // (lat, lng, alt)

            string gps1 = FormatGPS(52.0001, 28.0001, 0);
            Console.WriteLine(gps1);

            string gps2 = FormatGPS(51.0001, 27.000654, 10);
            Console.WriteLine(gps2);

            string gps3 = FormatGPS(-21.0001, 20.000654, 20);
            Console.WriteLine(gps3);

            string gps4 = FormatGPS(11.0001, 10.000654, 30);
            Console.WriteLine(gps4);
        }

        // F(x) = x * x, x nalezy do C

        // F(x, y) = x * y x i y nalezy do R

        static int Area(int x)
        {
            int area = x * x;

            return area;
        }

        static int Area(int x, int y)
        {
            int area = x * y;

            return area;
        }

        static int Capacity(int x, int y, int z)
        {
            int capacity = x * y * z;

            return capacity;
        }
        static string FormatGPS(double lat, double lng, double alt = 0)
        {
            if (alt == 0)
            {
                return $"[{lat},{lng}]";
            }
            else
            {
                return $"[{lat},{lng},{alt}]";
            }
        }


        // portrait, landscape

        static bool IsLanscape(int width, int height)
        {
            if (width > height)
            {
                return true;
            }
            else
            {
                return false;
            }

           // return width > height;
        }

        static void SendMessage(string title, string sender, string recipient, string content)
        {
            Console.WriteLine(title);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"from <{sender}> to {recipient}");
            Console.WriteLine(content);
        }
    }
}
