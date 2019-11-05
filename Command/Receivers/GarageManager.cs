using System;

namespace Command.Receivers
{
    class GarageManager
    {
        public void DoorUp()
        {
            Console.WriteLine("GarageManager dore is UP");
        }

        public void DooDown()
        {
            Console.WriteLine("GarageManager dore is DOWN");
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
