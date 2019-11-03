namespace Observer
{
    struct WeatherData
    {
        public readonly float Temperature;

        public readonly float Humdity;

        public readonly float Pressure;

        public WeatherData(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humdity = humidity;
            Pressure = pressure;
        }

        public override string ToString()
        {
            return string.Format("Temperature = {0}, Humididy = {1}, Pressure = {2}", Temperature, Humdity, Pressure);
        }
    }
}
