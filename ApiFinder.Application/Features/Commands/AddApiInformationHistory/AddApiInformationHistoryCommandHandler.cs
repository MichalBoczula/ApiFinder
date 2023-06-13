using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApiFinder.Application.Contracts;
using ApiFinder.Application.Features.Common;

using AutoMapper;

using MediatR;

namespace ApiFinder.Application.Features.Commands.AddApiInformationHistory
{
    public class AddApiInformationHistoryCommandHandler : CommandBase, IRequestHandler<AddApiInformationHistoryCommand, AddApiInformationHistoryCommandResult>
    {
        public AddApiInformationHistoryCommandHandler(IApiFinderContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public Task<AddApiInformationHistoryCommandResult> Handle(AddApiInformationHistoryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
