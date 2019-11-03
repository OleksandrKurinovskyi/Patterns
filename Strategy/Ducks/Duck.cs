using System;
using Strategy.FlyBehavior;
using Strategy.QuackBehavior;

namespace Strategy.Ducks
{
    abstract class Duck
    {
        private IFlyBehavior m_flyBehavior;

        internal IFlyBehavior IFlyBehavior
        {
            get
            {
                return m_flyBehavior;
            }
            set
            {
                m_flyBehavior = value;
            }
        }

        private IQuackBehavior m_quackBehavior;

        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            IFlyBehavior = flyBehavior;
            m_quackBehavior = quackBehavior;
        }

        public void Fly()
        {
            if (m_flyBehavior != null)
            {
                m_flyBehavior.Fly();
            }
        }

        public virtual void Swim()
        {
            Console.WriteLine("Swim");
        }

        public abstract void Display();

        public void Quack()
        {
            if (m_quackBehavior != null)
            {
                m_quackBehavior.DoQuack();
            }
        }
    }
}
