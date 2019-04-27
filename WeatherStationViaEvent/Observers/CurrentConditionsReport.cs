using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStationShared;

namespace WeatherStationViaEvent
{
    public class CurrentConditionsReport
    {
        public void Update(object sender, EventArgs info)
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
