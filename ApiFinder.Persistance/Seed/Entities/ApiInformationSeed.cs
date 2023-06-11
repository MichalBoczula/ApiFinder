using ApiFinder.Domain.Dictionaries;
using ApiFinder.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiFinder.Persistance.Seed.Entities
{
    internal static class ApiInformationSeed
    {
        internal static void CreateApiInformationSeed(this ModelBuilder modelBuilder)
        {
            var testServer = new ApiInformation()
            {
                Id = 1,
                Name = "Address",
                ServerType = Domain.Enums.ServerType.Test,
                Url = "test",
                Status = Domain.Enums.Status.NotDefined

            };

            var productionServer = new ApiInformation()
            {
                Id = 2,
                Name = "Address",
                ServerType = Domain.Enums.ServerType.Production,
                Url = "prod",
                Status = Domain.Enums.Status.NotDefined
            };

            modelBuilder.Entity<ApiInformation>()
                .HasData(testServer);
            modelBuilder.Entity<ApiInformation>()
                .HasData(productionServer);
        }
    }
}