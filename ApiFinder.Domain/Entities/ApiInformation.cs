using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFinder.Domain.Entities
{
    internal class ApiInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ServerTypeId { get; set; }
        public string Url { get; set; }
        public int StatusId { get; set; }
    }
}
