using ApiFinder.Application.Contracts;
using ApiFinder.Application.Features.Common;
using AutoMapper;
using MediatR;

namespace ApiFinder.Application.Features.Queries.GetApiInformationList
{
    internal class GetApiInformationListQueryHandler : QueryBase, IRequestHandler<GetApiInformationListQuery, GetApiInformationListQueryResult>
    {
        public GetApiInformationListQueryHandler(IApiFinderContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public Task<GetApiInformationListQueryResult> Handle(GetApiInformationListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
