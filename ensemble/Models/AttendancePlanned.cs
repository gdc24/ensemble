namespace ensemble.Models
{
    class AttendancePlanned
    {
        public int IntAttendancePlannedID { get; set; }

        public RehearsalPart RehearsalPart { get; set; }

        public Member Member { get; set; }
    }
}