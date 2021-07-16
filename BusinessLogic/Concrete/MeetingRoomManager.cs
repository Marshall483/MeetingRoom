using System.Collections.Generic;
using System.Linq;
using BusinessLogic.Abstract;
using BusinessLogic.Forms;
using DataAccess.Communication;
using DataAccess.Models;

namespace BusinessLogic.Concrete
{
    public class MeetingRoomManager//:IMeetingRoomService
    {
        private readonly ICommunicator _communicator;

        public MeetingRoomManager(ICommunicator communicator)
        {
            _communicator = communicator;
        }
        
        public IEnumerable<MeetingRoom> FindByConditions(FindMeetingRoomForm findMeetingRoomForm)
        {
            var meetingRooms = _communicator.GetRooms();
            
            if (findMeetingRoomForm.Dates != null)
            {
                meetingRooms = meetingRooms.Where(mr =>
                        mr.Dates.Intersect(findMeetingRoomForm.Dates).Count() == findMeetingRoomForm.Dates.Count)
                    .ToList();
            }

            if (findMeetingRoomForm.Locations != null)
            {
                meetingRooms = meetingRooms.Where(mr =>
                        findMeetingRoomForm.Locations.Contains(mr.Location))
                    .ToList();
            }

            if (findMeetingRoomForm.Names != null)
            {
                meetingRooms = meetingRooms.Where(mr =>
                        findMeetingRoomForm.Names.Contains(mr.Name))
                    .ToList();
            }
            
            if (findMeetingRoomForm.Capacities != null)
            {
                meetingRooms = meetingRooms.Where(mr =>
                        findMeetingRoomForm.Capacities.Contains(mr.Capacity))
                    .ToList();
            }
            
            if (findMeetingRoomForm.TechnicalSupports != null)
            {
                meetingRooms = meetingRooms.Where(mr =>
                        mr.TechnicalSupports.Intersect(findMeetingRoomForm.TechnicalSupports).Count() == findMeetingRoomForm.TechnicalSupports.Count)
                    .ToList();
            }

            return meetingRooms;
        }

        public MeetingRoom GetMeetingRoom(int roomId)
        {
            var meetingRoom = _communicator.GetRoomWithBooking(roomId);
            return meetingRoom;
        }
    }
}
