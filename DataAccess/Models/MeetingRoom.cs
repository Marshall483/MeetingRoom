using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class MeetingRoom
    {
        //constructor
        public MeetingRoom(List<DateTime> dates, string location, string name,
            int capacity, List<int> technicalSupports)
        {
            Dates = dates;
            Location = location;
            Name = name;
            Capacity = capacity;
            TechnicalSupports = technicalSupports;
        }

        public int Id { get; set; }
        public List<DateTime> Dates { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<int> TechnicalSupports { get; set; }
    }
}
