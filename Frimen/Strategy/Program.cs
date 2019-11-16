using System;
using System.Reflection;
using TitleLib;
using Strategy.Ducks;
using Strategy.FlyBehavior;
using Strategy.QuackBehavior;
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Title.UpperIndent(Assembly.GetExecutingAssembly());

            List<Duck> ducks = new List<Duck>()
            {
                new SavageDuck(new FlyWithWings(), new Quack()),
                new SavageDuck(new FlyWithMachine(), new MuteQuack())
            };

            Print(ducks);
            ducks[0].IFlyBehavior = new FlyWithMachine();
            Print(ducks);

            Title.BottonIndent();
        }

        static void Print(IEnumerable<Duck> ducks)
        {
            foreach (var item in ducks)
            {
                item.Fly();
                item.Quack();
                item.Swim();
                item.Display();
                Console.WriteLine();
            }
            Console.WriteLine("---------");
        }
    }
}
