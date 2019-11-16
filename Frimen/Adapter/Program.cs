using TitleLib;
using System.Reflection;
using Adapter.Ducks;
using Adapter.Turkies;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Title.UpperIndent(Assembly.GetExecutingAssembly());

            Client client = new Client();
            IDuck duck = new WildDuck();

            client.WorkWithDuck(duck);

            System.Console.WriteLine();

            ITurkey turkey = new WildTurkey();
            AdapterTurkeyToDuck adapterTurkeyToDuck = new AdapterTurkeyToDuck(turkey);
            client.WorkWithDuck(adapterTurkeyToDuck);

            Title.BottonIndent();
        }
    }
}
