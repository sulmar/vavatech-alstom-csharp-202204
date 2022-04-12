using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participiants = new List<string>();
            participiants.Add("Joanna");
            participiants.Add("Łukasz");
            participiants.Add("Michał");
            participiants.Add("Marcin");

            // snippet: for + 2 x TAB
            for (int i = 0; i < participiants.Count; i++)
            {
                string person = participiants[i];

                // snippet: cw + 2 x TAB
                Console.WriteLine(person);
            }
        }
    }
}
