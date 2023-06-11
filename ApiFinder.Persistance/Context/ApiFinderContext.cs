using ApiFinder.Domain.Entities;
using ApiFinder.Domain.Histories;
using ApiFinder.Persistance.Seed.Dictionaries;
using ApiFinder.Persistance.Seed.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace ApiFinder.Persistance.Context
{
    internal class ApiFinderContext : DbContext
    {
        public DbSet<ApiInformation> ApiInformations { get; set; }
        public DbSet<ApiInformationHistory> ApiInformationHistoryList { get; set; }

        public ApiFinderContext([NotNull] DbContextOptions<ApiFinderContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.CreateServerTypsSeed();
            modelBuilder.CreateStatusSeed();
            modelBuilder.CreateApiInformationSeed();
        }
    }
}
