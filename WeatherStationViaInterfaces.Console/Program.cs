using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationViaInterfaces.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            var stats = new StatisticReport();
            var currentReport = new CurrentConditionsReport();
            weatherData.Register(currentReport);
            weatherData.Register(stats);
            weatherData.StartGettingMeasurements(1000);
            System.Console.ReadLine();
            weatherData.StopGettingMeasurements();
            System.Console.ReadLine();
            weatherData.Unregister(currentReport);
            weatherData.StartGettingMeasurements(1000);
            System.Console.ReadLine();
            weatherData.StopGettingMeasurements();
        }
    }
}
