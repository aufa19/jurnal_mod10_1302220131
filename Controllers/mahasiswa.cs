using Microsoft.AspNetCore.Mvc;

namespace modul8_1302220131.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class mahasiswa : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<mahasiswa> _logger;

        public mahasiswa(ILogger<mahasiswa> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<modul8_1302220131.mahasiswa> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new mahasiswa
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
