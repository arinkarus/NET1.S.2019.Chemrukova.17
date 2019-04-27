using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStationShared;

namespace WeatherStationViaInterfaces
{
    public class CurrentConditionsReport : IObserver
    {
        public void Update(IObservable sender, EventArgs info)
        {
            if ((info is WeatherChangedEventArgs weatherInfo))
            {
                Console.WriteLine("--------------------REPORT--------------------");
                Console.WriteLine($"Current temperature: {weatherInfo.Temperature}");
                Console.WriteLine($"Current humidity: {weatherInfo.Humidity}");
                Console.WriteLine($"Current pressure: {weatherInfo.Pressure}");
                Console.WriteLine("----------------------------------------------");
            }
        }
    }
}
