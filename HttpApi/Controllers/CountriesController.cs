using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HttpApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountriesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CountriesController> _logger;

        public CountriesController(ILogger<CountriesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Country> Get()
        {
            var countries = new List<Country>
            {
                new Country {Id = 1, Name = "UK", Description = "United Kingdom"},
                new Country {Id = 2, Name = "US", Description = "United States"},
                new Country {Id = 3, Name = "GER", Description = "Germany"},
                new Country {Id = 4, Name = "FRA", Description = "France"},
                new Country {Id = 5, Name = "JP", Description = "Japan"},
            };
            _logger.LogTrace(countries.ToString());
            return countries;
        }
    }
}
