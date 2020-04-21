using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ensemble.Models;
using Foundation;
using NodaTime;
using Npgsql;
using UIKit;

namespace ensemble.Database
{
    class GetDAL
    {
        // global connection used to run all queries
        NpgsqlConnection conn;

        public GetDAL()
        {
            OpenConnection();
        }

        public void OpenConnection()
        {
            conn = DatabaseConnection.GetConnection();
            conn.Open();
        }

        public void CloseConnection()
        {
            conn.Close();
        }

        
        
        #region GET FROM DATAREADERS

        private Group GetGroupFromDR(NpgsqlDataReader dr)
        {
            //TODO
        }

        private Event GetEventFromDR(NpgsqlDataReader dr)
        {
            //TODO
        }

        private Callboard GetCallboardFromDR(NpgsqlDataReader dr)
        {
            //TODO
        }

        private Member GetMemberFromDR(NpgsqlDataReader dr)
        {
            //TODO
        }

        private Rehearsal GetRehearsalFromDR(NpgsqlDataReader dr)
        {
            //TODO
        }

        private RehearsalPart GetRehearsalPartFromDR(NpgsqlDataReader dr)
        {
            //TODO
        }

        private Conflict GetConflictFromDR(NpgsqlDataReader dr)
        {
            //TODO
        }

        private AttendancePlanned GetAttendancePlannedFromDR(NpgsqlDataReader dr)
        {
            //TODO
        }

        private AttendanceActual GetAttendanceActualFromDR(NpgsqlDataReader dr)
        {
            //TODO
        }

        private Types GetTypesFromDR(NpgsqlDataReader dr)
        {
            //TODO
        }

        private Task GetTaskFromDR(NpgsqlDataReader dr)
        {
            //TODO
        }

        private EventSchedule GetEventScheduleFromDR(NpgsqlDataReader dr)
        {
            //TODO
        }

        private Part GetPartFromDR(NpgsqlDataReader dr)
        {
            //TODO
        }

        #endregion

        #region GET SINGLE ITEMS BY ID

        public Group GetGroupByID(int intGroupID)
        {
            //TODO
        }

        public Event GetEventByID(int intEventID)
        {
            //TODO
        }

        public Callboard GetCallboardByID(int intCallboardID)
        {
            //TODO
        }

        public Member GetMemberByID(int intMemberID)
        {
            //TODO
        }

        public Rehearsal GetRehearsalByID(int intRehearsalID)
        {
            //TODO
        }

        public RehearsalPart GetRehearsalPartByID(int intRehearsalPartID)
        {
            //TODO
        }

        public Conflict GetConflictByID(int intConflictID)
        {
            //TODO
        }

        public AttendancePlanned GetAttendancePlannedByID(int intAttendancePlannedID)
        {
            //TODO
        }

        public AttendanceActual GetAttendanceActualByID(int intAttendanceActualID)
        {
            //TODO
        }

        public Types GetTypesByID(int intTypeID)
        {
            //TODO
        }

        public Task GetTaskByID(int intTaskID)
        {
            //TODO
        }

        public EventSchedule GetEventScheduleByID(int intEventScheduleID)
        {
            //TODO
        }

        public Part GetPartByID(int intPartID)
        {
            //TODO
        }

        #endregion


        #region GET LISTS

        public List<Group> GetAllGroups()
        {
            //TODO
        }

        public List<Event> GetEventsByGroup(Group group)
        {
            //TODO
        }

        public List<Callboard> GetCallboardsByEvent(Event paramEvent)
        {
            //TODO
        }

        public List<Callboard> GetCallboardsByPostedByMember(Member member)
        {
            //TODO
        }

        public List<Member> GetAllMembers()
        {
            //TODO
        }

        public List<Member> GetMembersByEvent(Event paramEvent)
        {
            //TODO
        }

        public List<Rehearsal> GetRehearsalsByEvent(Event paramEvent)
        {
            //TODO
        }

        public List<RehearsalPart> GetRehearsalPartsByRehearsal(Rehearsal rehearsal)
        {
            //TODO
        }

        public List<RehearsalPart> GetRehearsalPartsByEvent(Event paramEvent)
        {
            //TODO
        }

        public List<RehearsalPart> GetRehearsalPartsByEventAndType(Event paramEvent, Types type)
        {
            //TODO
        }

        public List<AttendancePlanned> GetAttendancePlannedByMember(Member member)
        {
            //TODO
        }

        public List<AttendancePlanned> GetAttendancePlannedByRehearsalPart(RehearsalPart rehearsalPart)
        {
            //TODO
        }

        public List<Types> GetAllTypes()
        {
            //TODO
        }


        // get a list of the attendance for a planned rehearsal part
        public List<AttendanceActual> GetAttendanceActualByPlanned(AttendancePlanned attendancePlanned)
        {
            //TODO
        }

        // get a list of the attendance for a given member
        public List<AttendanceActual> GetAttendanceActualByMember(Member member)
        {
            //TODO
        }

        // get a list of attendance for a rehearsal part (kinda same as GetAttendanceActualByPlanned but further abstracted up)
        public List<AttendanceActual> GetAttendanceActualByRehearsalPart(RehearsalPart rehearsalPart)
        {
            //TODO
        }

        // get a list of attendance for a whole rehearsal
        public List<AttendanceActual> GetAttendanceActualByRehearsal(Rehearsal rehearsal)
        {
            //TODO
        }

        public List<Conflict> GetConflictsByMember(Member member)
        {
            //TODO
        }

        public List<Conflict> GetConflictsByMemberAndDay(Member member, LocalDate date)
        {
            //TODO
        }

        public List<Conflict> GetConflictsByDay(LocalDate date)
        {
            //TODO
        }

        public List<Task> GetTasksByAssignedToMember(Member member)
        {
            //TODO
        }
        
        public List<Task> GetTasksByAssignedByMember(Member member)
        {
            //TODO
        }

        public List<Task> GetTasksByEvent(Event paramEvent)
        {
            //TODO
        }

        // get a list of tasks assigned to a user after a certain time
        public List<Task> GetTasksDueAfter(Member member, DateTime dateTime)
        {
            //TODO
        }

        public List<Task> GetTasksByEventAndMember(Member member, Event paramEvent)
        {
            //TODO
        }


        public List<Part> GetPartsByMember(Member member)
        {
            //TODO
        }

        public List<Part> GetPartsByEvent(Event paramEvent)
        {
            //TODO
        }

        #endregion

        #region MISC GETS

        #endregion



    }
}