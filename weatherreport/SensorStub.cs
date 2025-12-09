
namespace Philips.TemperatureSpace
{    /// <summary>
     /// This is a stub for a weather sensor. For the sake of testing 
     /// we create a stub that generates weather data and allows us to
     /// test the other parts of this application in isolation
     /// without needing the actual Sensor during development
     /// </summary>
    public class SensorStub : IWeatherSensor
    {
        public double TemperatureInC { get; set; }
        public int Precipitation { get; set; }
        public int WindSpeedKMPH { get; set; }
        public int Humidity { get; set; }

        // Default values, but can be overridden
        public SensorStub(
            double temperatureInC = 26,
            int precipitation = 70,
            int windSpeedKMPH = 52,
            int humidity = 72)
        {
            TemperatureInC = temperatureInC;
            Precipitation = precipitation;
            WindSpeedKMPH = windSpeedKMPH;
            Humidity = humidity;
        }
    }
}
