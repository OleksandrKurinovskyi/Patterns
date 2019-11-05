using System;

namespace Command.Receivers
{
    class GarageManager
    {
        public void DoorUp()
        {
            Console.WriteLine("GarageManager doore is UP");
        }

        internal void DoorDown()
        {
            Console.WriteLine("GarageManager doore is DOWN");
        }

        public void DoorStop()
        {
            Console.WriteLine("GarageManager dore is STOP");
        }

        public void LightOn()
        {
            Console.WriteLine("Light in garage is ON");
        }

        public void LightOff()
        {
            Console.WriteLine("Light in garage is OFF");
        }
    }
}
