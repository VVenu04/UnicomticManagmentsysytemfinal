using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomticManagmentsysytem.Models
{
    internal class Timetable
    {
        public int TimetableID { get; set; }
        public string SubjectID { get; set; }
        public string TimeSlot { get; set; }
        public string RoomID { get; set; }
    }
}
