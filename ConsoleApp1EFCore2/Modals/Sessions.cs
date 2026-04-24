using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1EFCore2.Modals
{
    public class Sessions
    {
        public int SessionId { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public List<Events> Events { get; set; }
    }
}
