using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Car
    {
        // cechy (pola)
        public CarType carType;
        public FuelType _fuelType;
        public GearBoxType gearBoxType;

        public int engineCapacity;
        public string color;

        public byte _maxSpeed;
        public byte fuelConsumption;

        public byte doors;

        public string make;
        public string model;

        public string vin;

        // stan
        public CarState carState;

        private bool isEngineRunning;

        public bool isLightOn;
        public bool isWindshieldWipersOn;
        public bool isSeatBeltsOn;
        public bool isMusicOn;

        public int currentSpeed;
        public byte _gear;
        public int direction;

        // Konstruktor (metoda do tworzenia obiektu)
        // nazwa musi być taka sama jak nazwa klasy

        // Konstruktor służy do 2 rzeczy:
        // - do określenia wymaganych parametrów do utworzenia obiektu
        // - do określenia początkowych wartości pól
        public Car(byte maxSpeed, FuelType fuelType)
        {
            _maxSpeed = maxSpeed;
            _fuelType = fuelType;

            color = "White";
            direction = 90;
            currentSpeed = 0;
        }

        // czynności (metody)
        public void EngineRun()
        {
            isEngineRunning = true;
        }

        public void PutInGear(byte gear)
        {
            _gear = gear;
        }

        public void PushGasPedal()
        {
            if (isEngineRunning)
            {
                if (_gear > 0)
                {
                    if (currentSpeed <= _maxSpeed)
                    {
                        currentSpeed = currentSpeed + 1;
                    }
                }
                else
                {
                    Console.WriteLine("Wrzuć bieg!");
                }
            }
            else
            {
                Console.WriteLine("Silnik wyłączony. Uruchom samochód.");
            }
        }

        public void TurnLeft(short angle)
        {
            direction = direction - angle;
        }

        public void TurnRight(short angle)
        {
            direction = direction + angle;
        }

        public void PushStopPedal()
        {
            if (currentSpeed > 0)
            {
                currentSpeed = currentSpeed - 1;
            }            
        }

        public void Horn()
        {
            Console.WriteLine("Tuuu tuuuu!!!");
        }

    }

    enum CarState
    {
        New,
        Used
    }

    enum GearBoxType
    {
        Manual,
        Automatic
    }

    enum CarType
    {
        Osobowy,
        Ciezarowy
    }

    enum FuelType
    {
        Gas,
        Oil,
        Electric
    }
}
