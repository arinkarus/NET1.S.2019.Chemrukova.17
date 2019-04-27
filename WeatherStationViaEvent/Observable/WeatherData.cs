using System;
using System.Timers;
using WeatherStationShared;

namespace WeatherStationViaEvent
{
    /// <summary>
    /// Observable class that provides necessary wheather info to observers.
    /// </summary>
    public sealed class WeatherData
    {
        /// <summary>
        /// Timer for getting weather updates.
        /// </summary>
        private Timer timer;

        /// <summary>
        /// Weather info that weather data gets from source.
        /// </summary>
        private Weather weather;

        /// <summary>
        /// Event raised when weather is changed.
        /// </summary>
        public event EventHandler<WeatherChangedEventArgs> WeatherChanged;

        /// <summary>
        /// Start getting updates from source.
        /// </summary>
        /// <param name="updateInterval">Given interval for retrieving info.</param>
        public void StartGettingMeasurements(double updateInterval)
        {
            timer = new Timer(updateInterval);
            timer.Elapsed += (obj, args) => GetNewWeather();
            timer.Start();
        }

        /// <summary>
        /// Stops getting updates.
        /// </summary>
        public void StopGettingMeasurements()
        {
            timer.Stop();
            timer.Dispose();
        }

        private void OnWheatherChanged()
        {
            var weatherChanged = WeatherChanged;
            weatherChanged?.Invoke(this, new WeatherChangedEventArgs(this.weather));
        }

        private void GetNewWeather()
        {
            var random = new Random();
            var newWeather = new Weather()
            {
                Temperature = random.Next(-45, 45),
                Humidity = random.Next(50, 100),
                Pressure = random.Next(500, 1000)
            };

            if (!weather.Equals(newWeather))
            {
                this.weather = newWeather;
                OnWheatherChanged();
            }
        }
    }
}
