using ApiFinder.Application.Contracts;
using AutoMapper;

namespace ApiFinder.Application.Features.Common
{
    internal class QueryBase
    {
        protected readonly IApiFinderContext _context;
        protected readonly IMapper _mapper;

        public QueryBase(IApiFinderContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
