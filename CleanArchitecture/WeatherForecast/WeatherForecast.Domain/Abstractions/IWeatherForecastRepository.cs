using WeatherForecast.Domain.Models;
namespace WeatherForecast.Domain.Abstractions
{
    public interface IWeatherForecastRepository
    {
        WeatherForecasts [] GetForeacst();

    }
}
