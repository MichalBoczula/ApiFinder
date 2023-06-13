using ApiFinder.Infrastructure.ExternalServices.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public async Task<HttpStatusCode> CheckHealth(string url)
        {
            try
            {
                var response = await _httpClient.GetAsync(url);
                return response.StatusCode;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return HttpStatusCode.InternalServerError;
            }
        }
    }
}
