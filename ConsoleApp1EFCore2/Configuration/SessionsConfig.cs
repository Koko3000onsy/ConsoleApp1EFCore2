using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1EFCore2.Configuration
{
    public class SessionsConfig : IEntityTypeConfiguration<Modals.Sessions>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Modals.Sessions> builder)
        {
            builder.HasKey(s => s.SessionId);
            builder.Property(s => s.Title).IsRequired().HasMaxLength(100);
            

        }
    }
}
