using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFinder.Application.Features.Commands.UpdateApiInformation
{
    internal class UpdateApiInformationCommand : IRequest<UpdateApiInformationCommandResult>
    {
        public int ApiInformation { get; set; }
    }
}
