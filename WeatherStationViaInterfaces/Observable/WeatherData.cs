using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using WeatherStationShared;

namespace WeatherStationViaInterfaces
{
    public class WeatherData : IObservable
    {
        /// <summary>
        /// List of listeners.
        /// </summary>
        private List<IObserver> observers;

        /// <summary>
        /// Inner timer.
        /// </summary>
        private Timer timer;

        /// <summary>
        /// Weather info.
        /// </summary>
        private Weather weather;

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherData" /> class.
        /// </summary>
        public WeatherData()
        {
            this.observers = new List<IObserver>();
        }

        /// <summary>
        /// Notifies observers.
        /// </summary>
        public void Notify()
        {
            foreach (var observer in this.observers)
            {
                observer?.Update(this, new WeatherChangedEventArgs(this.weather));
            }
        }

        /// <summary>
        /// Registers new observer.
        /// </summary>
        /// <param name="observer">Given listener.</param>
        public void Register(IObserver observer)
        {
            if (!this.observers.Contains(observer))
            {
                this.observers.Add(observer);
            }
        }

        /// <summary>
        /// Unregisters observer.
        /// </summary>
        /// <param name="observer">Given observer to delete.</param>
        public void Unregister(IObserver observer)
        {
            if (this.observers.Contains(observer))
            {
                this.observers.Remove(observer);
            }
        }

        /// <summary>
        /// Starts getting updates.
        /// </summary>
        /// <param name="updateInterval">Update interval.</param>
        public void StartGettingMeasurements(double updateInterval)
        {
            timer = new Timer(updateInterval);
            timer.Elapsed += (obj, args) => GetNewWeather();
            timer.Start();
        }

        /// <summary>
        /// Stops gettig updates.
        /// </summary>
        public void StopGettingMeasurements()
        {
            timer.Stop();
            timer.Dispose();
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
                Notify();
            }
        }
    }
}
