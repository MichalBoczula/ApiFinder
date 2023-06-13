using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;

namespace ApiFinder.Application.Features.Queries.GetApiInformationList
{
    internal class GetApiInformationListQuery : IRequest<GetApiInformationListQueryResult>
    {
    }
}
