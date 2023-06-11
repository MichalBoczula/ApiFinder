using ApiFinder.Domain.Dictionaries;
using Microsoft.EntityFrameworkCore;

namespace ApiFinder.Persistance.Seed.Dictionaries
{
    internal static class ServerTypeSeed
    {
        internal static void CreateServerTypsSeed(this ModelBuilder modelBuilder)
        {
            var testServer = new ServerType()
            {
                Id = 1,
                Name = "Test"
            };

            var productionServer = new ServerType()
            {
                Id = 2,
                Name = "Production"
            };

            modelBuilder.Entity<ServerType>()
                .HasData(testServer);
            modelBuilder.Entity<ServerType>()
                .HasData(productionServer);
        }
    }
}
