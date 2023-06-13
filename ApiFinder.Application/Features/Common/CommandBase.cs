using ApiFinder.Application.Contracts;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFinder.Application.Features.Common
{
    public class CommandBase
    {
        protected readonly IApiFinderContext _context;
        protected readonly IMapper _mapper;

        public CommandBase(IApiFinderContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
