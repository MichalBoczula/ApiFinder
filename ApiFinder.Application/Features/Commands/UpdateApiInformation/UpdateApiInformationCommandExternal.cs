using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFinder.Application.Features.Commands.UpdateApiInformation
{
    public class UpdateApiInformationCommandExternal
    {
        public int ApiInformationId { get; set; }
        public Domain.Enums.Status Status { get; set; }
    }
}
