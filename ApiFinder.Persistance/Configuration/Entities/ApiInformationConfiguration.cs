using ApiFinder.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiFinder.Persistance.Configuration.Entities
{
    internal class ApiInformationConfiguration : IEntityTypeConfiguration<ApiInformation>
    {
        public void Configure(EntityTypeBuilder<ApiInformation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.Name)
                .HasMaxLength(255);
            builder.Property(x => x.ServerType)
                .HasConversion<int>();
            builder.Property(x => x.Url)
                .HasMaxLength(255);
            builder.Property(x => x.Status)
                .HasConversion<int>();
        }
    }
}
