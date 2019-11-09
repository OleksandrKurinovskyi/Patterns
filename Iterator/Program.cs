using System.Reflection;
using TitleLib;

namespace Iterator
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
