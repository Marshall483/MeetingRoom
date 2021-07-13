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
            _communicator.AddBooking(booking);
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
    }
}
