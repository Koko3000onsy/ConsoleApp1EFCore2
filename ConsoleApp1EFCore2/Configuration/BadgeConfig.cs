using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1EFCore2.Configuration
{
    public class BadgeConfig :IEntityTypeConfiguration<Modals.Badge>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Modals.Badge> builder)
        {
            builder.HasKey(b => b.BadgeId);
            builder.Property(b => b.BadgeNumber).IsRequired().HasMaxLength(50);
            builder.Property(b => b.IssuedDate).IsRequired();
            builder.Property(b => b.Tier).HasMaxLength(20);
        }
    }
}
