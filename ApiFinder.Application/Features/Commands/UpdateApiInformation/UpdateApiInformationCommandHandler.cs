using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApiFinder.Application.Contracts;
using ApiFinder.Application.Features.Common;

using AutoMapper;

using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ApiFinder.Application.Features.Commands.UpdateApiInformation
{
    internal class UpdateApiInformationCommandHandler : CommandBase, IRequestHandler<UpdateApiInformationCommand, UpdateApiInformationCommandResult>
    {
        public UpdateApiInformationCommandHandler(IApiFinderContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<UpdateApiInformationCommandResult> Handle(UpdateApiInformationCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var api = await this._context.ApiInformations.FirstOrDefaultAsync(x => x.Id == request.ApiInformationId);
                api.Status = request.Status;

                this._context.ApiInformations.Update(api);
                var result = await this._context.SaveChangesAsync(cancellationToken);
                return new UpdateApiInformationCommandResult { CreatedApiInformationId = api.Id, ErrorDescription = null };
            }
            catch (Exception ex)
            {
                return new UpdateApiInformationCommandResult { CreatedApiInformationId = null, ErrorDescription = ex.Message };
            }
        }

    }
}
