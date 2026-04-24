using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1EFCore2
{
    internal class AppDBContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=EFCore2;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<Modals.Attendee> Attendees { get; set; }
        public DbSet<Modals.Badge> Badges { get; set; }
        public DbSet<Modals.Events> Events { get; set; }
        public DbSet<Modals.Sessions> Sessions { get; set; }
        public DbSet<Modals.Organizer> Organizers { get; set; }
        public DbSet<Modals.OrganizerProfile> OrganizerProfiles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
