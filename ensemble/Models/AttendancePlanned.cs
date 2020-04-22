namespace ensemble.Models
{
    class AttendancePlanned
    {
        public AttendancePlanned(int intAttendancePlannedID, RehearsalPart rehearsalPart, Member member)
        {
            IntAttendancePlannedID = intAttendancePlannedID;
            RehearsalPart = rehearsalPart;
            Member = member;
        }

        public int IntAttendancePlannedID { get; set; }

        public RehearsalPart RehearsalPart { get; set; }

        public Member Member { get; set; }
    }
}