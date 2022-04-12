using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainMadness
{
    class TrackLine
    {
        public string name;

        public List<Section> sections;
            
        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(name);

            for(int i=0; i < sections.Count; i++)
            {
                Section section = sections[i];
                section.Display();
            }
        }
    }

    
}
