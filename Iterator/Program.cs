using System.Reflection;
using TitleLib;
using Iterator.Aggregates;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Title.UpperIndent(Assembly.GetExecutingAssembly());

            Client client = new Client();

            var ag1 = new ConcreteAggregate1<MenuItem>();
            var ag2 = new ConcreteAggregate2<MenuItem>();

            client.Print(ag1);
            client.Print(ag2);
            client.Print(ag1);

            Title.BottonIndent();
        }
    }
}
