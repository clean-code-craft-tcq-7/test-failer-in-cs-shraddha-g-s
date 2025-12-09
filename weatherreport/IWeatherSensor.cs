using System;

namespace Philips.TemperatureSpace
{
    internal interface IWeatherSensor
    {
        double TemperatureInC { get; set; }
        int Precipitation { get; set; }
        int WindSpeedKMPH { get; set; }
        int Humidity { get; set; }

    }
}
