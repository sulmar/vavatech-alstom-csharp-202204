using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneService
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Phone phone1 = new Phone();
                phone1.description = "usterka";
                phone1.cost = 1000;
                phone1.productionDate = DateTime.Parse("2000-10-01");

                Batery batery1 = new Batery();
                batery1.model = "BAT123";
                batery1.capacity = 5000;
                batery1.level = 0.5f;

                phone1.batery = batery1;

                Console.Write("Podaj imię: ");
                string firstName = Console.ReadLine();

                Console.Write("Podaj nazwisko: ");
                string lastName = Console.ReadLine();

                Console.Write("Podaj system operacyjny: ");
                string operatingSystem = Console.ReadLine();

                Console.Write("Podaj opis usterki: ");
                string description = Console.ReadLine();

                phone1.batery = null;

                Person owner = new Person();
                owner.firstName = firstName;
                owner.lastName = lastName;

                Phone phone = new Phone();
                phone.owner = owner;
                phone.batery = batery1;

                Type type = typeof(OperatingSystem);
                phone.operatingSystem = (OperatingSystem)Enum.Parse(type, operatingSystem);

                phone.description = description;

                phone1.Display();
                phone.Display();

            }
        }

    }

    class Person
    {
        public string firstName;
        public string lastName;
    }

    class Batery
    {
        public string model;
        public float level;
        public int capacity;
    }

    class Phone
    {
        //public string ownerFirstName;
        //public string ownerLastName;

        public Person owner;

        public Batery batery;

        public OperatingSystem? operatingSystem;
        public string description;

        public int id;
        public decimal? cost;
        public DateTime? productionDate;

        public void Display()
        {
            Console.WriteLine("--------------------");

            if (owner != null)
            {
                Console.WriteLine($"{owner.firstName} {owner.lastName}");
            }

            Console.WriteLine($"OS: {operatingSystem}");
            Console.WriteLine(description);

            if (cost.HasValue)
            {
                Console.WriteLine($"Cost: {cost}");
            }

            if (productionDate.HasValue)
            {
                Console.WriteLine($"Production date: {productionDate}");
            }

            Console.WriteLine("--------------------");
        }
    }

    enum OperatingSystem
    {
        Android,
        iOS,
        Microsoft
    }

}
