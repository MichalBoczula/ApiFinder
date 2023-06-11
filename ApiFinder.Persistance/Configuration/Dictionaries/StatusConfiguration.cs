using ApiFinder.Domain.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiFinder.Persistance.Configuration.Dictionaries
{
    internal class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.HasKey(k => k.Id);
            builder.HasIndex(k => k.Id);
            builder.Property(k => k.Name)
                .HasMaxLength(255);
        }
    }
}