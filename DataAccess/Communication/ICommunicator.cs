using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Communication
{
    /* interface to communicate with database.
       There are all methods to make different interactions with data.
    */
    public interface ICommunicator
    {
        void AddRoom(MeetingRoom room);
        void EditRoom(MeetingRoom room);
        void DeleteRoom(int id);
        MeetingRoom GetRoom(int id);
        List<MeetingRoom> GetRooms();
        void AddBooking(Booking booking);
        void EditBooking(Booking booking);
        void DeleteBooking(int id);
        Booking GetBooking(int id);
        List<Booking> GetBookings();
        void AddTechnicalSupport(TechnicalSupport technic);
        void EditTechnicalSupport(TechnicalSupport technic);
        void DeleteTechnicalSupport(int id);
        TechnicalSupport GetTechnic(int id);
        List<TechnicalSupport> GetTechnics();     
    }
}
