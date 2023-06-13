using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApiFinder.Application.Contracts;
using ApiFinder.Application.Features.Common;

using AutoMapper;

using MediatR;

namespace ApiFinder.Application.Features.Commands.UpdateApiInformation
{
    internal class UpdateApiInformationCommandHandler : CommandBase, IRequestHandler<UpdateApiInformationCommand, UpdateApiInformationCommandResult>
    {
        public UpdateApiInformationCommandHandler(IApiFinderContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public Task<UpdateApiInformationCommandResult> Handle(UpdateApiInformationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
