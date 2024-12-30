using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Domain.Abstractions;
using WeatherForecast.Domain.Models;

namespace WeatherForecast.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _weatherService;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecasts> Get() => _weatherService.ProcessTemprature();
    }
}
