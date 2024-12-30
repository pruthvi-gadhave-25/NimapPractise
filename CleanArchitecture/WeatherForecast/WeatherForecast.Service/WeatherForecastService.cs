using WeatherForecast.Domain.Abstractions;
using WeatherForecast.Domain.Models;

namespace WeatherForecast.Service
{
    public class WeatherForecastService : IWeatherForecastService
    {

        private readonly IWeatherForecastRepository  _weatherForecastRepository;

        public WeatherForecastService(IWeatherForecastRepository weatherForecastRepository)
        {
            _weatherForecastRepository = weatherForecastRepository;
        }
        public List<WeatherForecasts> ProcessTemprature()
        {
            var forecasts = _weatherForecastRepository.GetForeacst();
            var res =  new List<WeatherForecasts>();
            foreach (var f in forecasts) {
                f.TemperatureC = 32 + (int)(f.TemperatureC / 0.5556);
                res.Add(f);
            }
            return res;

           
        }
    }
}
