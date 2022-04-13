using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fans
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan fan = new Fan("Vesta");
            fan.PushButton2();
            fan.PushButton0();

            fan.PushOscillationButton();
        }
    }
}
