using TitleLib;
using System.Reflection;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Title.UpperIndent(Assembly.GetExecutingAssembly());

            IComponent n1 = new ConcreteNode1();
            IComponent n2 = new ConcreteNode2();
            IComponent n3 = new ConcreteNode3();
            IComponent n4 = new ConcreteNode3();

            IComponent composite1 = new Composite();
            composite1.Add(n1);
            composite1.Add(n2);
            composite1.Add(n3);
            composite1.Add(n4);

            IComponent composite2 = new Composite();
            composite2.Add(n4);
            composite2.Add(n1);

            IComponent composite3 = new Composite();
            composite3.Add(new ConcreteNode1());
            composite3.Add(new ConcreteNode1());
            composite3.Add(new ConcreteNode1());
            composite3.Add(new ConcreteNode1());
            composite2.Add(composite3);



            IComponent composite4 = new Composite();
            composite4.Add(new ConcreteNode3());
            composite4.Add(new ConcreteNode3());
            composite4.Add(new ConcreteNode3());
            composite4.Add(new ConcreteNode3());
            composite4.Add(new ConcreteNode3());
            composite4.Add(new ConcreteNode3());
            composite4.Add(new ConcreteNode3());
            composite4.Add(new ConcreteNode3());
            composite3.Add(composite4);

            composite1.Add(composite2);

            composite1.Option();


            System.Console.WriteLine(new string('_', 50));
            foreach (var item in composite1)
            {
                System.Console.WriteLine(item.GetType().Name);
            }


            


            Title.BottonIndent();
        }
    }
}
