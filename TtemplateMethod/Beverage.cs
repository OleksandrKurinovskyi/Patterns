using System;

namespace TemplateMethod
{
    abstract class Beverage
    {
        public void PrepareBeverage()
        {
            BoilWater();
            MakeBeverage();
            Hook1();
            AddBeverageToCup();
            if (CustomerWantsCondiments)
            {
                AddCondiments();
            }
        }

        protected virtual void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected abstract void MakeBeverage();

        protected virtual void AddBeverageToCup()
        {
            Console.WriteLine("Adding beverageto cup");
        }

        protected abstract void AddCondiments();

        protected virtual void Hook1()
        {
        }

        private bool _customerWantsCondiments = true;
        public virtual bool CustomerWantsCondiments
        {
            get
            {
                return _customerWantsCondiments;
            }
            set
            {
                _customerWantsCondiments = value;
            }
        }
    }   
}
