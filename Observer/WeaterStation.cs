using System;
using System.Collections.Generic;
using Observer.Observers;

namespace Observer
{
    class WeaterStation : IObservable
    {
        private List<IObserver> m_obsersers;

        private Random m_random;

        private float GetTemperature()
        {
            return  m_random.Next(0, 30) + (float)m_random.NextDouble();
        }

        private float GetHumidity()
        {
            return m_random.Next(0, 100);
        }

        private float GetPressure()
        {
            return m_random.Next(700, 770);
        }

        private WeatherData GetWeatherData()
        {
            return new WeatherData(GetTemperature(), GetHumidity(), GetPressure());
        }

        public WeaterStation()
        {
            m_obsersers = new List<IObserver>();
            m_random = new Random();
        }

        public void RegisterObserver(IObserver observer)
        {
            if (observer != null && !m_obsersers.Contains(observer))
            {
                m_obsersers.Add(observer);
            }
        }

        public void RemoveObsorver(IObserver observer)
        {
            if (m_obsersers.Contains(observer))
            {
                m_obsersers.Remove(observer);
            }
        }

        public void NotifyObservers()
        {
            foreach (var obserser in m_obsersers)
            {
                obserser.Update(GetWeatherData());
            }
        }

        public void OnWeaterDataChanged()
        {
            NotifyObservers();
        }
    }
}
