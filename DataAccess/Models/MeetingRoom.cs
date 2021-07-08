using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class MeetingRoom
    {
        public int Id { get; set; }
        public List<DateTime> Dates { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
    }
}
