using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1EFCore2.Modals
{
    public class Events
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaxAttendees { get; set; }
        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; }
        public int SessionId { get; set; }
        public Sessions Session { get; set; }
    }
}
