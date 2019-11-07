using System;

namespace Facade
{
    class HHD
    {
        private DVDRom _dvdRom;

        public HHD(DVDRom dvdRom)
        {
            _dvdRom = dvdRom;
        }

        public void Copy()
        {
            if (_dvdRom.HasData)
            {
                Console.WriteLine("Copy");
            }
            else
            {
                Console.WriteLine("Empty");
            }
        }
    }
}
