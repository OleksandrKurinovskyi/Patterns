using System;

namespace Command.Receivers
{
    class LightInRoomManager
    {
        public void On()
        {
            Console.WriteLine("Light in room is ON");
        }

        public void Off()
        {
            Console.WriteLine("Light in room is OFF");
        }
    }
}
