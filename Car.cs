using MiNET.Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Task_05_Q2
{
    class Car
    {
        private int speed;

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }


        public void AccelerationSpeed(int num)
        {
            while (num > 0)
            {
                Speed++;
                num--;
            }
        }
        public void LoweringSpeed(int num)
        {
            while (num > 0)
            {
                Speed--;
                num--;
            }
        }
        public void StopCar()
        {
            Speed = 0;
        }
        public string GetDescription()
        {
            return $" The speed of your car: {Speed}";
        }
    }
}