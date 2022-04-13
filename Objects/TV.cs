using System;

namespace Objects
{
    class TV
    {
        // cechy
        public string serialNumber;
        public int size;
        public string manufacture;
        public float power;

        // stan
        private bool isOn;

        private byte selectedChannel;

        // czynności
        public void Push()
        {
            isOn = !isOn;
        }

        public void SelectChannel(byte channel)
        {
            if (isOn)
            {
                selectedChannel = channel;
            }
            else
            {
                Console.WriteLine("TV jest wyłączony. Nie można zmienić kanału.");
            }
        }
    }
}
