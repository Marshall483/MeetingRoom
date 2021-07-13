using DataAccess.Models;

namespace BusinessLogic.Abstract
{
    public interface IBookingService
    {
        void Book(Booking booking);
        void Edit(Booking booking);
        void SendReminder(Booking booking);
        void Cancel(Booking booking);
    }
}
