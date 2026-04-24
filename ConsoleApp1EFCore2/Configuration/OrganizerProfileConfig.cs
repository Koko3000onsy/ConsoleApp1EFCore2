using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1EFCore2.Configuration
{
    public class OrganizerProfileConfig : IEntityTypeConfiguration<Modals.OrganizerProfile>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Modals.OrganizerProfile> builder)
        {
            builder.HasKey(op => op.OrganizerProfileId);
            builder.Property(op => op.Bio).HasMaxLength(500);
            builder.Property(op => op.Website).HasMaxLength(200);
            builder.Property(op => op.LogoUrl).HasMaxLength(200);
        }
    }
}
