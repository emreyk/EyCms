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
    public class SettingConfiguration : IEntityTypeConfiguration<Setting>
    {
        public void Configure(EntityTypeBuilder<Setting> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Keyword).HasMaxLength(100);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Descripton).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Email).HasMaxLength(100);
            builder.Property(x => x.Phone1).HasMaxLength(20);
            builder.Property(x => x.Phone2).HasMaxLength(20);
            builder.Property(x => x.Address).HasColumnType("text");
            builder.Property(x => x.Facebook).HasMaxLength(100);
            builder.Property(x => x.Twitter).HasMaxLength(100);
            builder.Property(x => x.Instagram).HasMaxLength(100);
            builder.Property(x => x.Youtube).HasMaxLength(100);
            builder.Property(x => x.Logo).IsRequired(false).HasColumnType("text");

        }
    }
}
