using ApiFinder.Domain.Dictionaries;
using Microsoft.EntityFrameworkCore;

namespace ApiFinder.Persistance.Seed.Dictionaries
{
    internal static class StatusSeed
    {
        internal static void CreateStatusSeed(this ModelBuilder modelBuilder)
        {
            var online = new Status()
            {
                Id = 1,
                Name = "Online"
            };

            var offline = new Status()
            {
                Id = 2,
                Name = "Offline"
            };

            var notDefined = new Status()
            {
                Id = 3,
                Name = "Not defined"
            };

            modelBuilder.Entity<Status>()
                .HasData(online);
            modelBuilder.Entity<Status>()
                .HasData(offline);
            modelBuilder.Entity<Status>()
               .HasData(notDefined);
        }
    }
}
