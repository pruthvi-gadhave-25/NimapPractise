using WeatherForecast.Domain.Models;

namespace WeatherForecast.Domain.Abstractions
{
    public interface IWeatherForecastService    {

        List<WeatherForecasts> ProcessTemprature();
    }
}
