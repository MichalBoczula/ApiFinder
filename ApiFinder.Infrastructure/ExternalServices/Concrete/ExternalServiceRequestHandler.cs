using ApiFinder.Infrastructure.ExternalServices.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFinder.Infrastructure.ExternalServices.Concrete
{
    public class ExternalServiceRequestHandler : IExternalServiceRequestHandler
    {
        private readonly HttpClient _httpClient;

        public ExternalServiceRequestHandler(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<bool> CheckHealth(string url)
        {
            throw new NotImplementedException();
        }
    }
}
