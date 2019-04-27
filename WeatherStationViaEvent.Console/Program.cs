using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStationViaEvent;

namespace WeatherStationViaEvent.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            var stats = new StatisticReport();
            var currentReport = new CurrentConditionsReport();
            weatherData.WeatherChanged += currentReport.Update;
            weatherData.WeatherChanged += stats.Update;
            weatherData.StartGettingMeasurements(1000);
            System.Console.ReadLine();
            weatherData.StopGettingMeasurements();
            System.Console.ReadLine();
            weatherData.WeatherChanged -= currentReport.Update;
            weatherData.StartGettingMeasurements(1000);
            System.Console.ReadLine();
            weatherData.StopGettingMeasurements();
        }
    }
}
