using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFinder.Application.Features.Queries.HealthCheck
{
    public class HealthCheckQuery : IRequest<HealthCheckQueryResult>
    {
        public string Uri { get; set; }
    }
}
