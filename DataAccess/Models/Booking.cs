using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Booking
    {
        //constructor
        public Booking(DateTime bookingStartTime, DateTime bookingEndTime, string name,
            string authorOfBooking)
        {
            BookingStartTime = bookingStartTime;
            BookingEndTime = bookingEndTime;
            Name = name;
            AuthorOfBooking = authorOfBooking;
        }

        public int Id { get; set; }
        public MeetingRoom MeetingRoom { get; set; }
        public DateTime BookingStartTime { get; set; }
        public DateTime BookingEndTime { get; set; }
        public string Name { get; set; }
        public string AuthorOfBooking { get; set; }
    }
}
