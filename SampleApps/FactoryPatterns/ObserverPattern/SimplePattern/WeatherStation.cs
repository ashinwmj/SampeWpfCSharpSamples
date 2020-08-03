using System.Collections.Generic;
using System.Threading;

namespace DesignPatterns.ObserverPattern.SimplePattern
{
    public class WeatherStation:ISubject
    {
        private  IList<IObserver> _observers=new List<IObserver>();
        public WeatherInfo WeatherPoint { get; set; }
        public void Subscribe(IObserver observer)
        {
           _observers.Add(observer); }

        public void UnSubsribe(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {

            foreach (var observer in _observers)
            {
                observer.Update(WeatherPoint);
            }
        }

        public void ReportWeather()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                WeatherPoint=new WeatherInfo();
                WeatherPoint.Temperature = 35;
                WeatherPoint.Pressure = 30;
                Notify();
            }
        }
    }

    public class WeatherInfo
    {
        public int Temperature { get; set; }
        public int Pressure { get; set; }
    }
}
