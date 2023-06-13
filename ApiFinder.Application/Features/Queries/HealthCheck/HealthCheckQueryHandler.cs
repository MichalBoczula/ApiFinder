using ApiFinder.Application.Contracts;
using ApiFinder.Application.Features.Common;
using ApiFinder.Infrastructure.ExternalServices.Abstract;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFinder.Application.Features.Queries.HealthCheck
{
    internal class HealthCheckQueryHandler : CommandBase, IRequestHandler<HealthCheckQuery, HealthCheckQueryResult>
    {
        private readonly IExternalServiceRequestHandler _externalServiceRequestHandler;

        public HealthCheckQueryHandler(IApiFinderContext context, IMapper mapper, IExternalServiceRequestHandler externalServiceRequestHandler) : base(context, mapper)
        {
            _externalServiceRequestHandler = externalServiceRequestHandler;
        }

        public async Task<HealthCheckQueryResult> Handle(HealthCheckQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await this._externalServiceRequestHandler.CheckHealth(request.Uri);
                return new HealthCheckQueryResult { StatusCode = result, ErrorDescription = null };

            }
            catch (Exception ex)
            {
                return new HealthCheckQueryResult { StatusCode = null , ErrorDescription = ex.Message };
            }
        }
    }
}
