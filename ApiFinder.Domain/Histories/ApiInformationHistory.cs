using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFinder.Domain.Histories
{
    internal class ApiInformationHistory
    {
        public int Id { get; set; }
        public int ApiInformationId { get; set; }
        public int Name { get; set; }
        public int ServerTypeId { get; set; }
        public int Url { get; set; }
        public int StatusId { get; set; }
        public DateTime CheckingTime { get; set; }
        public string? ErrorDescription { get; set; }
    }
}
