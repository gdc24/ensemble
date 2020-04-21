
using System;

namespace ensemble.Models
{
    class RehearsalPart
    {
        public int IntRehearsalPartID { get; set; }
        
        public DateTime DtmStartDateTime { get; set; }

        public DateTime DtmEndDateTime { get; set }

        public Rehearsal Rehearsal { get; set; }

        public Types Type { get; set; }
    }
}