namespace ensemble.Models
{
    class Member
    {
        public int IntMemberID { get; set; }

        public string StrName { get; set; }

        public string StrEmail { get; set; }

        public int IntPhone { get; set; }

        public Event Event { get; set; }
    }
}