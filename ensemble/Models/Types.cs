namespace ensemble.Models
{
    class Types
    {
        public Types(int intTypeID, string strName, Event paramEvent)
        {
            IntTypeID = intTypeID;
            StrName = strName;
            Event = paramEvent;
        }

        public int IntTypeID { get; set; }

        public string StrName { get; set; }

        public Event Event { get; set; }
    }
}