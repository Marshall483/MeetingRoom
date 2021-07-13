using System;
using System.Collections.Generic;

namespace BusinessLogic.Forms
{
    public class FindMeetingRoomForm
    {
        public List<DateTime> Dates { get; set; }
        public List<string> Locations { get; set; }
        public List<string> Names { get; set; }
        public List<int> Capacities { get; set; }
        public List<int> TechnicalSupports { get; set; }
    }
}
