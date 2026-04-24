using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1EFCore2.Modals
{
    public class Organizer
    {
       
        public int Id { get; set; }
        
        public string Name { get; set; }
        public bool Applicable { get; set; }
        public string? CompanyName { get; set; }
        public OrganizerProfile organizerprofile { get; set; }
        public List<Events> Events { get; set; } 
    }
}
