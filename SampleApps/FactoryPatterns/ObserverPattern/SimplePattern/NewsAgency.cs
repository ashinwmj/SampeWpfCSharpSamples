using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.ObserverPattern.SimplePattern;

namespace DesignPatterns.ObserverPattern
{
   public class NewsAgency:IObserver
    {
        public void Update(object item)
        {
            if (item is WeatherInfo info)
            {
                Console.WriteLine($"ABC news. Temperature is {info.Temperature}, Pressure is {info.Pressure} ");
            }

        }
    }
}
