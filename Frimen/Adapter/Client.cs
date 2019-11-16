using Adapter.Ducks;

namespace Adapter
{
    class Client
    {
        public void WorkWithDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
