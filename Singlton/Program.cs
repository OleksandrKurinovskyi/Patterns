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

            //TestSimple();

            TestThresd();


            Title.BottonIndent();
        }

        static void TestSimple()
        {
            SingltonClass s1 = SingltonClass.GetInstance();
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(SingltonClass.Counter);

            SingltonClass s2 = SingltonClass.GetInstance();
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(SingltonClass.Counter);
        }

        static void TestThresd()
        {
            (new Thread(() =>
            {
                SingltonClass s1 = SingltonClass.GetInstance();
                Console.WriteLine(s1.GetHashCode());
                Console.WriteLine(SingltonClass.Counter);
            })).Start();
            SingltonClass s2 = SingltonClass.GetInstance();
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(SingltonClass.Counter);
        }
    }
}
