using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace ensemble.Models
{
    class Conflict
    {
        public Conflict(int intConflictID, DateTime dtmStartDateTime, DateTime dtmEndDateTime, Member member)
        {
            IntConflictID = intConflictID;
            DtmStartDateTime = dtmStartDateTime;
            DtmEndDateTime = dtmEndDateTime;
            Member = member;
        }

        public int IntConflictID { get; set; }

        public DateTime DtmStartDateTime { get; set; }
        
        public DateTime DtmEndDateTime { get; set; }

        public Member Member { get; set; }


    }
}