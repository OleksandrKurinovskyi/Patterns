using Observer.Observers;

namespace Observer
{
    interface IObservable
    {
        void RegisterObserver(IObserver observer);

        void RemoveObsorver(IObserver observer);

        void NotifyObservers();
    }
}
