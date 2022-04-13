using System;

namespace Objects
{
    // Klasa - wzorzec/szablon, definiuje cechy i czynności

    // Obiekt - konkretny egzemplarz danej klasy (instancja obiektu) 
    // Instancję klasy tworzymy za pomocą operatora new()

    class Gun
    {
        public int caliber;
        public float weight;
        public int distance;

        public int bullet;

        // stan
        private bool isLocked = true;

        public void Fire()
        {
            if (!isLocked)
            {                
                if (bullet > 0)
                {
                    Console.WriteLine("Fire!");

                    bullet--;
                }
                else
                {
                    Console.WriteLine("Koniec naboi.");
                }
            }
            else
            {
                Console.WriteLine("Nie można strzelać. Broń jest zabezpieczona.");
            }
        }

        public void Reload(int load)
        {
            bullet = bullet + load;
        }

        public void Unlock()
        {
            isLocked = false;
        }

        public void Lock()
        {
            isLocked = true;
        }
    }
}
