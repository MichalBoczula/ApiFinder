using ApiFinder.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiFinder.Persistance.Configuration.Entities
{
    internal class ApiInformationConfiguration : IEntityTypeConfiguration<ApiInformation>
    {
        public void Configure(EntityTypeBuilder<ApiInformation> builder)
        {
            builder.HasKey(k => k.Id);
            builder.HasIndex(k => k.Id);
            builder.Property(k => k.Name)
                .HasMaxLength(255);
            builder.HasIndex(x => x.ServerTypeId);
            builder.Property(k => k.Url)
                .HasMaxLength(255);
            builder.Property(k => k.StatusId);
        }
    }
}
