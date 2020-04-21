namespace ensemble.Models
{
    class Part
    {
        public int IntPartID { get; set; }

        public string StrRole { get; set; }

        public Member Member { get; set; }

        public Event Event { get; set; }
    }
}