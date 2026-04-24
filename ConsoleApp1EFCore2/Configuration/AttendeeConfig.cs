using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1EFCore2.Configuration
{
    public class AttendeeConfig : IEntityTypeConfiguration<Modals.Attendee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Modals.Attendee> builder)
        {
            builder.HasKey(a => a.AttendeeId);
            builder.Property(a => a.Name).IsRequired().HasMaxLength(100);
            builder.Property(a => a.Email).IsRequired().HasMaxLength(100);
            builder.Property(a => a.HomeAddress).HasMaxLength(200);
            builder.HasOne(a=> a.Badge)
                   .WithOne(b => b.Attendee)
                   .HasForeignKey<Modals.Badge>(b => b.AttendeeId);
        }
    }
}
