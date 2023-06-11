using ApiFinder.Domain.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiFinder.Domain.Configuration.Dictionaries
{
    internal class ServerTypeConfiguration : IEntityTypeConfiguration<ServerType>
    {
        public void Configure(EntityTypeBuilder<ServerType> builder)
        {
            builder.HasKey(k => k.Id);
            builder.HasIndex(k => k.Id);
            builder.Property(k => k.Name)
                .HasMaxLength(255);
        }
    }
}