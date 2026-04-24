using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1EFCore2.Configuration
{
    public class EventConfig : IEntityTypeConfiguration<Modals.Events>

    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Modals.Events> builder)
        {
            builder.HasKey(e => e.EventId);
            builder.Property(e => e.Title).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Description).HasMaxLength(200);
            builder.Property(e => e.StartDate).IsRequired();
            builder.HasOne(e=>e.Organizer)
                   .WithMany(o => o.Events)
                   .HasForeignKey(e => e.OrganizerId)
                   .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.Session)
                   .WithMany(s => s.Events)
                   .HasForeignKey(e => e.SessionId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
