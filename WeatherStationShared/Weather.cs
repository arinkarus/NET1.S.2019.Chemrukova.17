using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationShared
{
    /// <summary>
    /// Weather that station is getting from some source.
    /// </summary>
    public struct Weather : IEquatable<Weather>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Weather"/> struct.
        /// </summary>
        /// <param name="weather">Given weather.</param>
        public Weather(int temperature, int humidity, int pressure)
        {
            this.Humidity = humidity;
            this.Temperature = temperature;
            this.Pressure = pressure;
        }

        /// <summary>
        /// Gets or sets humidity.
        /// </summary>
        public int Humidity { get; set; }

        /// <summary>
        /// Gets or sets pressure.
        /// </summary>
        public int Pressure { get; set; }

        /// <summary>
        /// Gets or sets temperature.
        /// </summary>
        public int Temperature { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Weather other))
            {
                return false;
            }

            return this.Equals(other);
        }

        public override int GetHashCode()
        {
            return (this.Temperature, this.Pressure, this.Humidity).GetHashCode();
        }

        public bool Equals(Weather other)
        {
            return this.Temperature == other.Temperature && this.Pressure == other.Pressure
                && this.Humidity == other.Humidity;
        }
    }
}
