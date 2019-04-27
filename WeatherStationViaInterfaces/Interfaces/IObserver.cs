using System;

namespace WeatherStationViaInterfaces
{
    public interface IObserver
    {
        void Update(IObservable sender, EventArgs info);
    }
}
