using ApiFinder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFinder.Domain.Histories
{
    public class ApiInformationHistory
    {
        public int Id { get; set; }
        public int ApiInformationId { get; set; }
        public ApiInformation ApiInformationRef { get; set; }
        public int Name { get; set; }
        public int ServerTypeId { get; set; }
        public int Url { get; set; }
        public int StatusId { get; set; }
        public DateTime CheckingTime { get; set; }
        public string? ErrorDescription { get; set; }
    }
}
