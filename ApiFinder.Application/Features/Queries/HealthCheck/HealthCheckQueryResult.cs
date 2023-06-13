using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ApiFinder.Application.Features.Queries.HealthCheck
{
    public class HealthCheckQueryResult
    {
        public HttpStatusCode? StatusCode { get; set; }
        public string? ErrorDescription { get; set; }
    }
}
