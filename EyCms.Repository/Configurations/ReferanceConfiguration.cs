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
    public class ReferanceConfiguration : IEntityTypeConfiguration<Referance>
    {
        public void Configure(EntityTypeBuilder<Referance> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Image).IsRequired(false).HasColumnType("text");

        }
    }
}
