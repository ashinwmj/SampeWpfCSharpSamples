using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.SimplePattern
{
   public class PaperAgency:IObserver
    {
        public void Update(object item)
        {
            if (item is WeatherInfo weather)
            {
                Console.WriteLine($"ABC paper Temperature is {weather.Temperature}, Pressure is {weather.Pressure} ");
                ;
            }
        }
    }
}
