using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1EFCore2.Configuration
{
    public class OrganizerConfig : IEntityTypeConfiguration<Modals.Organizer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Modals.Organizer> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Name).IsRequired().HasMaxLength(100);
            builder.HasOne(o => o.organizerprofile)
                   .WithOne(op => op.Organizer)
                   .HasForeignKey<Modals.OrganizerProfile>(op => op.OrganizerId)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }    
}
