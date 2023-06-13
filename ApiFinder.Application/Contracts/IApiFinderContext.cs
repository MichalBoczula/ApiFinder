using ApiFinder.Domain.Entities;
using ApiFinder.Domain.Histories;
using Microsoft.EntityFrameworkCore;

namespace ApiFinder.Application.Contracts
{
    public interface IApiFinderContext
    {
        DbSet<ApiInformation> ApiInformations { get; set; }
        DbSet<ApiInformationHistory> ApiInformationHistoryList { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
