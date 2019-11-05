using System;
using TitleLib;
using System.Reflection;

namespace Command
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
