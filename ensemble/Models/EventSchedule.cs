using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using NodaTime;
using UIKit;

namespace ensemble.Models
{
    class EventSchedule
    {
        public int IntEventScheduleID { get; set; }

        public LocalTime TmeMondayStart { get; set; }

        public LocalTime TmeTuesdayStart { get; set; }

        public LocalTime TmeWednesdayStart { get; set; }

        public LocalTime TmeThursdayStart { get; set; }

        public LocalTime TmeFridayStart { get; set; }

        public LocalTime TmeSaturdayStart { get; set; }

        public LocalTime TmeSundayStart { get; set; }

        public Duration DurWeekdayDuration { get; set; }

        public Duration DurWeekendDuration { get; set; }

        public Event Event { get; set; }
    }
}