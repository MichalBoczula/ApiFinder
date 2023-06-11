using ApiFinder.Domain.Entities;

namespace ApiFinder.Domain.Histories
{
    public class ApiInformationHistory
    {
        public int Id { get; set; }
        public int ApiInformationId { get; set; }
        public ApiInformation ApiInformationRef { get; set; }
        public string Name { get; set; }
        public int ServerTypeId { get; set; }
        public string Url { get; set; }
        public int StatusId { get; set; }
        public DateTime CheckingTime { get; set; }
        public string? ErrorDescription { get; set; }
    }
}
