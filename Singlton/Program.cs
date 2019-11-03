using System;
using TitleLib;
using System.Reflection;
using System.Threading;

namespace Singlton
{
    class Program
    {
        static void Main(string[] args)
        {
            Title.UpperIndent(Assembly.GetExecutingAssembly());

            TestSimple();

            //TestThresd();


            Title.BottonIndent();
        }

        static void TestSimple()
        {
            SingltonClass s1 = SingltonClass.GetInstance();
            Console.WriteLine(s1.GetHashCode());

            SingltonClass s2 = SingltonClass.GetInstance();
            Console.WriteLine(s2.GetHashCode());
        }

        static void TestThresd()
        {
            (new Thread(() =>
            {
                SingltonClass s1 = SingltonClass.GetInstance();
                Console.WriteLine(s1.GetHashCode());
            })).Start();
            SingltonClass s2 = SingltonClass.GetInstance();
            Console.WriteLine(s2.GetHashCode());
        }
    }
}
