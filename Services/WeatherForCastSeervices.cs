using System.Numerics;

namespace AspNetCore.Services
{
    public class WeatherForCastSeervices
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private ILogger<WeatherForCastSeervices> _Logger { get; }

        public WeatherForCastSeervices(ILogger<WeatherForCastSeervices> logger)
        {
            _Logger = logger;
        }


        public IEnumerable<WeatherForecast> GetForecasts()
        {

            _Logger.LogInformation("Getting forcasts data");

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
