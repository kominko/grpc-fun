using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcFun.Services
{
    public class CountryService : Country.CountryBase
    {
        private readonly ILogger<GreeterService> _logger;
        public CountryService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<CountriesReply> GetAll(EmptyRequest request, ServerCallContext context)
        {
            var countries = new List<CountryReply>
            {
                new CountryReply {Id = 1, Name = "UK", Description = "United Kingdom"},
                new CountryReply {Id = 2, Name = "US", Description = "United States"},
                new CountryReply {Id = 3, Name = "GER", Description = "Germany"},
                new CountryReply {Id = 4, Name = "FRA", Description = "France"},
                new CountryReply {Id = 5, Name = "JP", Description = "Japan"},
            };

            var countriesReply = new CountriesReply
            {
                Countries = { countries }
            };

            _logger.LogTrace(countriesReply.ToString());

            return Task.FromResult(countriesReply);
        }
    }
}
