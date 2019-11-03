namespace Observer
{
    interface IDisplayWeather
    {
        WeatherData WeatherData { get; set; }

        WeaterStation WeaterStation { get; set; }

        void Display();
    }
}
