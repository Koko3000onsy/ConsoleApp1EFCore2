using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1EFCore2.Modals
{
    public class Attendee
    {
        public int AttendeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public Badge Badge { get; set; }
    }
}
