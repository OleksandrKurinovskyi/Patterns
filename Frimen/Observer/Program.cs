using System;
using TitleLib;
using System.Reflection;
using Observer.Observers;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Title.UpperIndent(Assembly.GetExecutingAssembly());

            var weaterStation = new WeaterStation();
            var currentDisplay = new CurrentDisplay(weaterStation);
            TestMethod(weaterStation);

            Title.BottonIndent();
        }

        static void TestMethod(WeaterStation weaterStation)
        {
            while (true)
            {
                weaterStation.OnWeaterDataChanged();
                Console.ReadKey();
            }
        }
    }
}
