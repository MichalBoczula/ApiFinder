using ApiFinder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFinder.Application.Features.Queries.GetApiInformationList
{
    public class GetApiInformationListQueryResult
    {
        public List<ApiInformation>? ApiInformationList { get; set; }
        public string? ErrorDescription { get; set; }
    }
}
