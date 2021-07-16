using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Communication
{
    // implementation of methods for accessing the database
    public class Communicator : ICommunicator
    {
        // database context
        private readonly ApplicationContext db;

        public Communicator(ApplicationContext db)
        {
            this.db = db;
        }

        //add new room
        public void AddRoom(MeetingRoom room)
        {
            db.MeetingRoom.Add(room);
            db.SaveChanges();
        }

        // update room
        public void EditRoom(MeetingRoom room)
        {
            db.MeetingRoom.Update(room);
            db.SaveChanges();
        }

        // delete room by it's id
        public void DeleteRoom(int id)
        {
            var room = db.MeetingRoom.Where(x => x.Id == id)
                .FirstOrDefault();
            db.MeetingRoom.Remove(room);
            db.SaveChanges();
        }

        // get room by id
        public MeetingRoom GetRoom(int id)
        {
            return db.MeetingRoom.Where(x => x.Id == id).FirstOrDefault();
        }
        
        public MeetingRoom GetRoomWithBooking(int id)
        {
            return db.MeetingRoom
                .Include(mr => mr.Bookings)
                .FirstOrDefault(x => x.Id == id);
        }

        // get list of rooms
        public List<MeetingRoom> GetRooms()
        {
            return db.MeetingRoom.ToList();
        }

        // add new booking
        public void AddBooking(Booking booking)
        {
            db.Booking.Add(booking);
            db.SaveChanges();
        }

        // update booking
        public void EditBooking(Booking booking)
        {
            db.Booking.Update(booking);
            db.SaveChanges();
        }

        // delete booking by id
        public void DeleteBooking(int id)
        {
            var booking = db.Booking.Where(x => x.Id == id)
                .FirstOrDefault();
            db.Booking.Remove(booking);
            db.SaveChanges();
        }

        // get booking by id
        public Booking GetBooking(int id)
        {
            return db.Booking.Where(x => x.Id == id).FirstOrDefault();
        }

        // get list of bookings
        public List<Booking> GetBookings()
        {
            return db.Booking.ToList();
        }

        // add new technic
        public void AddTechnicalSupport(TechnicalSupport technic)
        {
            db.TechnicalSupport.Add(technic);
            db.SaveChanges();
        }

        // update technic
        public void EditTechnicalSupport(TechnicalSupport technic)
        {
            db.TechnicalSupport.Update(technic);
            db.SaveChanges();
        }

        // delete technic by id
        public void DeleteTechnicalSupport(int id)
        {
            var technic = db.TechnicalSupport.Where(x => x.Id == id)
                .FirstOrDefault();
            db.TechnicalSupport.Remove(technic);
            db.SaveChanges();
        }

        // get technic by id
        public TechnicalSupport GetTechnic(int id)
        {
            return db.TechnicalSupport.Where(x => x.Id == id).FirstOrDefault();
        }

        // get list of technics
        public List<TechnicalSupport> GetTechnics()
        {
            return db.TechnicalSupport.ToList();
        }
    }
}
