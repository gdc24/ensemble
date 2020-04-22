
using System;

namespace ensemble.Models
{
    class RehearsalPart
    {
        public RehearsalPart(int intRehearsalPartID, DateTime dtmStartDateTime, DateTime dtmEndDateTime, Rehearsal rehearsal, Types type)
        {
            IntRehearsalPartID = intRehearsalPartID;
            DtmStartDateTime = dtmStartDateTime;
            DtmEndDateTime = dtmEndDateTime;
            Rehearsal = rehearsal;
            Type = type;
        }

        public int IntRehearsalPartID { get; set; }
        
        public DateTime DtmStartDateTime { get; set; }

        public DateTime DtmEndDateTime { get; set }

        public Rehearsal Rehearsal { get; set; }

        public Types Type { get; set; }
    }
}