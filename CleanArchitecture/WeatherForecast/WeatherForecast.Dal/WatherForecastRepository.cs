

using WeatherForecast.Domain.Abstractions;
using WeatherForecast.Domain.Models;

namespace WeatherForecast.Dal
{
    public class WatherForecastRepository : IWeatherForecastRepository
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherForecasts[] GetForeacst()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecasts
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
           .ToArray();
        }
    }
}
