using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("uczestnicy.txt");

            Console.WriteLine(content);
            
            // Odczytanie tablicy tekstów na podstawie pliku
            string[] lines = File.ReadAllLines("uczestnicy.txt");

            //for (int i = 0; i < lines.Length; i++)
            //{
            //    string line = lines[i];
            //}

            List<Member> members = new List<Member>();

            // Przetworzenie tablicy na listę obiektów
            foreach(string line in lines)
            {
                Console.WriteLine(line);

                string[] columns = line.Split(',');

                Member member = new Member();
                member.firstName = columns[0];
                member.lastName = columns[1];
                member.role = columns[2];

                members.Add(member);
            }

            // Wyświetlenie uczestników
            Console.WriteLine("----------------------");
            foreach (Member member in members)
            {                
                member.Code();
            }
        }
    }

    class Member
    {
        public string firstName;
        public string lastName;
        public string role;

        public void Code()
        {
            Console.WriteLine($"{firstName} coding...");
        }
    }
}
