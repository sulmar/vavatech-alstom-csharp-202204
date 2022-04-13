using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alstom.Models
{
    class Fan
    { 
        public string _model;
        public string _color;

        private int rpm;
        private bool oscillation;

        private const byte minLevel = 0;
        private const byte maxLevel = 3;

        public Fan(string model)
        {
            _model = model;
            _color = "White";

            rpm = 0;
            oscillation = false;
        }

        private void SetRpm(byte level)
        {
            if (level >= minLevel && level <= maxLevel)
            {
                rpm = level * 100;
            }
        }

        public void PushOscillationButton()
        {
            oscillation = !oscillation;
        }

        public void PushButton0()
        {
            SetRpm(0);
        }

        public void PushButton1()
        {
            SetRpm(1);
        }

        public void PushButton2()
        {
            SetRpm(2);
        }

        public void PushButton3()
        {
            SetRpm(3);
        }

        public void SetVolume(byte volume)
        {

        }


    }
}
