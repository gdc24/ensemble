﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace ensemble.Models
{
    class Rehearsal
    {
        public Rehearsal(int intRehearsalID, DateTime dtmStartDateTime, DateTime dtmEndDateTime, string strLocation, string strNotes, Event paramEvent)
        {
            IntRehearsalID = intRehearsalID;
            DtmStartDateTime = dtmStartDateTime;
            DtmEndDateTime = dtmEndDateTime;
            StrLocation = strLocation;
            StrNotes = strNotes;
            Event = paramEvent;
        }

        public int IntRehearsalID { get; set; }

        public DateTime DtmStartDateTime { get; set; }

        public DateTime DtmEndDateTime { get; set; }

        public string StrLocation { get; set; }

        public string StrNotes { get; set; }

        public Event Event { get; set; }
    }
}