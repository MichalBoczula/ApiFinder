using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ApiFinder.Infrastructure.ExternalServices.Abstract
{
    public interface IExternalServiceRequestHandler
    {
        Task<HttpStatusCode> CheckHealth(string url);
    }
}
