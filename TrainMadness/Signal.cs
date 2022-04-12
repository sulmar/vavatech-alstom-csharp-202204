using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainMadness
{
    class Signal
    {
        public string name;
        public SignalStates state;

        public int x;
        public int y;

        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(name);

            switch (state)
            {
                case SignalStates.Zezwalajacy: Console.ForegroundColor = ConsoleColor.Green; break; // zielony
                case SignalStates.Zabraniajacy: Console.ForegroundColor = ConsoleColor.Red; break; // szary
                case SignalStates.PozaKontrola: Console.ForegroundColor = ConsoleColor.White; break; // biały
                case SignalStates.Manewrowy: Console.ForegroundColor = ConsoleColor.Yellow; break; // żółty
            }

            Console.WriteLine("|-O");
            Console.ResetColor();
        }
    }

    // Typ wyliczeniowy
    enum SignalStates
    {
        Zezwalajacy,
        Zabraniajacy,
        PozaKontrola,
        Manewrowy
    }
}
