using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace ensemble.Models
{
    class Rehearsal
    {
        public int IntRehearsalID { get; set; }

        public DateTime DtmStartDateTime { get; set; }

        public DateTime DtmEndDateTime { get; set; }

        public string StrLocation { get; set; }

        public string StrNotes { get; set; }

        public Event Event { get; set; }
    }
}