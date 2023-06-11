using ApiFinder.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiFinder.Domain.Histories;

namespace ApiFinder.Persistance.Configuration.Histories
{
    internal class ApiInformationHistoryConfiguration : IEntityTypeConfiguration<ApiInformationHistory>
    {
        public void Configure(EntityTypeBuilder<ApiInformationHistory> builder)
        {
            builder.HasKey(k => k.Id);
            builder.HasIndex(k => k.Id);
            builder.Property(k => k.Name)
                .HasMaxLength(255);
            builder.HasIndex(x => x.ServerTypeId);
            builder.Property(k => k.Url)
                .HasMaxLength(255);
            builder.Property(k => k.StatusId);
            builder.Property(k => k.ErrorDescription)
                .HasMaxLength(1000);
            builder.HasOne(x => x.ApiInformationRef)
                .WithMany(x => x.ApiInformationHistoryList)
                .HasForeignKey(x => x.ApiInformationId);
        }
    }
}
