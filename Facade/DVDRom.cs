using System;

namespace Facade
{
    class DVDRom
    {
        private bool _data;

        public bool HasData
        {
            get
            {
                return _data;
            }
        }

        public void SetDvd()
        {
            _data = true;
            Console.WriteLine("Set DVD");
        }

        public void Load()
        {
            _data = false;
            Console.WriteLine("Take DVD");
        }
    }
}
