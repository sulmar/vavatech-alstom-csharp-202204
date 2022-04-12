using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainMadness
{
    class Program
    {
        static void Main(string[] args)
        {
            TrackLine trackLine2 = new TrackLine();
            trackLine2.name = "Tor 2";

            Section section1 = new Section();
            section1.name = "it104";
            section1.occupancy = false;

            Signal signal104N = new Signal();
            signal104N.name = "104N";
            signal104N.state = SignalStates.PozaKontrola;

            Section section2 = new Section();
            section2.name = "it118";
            section2.occupancy = false;
            section2.signal = signal104N;

            Signal signal118N = new Signal();
            signal118N.name = "118N";
            signal118N.state = SignalStates.Zabraniajacy;

            Section section3 = new Section();
            section3.name = "it130";
            section3.occupancy = false;
            section3.signal = signal118N;

            trackLine2.sections = new List<Section> { section1, section2, section3 };

            trackLine2.Display();

        }
    }


}
