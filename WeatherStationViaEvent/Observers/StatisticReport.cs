using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStationShared;

namespace WeatherStationViaEvent
{
    public class StatisticReport
    {
        private readonly List<WeatherChangedEventArgs> weatherInfos;

        public StatisticReport()
        {
            this.weatherInfos = new List<WeatherChangedEventArgs>();
        }

        public void Update(object sender, EventArgs info)
        {
            if ((info is WeatherChangedEventArgs weatherInfo))
            {
                weatherInfos.Add(weatherInfo);
                double temperature = weatherInfos.Average(s => s.Temperature);
                double pressure = weatherInfos.Average(s => s.Pressure);
                double humidity = weatherInfos.Average(s => s.Humidity);
                Console.WriteLine("--------------------STATS---------------------");
                Console.WriteLine($"Temperature: {temperature}");
                Console.WriteLine($"Humidity: {humidity}");
                Console.WriteLine($"Pressure: {pressure}");
                Console.WriteLine("----------------------------------------------");
            }
        }
    }
}
