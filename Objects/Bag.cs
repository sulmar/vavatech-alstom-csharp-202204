using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Bag
    {
        // cechy
        public string color;
        public string material;

        public BagType bagType;
        public int capacity;

        public BagSize size;

        // pasek
        public bool hasStrap;

        // zapięcie
        public bool hasClasp;

        // stan
        private bool isOpened;
        private List<string> items = new List<string>();

        // czynności
        public void AddItem(string item)
        {
            if (isOpened)
            {
                items.Add(item);
            }
            else
            {
                Console.WriteLine("Torebka jest zamknięta. Nie można dodawać przedmiotów.");
            }
        }

        public void RemoveItem(string item)
        {
            if (isOpened)
            {
                items.Remove(item);
            }
            else
            {
                Console.WriteLine("Torebka jest zamknięta. Nie można wyjmować przedmiotów.");
            }
        }

        public bool Search(string name)
        {
            if (isOpened)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    string item = items[i];

                    if (item == name)
                    {
                        return true;
                    }
                }

                return false;
            }
            else
            {
                Console.WriteLine("Torebka jest zamknięta. Nie można jej przeszukać.");

                return false;
            }
        }

        public void Open()
        {
            isOpened = true;
        }

        public void Close()
        {
            isOpened = false;
        }
    }

    enum BagSize
    {
        Small,
        Medium,
        Big
    }

    enum BagType
    {
        ToWork,
        Formal,
        Sport
    }
}
