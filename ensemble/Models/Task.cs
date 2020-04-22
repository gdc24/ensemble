using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace ensemble.Models
{
    class Task
    {

        public Task(int intTaskID, DateTime dtmDue, string strName, string strAttachment, Member memberAssignedTo, Member memberAssignedBy, Event paramEvent)
        {
            IntTaskID = intTaskID;
            DtmDue = dtmDue;
            StrName = strName;
            StrAttachment = strAttachment;
            MemberAssignedTo = memberAssignedTo;
            MemberAssignedBy = memberAssignedBy;
            Event = paramEvent;
        }

        public int IntTaskID { get; set; }

        public DateTime DtmDue { get; set; }

        public string StrName { get; set; }

        public string StrAttachment { get; set; }

        public Member MemberAssignedTo { get; set; }

        public Member MemberAssignedBy { get; set; }

        public Event Event { get; set; }

    }
}