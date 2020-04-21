using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace ensemble.Models
{
    class Callboard
    {
        public int IntCallboardID { get; set; }

        public string StrSubject { get; set; }

        public string StrNote { get; set; }

        public DateTime DtmDateTime { get; set; }

        public Member PostedByMember { get; set; }

        public Event Event { get; set; }
    }
}