using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace DemoAPI304.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 10).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet("random-marks")]
        public IEnumerable<int> RandomMark(int count)
        {
            Random r = new Random();
            int[] marks = new int[count];
            for (int i = 0; i < count; i++)
            {
                marks[i] = r.Next(0, 10);
            }
            return marks;
        }
        [HttpGet("evaluate-study")]
        public double EvaluateStudy(double fe, double be, double alg)
        {
            return  (fe + be * 2 + alg) / 4;           
        }


    }
}