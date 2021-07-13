using BusinessLogic.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MeetingRoom.Controllers
{
    [ApiController]
    public class BookingController:Controller
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        
    }
}
