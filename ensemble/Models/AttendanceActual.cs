﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace ensemble.Models
{
    class AttendanceActual
    {
        public AttendanceActual(int intAttendanceActualID, DateTime dtmInTime, DateTime dtmOutTime, bool ysnDidShow, AttendancePlanned attendancePlanned)
        {
            IntAttendanceActualID = intAttendanceActualID;
            DtmInTime = dtmInTime;
            DtmOutTime = dtmOutTime;
            YsnDidShow = ysnDidShow;
            AttendancePlanned = attendancePlanned;
        }

        public int IntAttendanceActualID { get; set; }

        public DateTime DtmInTime {get; set; }

        public DateTime DtmOutTime { get; set; }

        public bool YsnDidShow { get; set; }

        public AttendancePlanned AttendancePlanned { get; set; }
    }
}