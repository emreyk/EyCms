using EyCms.CORE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyCms.REPOSITORY.Configurations
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.SeoUrl).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Description).HasMaxLength(300);
            builder.Property(x => x.ShortText).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Text).IsRequired().HasColumnType("text");
            builder.Property(x => x.Image).IsRequired(false).HasColumnType("text");
        }
    }
}
