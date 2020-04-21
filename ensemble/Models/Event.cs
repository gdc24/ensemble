using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NodaTime;

using Foundation;
using UIKit;

namespace ensemble.Models
{
    class Event
    {
        public int IntEventID { get; set; }

        public string StrName { get; set; }

        //TODO make this a list for recurring events
        public DateTime DtmDate { get; set; }

        public string StrLocation { get; set; }

        public Group Group { get; set; }
    }
}