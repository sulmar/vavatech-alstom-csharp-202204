using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
  

    class Program
    {
        static void Main(string[] args)
        {
            // Torebka
            Bag bag = new Bag();
            bag.color = "Black";
            bag.capacity = 1000;
            bag.bagType = BagType.Formal;

            bag.Open();
            bag.AddItem("okulary");
            bag.AddItem("portfel");
            bag.AddItem("laptop");
            bag.Close();


            bag.Open();
            if (bag.Search("portfel"))
            {
                bag.RemoveItem("portfel");
            }
            bag.Close();

            // Karabin
            Gun gun = new Gun();
            gun.caliber = 10;
            gun.distance = 1000;
            gun.Reload(20);

            gun.Fire();

            gun.Unlock();

            for (int i = 0; i < 30; i++)
            {
                gun.Fire();
            }

            gun.Lock();

            // TV
            TV tv = new TV();
            tv.manufacture = "Sony";
            tv.power = 100;
            tv.size = 32;

            tv.Push();
            tv.SelectChannel(10);
            tv.Push();
            tv.Push();


            // Signal 104R
            string name1 = "104N";
            SignalStates state1 = SignalStates.Zabraniajacy;

            // Signal 118N
            string name2 = "118N";
            SignalStates state2 = SignalStates.PozaKontrola;

            // zezwalający = 0, zabraniający = 1, poza kontrolą = 2, manewrowy = 3
            switch(state1)
            {
                case SignalStates.Zezwalajacy: Display(name2, ConsoleColor.Green); break; // zielony
                case SignalStates.Zabraniajacy: Display(name2, ConsoleColor.Red); break; // szary
                case SignalStates.PozaKontrola: Display(name2, ConsoleColor.White); break; // biały
                case SignalStates.Manewrowy: Display(name2, ConsoleColor.Yellow); break; // żółty
            }

            Signal signal1 = new Signal();
            signal1.name = "104N";
            signal1.signalType = SignalTypes.Odstepowy;
            signal1.state = SignalStates.Zezwalajacy;
            signal1.SetLocation(100, 50);

            signal1.Display();

            Signal signal2 = new Signal();
            signal2.name = "118N";
            signal2.signalType = SignalTypes.Odstepowy;
            signal2.state = SignalStates.Manewrowy;
            signal2.SetLocation(200, 100);

            signal2.Display();

            Person person1 = new Person(); // utworzenie obiektu
            person1.firstName = "John";
            person1.lastName = "Smith";
            person1.experience = 25;
            person1.DoWork();

            Person person2 = new Person();
            person2.firstName = "Ann";
            person2.lastName = "Smith";
            person2.experience = 5;
            person2.DoWork();


           


        }

        static void Display(string name, ConsoleColor color)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = color;
            Console.WriteLine($"[{name}]");
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


    class Person
    {
        public string firstName;
        public string lastName;
        public byte experience;

        private byte age;

        public void DoWork()
        {
            if (experience > 10)
            {
                Console.WriteLine("Working slowly...");
            }
            else
            {
                Console.WriteLine("Working...");
            }
        }
    }

    class Signal
    {
        // atrybuty
        public string name;

        public SignalStates state;
        public SignalTypes signalType;

        private int x;
        private int y;

        // metody
        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.White;

            switch (state)
            {
                case SignalStates.Zezwalajacy: Console.BackgroundColor = ConsoleColor.Green; break; // zielony
                case SignalStates.Zabraniajacy: Console.BackgroundColor = ConsoleColor.Red; break; // szary
                case SignalStates.PozaKontrola: Console.BackgroundColor = ConsoleColor.White; break; // biały
                case SignalStates.Manewrowy: Console.BackgroundColor = ConsoleColor.Yellow; break; // żółty
            }

            Console.WriteLine($"[{name}]");
            Console.WriteLine($"({x},{y})");            
            Console.ResetColor();
        }

        public void SetLocation(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }

    // typ sygnalizatora: bez tarczy manewrowej, z tarczą manewrową, odstępy ...
    enum SignalTypes
    {
        BezTarczyManewrowej,
        ZTarczaManewrowa,
        Odstepowy
    }
}
