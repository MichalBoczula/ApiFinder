using ApiFinder.Domain.Histories;

namespace ApiFinder.Domain.Entities
{
    public class ApiInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Enums.ServerType ServerType { get; set; }
        public string Url { get; set; }
        public Enums.Status Status { get; set; }
        public List<ApiInformationHistory>? ApiInformationHistoryList { get; set; }
    }
}
