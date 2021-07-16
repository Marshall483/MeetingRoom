using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic.Abstract;
using DataAccess.Communication;
using DataAccess.Models;

namespace BusinessLogic.Concrete
{
    public class BookingManager:IBookingService
    {
        private readonly ICommunicator _communicator;

        public BookingManager(ICommunicator communicator)
        {
            _communicator = communicator;
        }

        public void Book(Booking booking)
        {
            var bookingIsPossible = BookingIsPossible(booking);
            if (bookingIsPossible)
            {
                _communicator.AddBooking(booking);
            }
        }

        public void Edit(Booking booking)
        {
            _communicator.EditBooking(booking);
        }

        public void SendReminder(Booking booking)
        {
            throw new System.NotImplementedException();
        }

        public void Cancel(Booking booking)
        {
            _communicator.DeleteBooking(booking.Id);
        }

        private bool BookingIsPossible(Booking booking)
        {
            if (booking.MeetingRoom is null || !booking.MeetingRoom.IsAvailable)
            {
                return false;
            }
            var allBooking = _communicator.GetBookings()
                .Where(b => b.MeetingRoom.Id == booking.MeetingRoom.Id &&
                            b.BookingStartTime == booking.BookingStartTime);
            
            return allBooking.All(curBooking => 
                booking.BookingStartTime > curBooking.BookingEndTime || 
                booking.BookingEndTime < curBooking.BookingStartTime
                );
        }
    }
}
