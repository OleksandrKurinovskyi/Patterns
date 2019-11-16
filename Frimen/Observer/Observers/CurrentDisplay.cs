using System;

namespace Observer.Observers
{
    class CurrentDisplay : IObserver, IDisplayWeather
    {
        public WeatherData WeatherData { get; set; }

        public WeaterStation WeaterStation { get; set; }

        public CurrentDisplay(WeaterStation weaterStation)
        {
            if (weaterStation == null)
            {
                throw new NullReferenceException();
            }
            WeaterStation = weaterStation;
            WeaterStation.RegisterObserver(this);
        }

        public void Update(params object[] args)
        {
            if (args.Length == 1 && args[0] is WeatherData)
            {
                WeatherData = (WeatherData)args[0];
                Display();
            }
        }

        public void Display()
        {
            Console.WriteLine("Display from {0}: {1}", this.GetType().Name, WeatherData);
        }
    }
}
