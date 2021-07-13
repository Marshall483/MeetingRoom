using System.Collections.Generic;
using BusinessLogic.Forms;
using DataAccess.Models;

namespace BusinessLogic.Abstract
{
    public interface IMeetingRoomService
    {
        IEnumerable<MeetingRoom> Find(FindMeetingRoomForm findMeetingRoomForm);
    }
}
