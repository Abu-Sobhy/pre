using AspNetCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly WeatherForCastSeervices _service;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, WeatherForCastSeervices service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _service.GetForecasts();
        }
    }
}
