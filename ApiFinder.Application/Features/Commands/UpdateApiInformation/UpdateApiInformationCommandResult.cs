﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFinder.Application.Features.Commands.UpdateApiInformation
{
    public class UpdateApiInformationCommandResult
    {
        public int? CreatedApiInformationId { get; set; }
        public string? ErrorDescription { get; set; }
    }
}
