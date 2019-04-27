using System;

namespace WeatherStationShared
{
    /// <summary>
    /// Weather info.
    /// </summary>
    public class WeatherChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherChangedEventArgs" /> class.
        /// </summary>
        /// <param name="temperature">Given temperature.</param>
        /// <param name="humidity">Given humidity.</param>
        /// <param name="pressure">Given pressure.</param>
        public WeatherChangedEventArgs(int temperature, int humidity, int pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherChangedEventArgs" /> class.
        /// </summary>
        /// <param name="weather">Given weather.</param>
        public WeatherChangedEventArgs(Weather weather)
        {
            this.Humidity = weather.Humidity;
            this.Temperature = weather.Temperature;
            this.Pressure = weather.Pressure;
        }

        /// <summary>
        /// Gets or sets temperature.
        /// </summary>
        public int Temperature { get; set; }

        /// <summary>
        /// Gets or sets humidity
        /// </summary>
        public int Humidity { get; set; }

        /// <summary>
        /// Gets or sets pressure.
        /// </summary>
        public int Pressure { get; set; }
    }
}
