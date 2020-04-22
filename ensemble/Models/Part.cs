namespace ensemble.Models
{
    class Part
    {
        public Part(int intPartID, string strRole, Member member, Event paramEvent)
        {
            IntPartID = intPartID;
            StrRole = strRole;
            Member = member;
            Event = paramEvent;
        }

        public int IntPartID { get; set; }

        public string StrRole { get; set; }

        public Member Member { get; set; }

        public Event Event { get; set; }
    }
}