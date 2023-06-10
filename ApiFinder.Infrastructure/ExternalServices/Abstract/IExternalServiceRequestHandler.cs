using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFinder.Infrastructure.ExternalServices.Abstract
{
    public interface IExternalServiceRequestHandler
    {
        Task<bool> CheckHealth(string url);
    }
}
