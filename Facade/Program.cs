using TitleLib;
using System.Reflection;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Title.UpperIndent(Assembly.GetExecutingAssembly());

            Title.BottonIndent();
        }
    }
}
