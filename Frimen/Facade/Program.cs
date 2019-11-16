using TitleLib;
using System.Reflection;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Title.UpperIndent(Assembly.GetExecutingAssembly());

            Computer c = new Computer();
            c.Copy();
            System.Console.WriteLine();
            c.Finish();

            Title.BottonIndent();
        }
    }

    class Computer
    {
        private PowerController _pw;

        private DVDRom _dvd;

        private HHD _hhd;

        public Computer()
        {
            _pw = new PowerController();
            _dvd = new DVDRom();
            _hhd = new HHD(_dvd);
        }

        public void Copy()
        {
            _pw.On();
            _dvd.SetDvd();
            _hhd.Copy();
        }

        public void Finish()
        {
            _pw.Off();
            _dvd.Load();
            _hhd.Copy();
        }
    }
}
