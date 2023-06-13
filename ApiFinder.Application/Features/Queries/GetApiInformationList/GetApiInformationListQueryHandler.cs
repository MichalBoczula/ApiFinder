using ApiFinder.Application.Contracts;
using ApiFinder.Application.Features.Common;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ApiFinder.Application.Features.Queries.GetApiInformationList
{
    public class GetApiInformationListQueryHandler : QueryBase, IRequestHandler<GetApiInformationListQuery, GetApiInformationListQueryResult>
    {
        public GetApiInformationListQueryHandler(IApiFinderContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<GetApiInformationListQueryResult> Handle(GetApiInformationListQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await this._context.ApiInformations.ToListAsync();
                return new GetApiInformationListQueryResult { ApiInformationList = result, ErrorDescription = null };
            }
            catch (Exception ex)
            {
                return new GetApiInformationListQueryResult { ApiInformationList = null, ErrorDescription = ex.Message };
            }
        }
    }
}
