using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ensemble.Models;
using Foundation;
using Npgsql;
using UIKit;

namespace ensemble.Database
{
    class InsertDAL
    {
        // global connection used to run all queries
        NpgsqlConnection conn;

        public InsertDAL()
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


        public bool InsertGroup(Group group)
        {
            //TODO
        }

        public bool InsertEvent(Event paramEvent)
        {
            //TODO
        }

        public bool InsertCallboard(Callboard callboard)
        {
            //TODO
        }

        public bool InsertMember(Member member)
        {
            //TODO
        }

        public bool InsertConflict(Conflict conflict)
        {
            //TODO
        }

        public bool InsertTask(Task task)
        {
            //TODO
        }

        public bool InsertRehearsal(Rehearsal rehearsal)
        {
            //TODO
        }

        public bool InsertRehearsalPart(RehearsalPart rehearsalPart)
        {
            //TODO
        }

        public bool InsertAttendancePlanned(AttendancePlanned attendancePlanned)
        {
            //TODO
        }

        public bool InsertAttendanceActual(AttendanceActual attendanceActual)
        {
            //TODO
        }

        public bool InsertType(Type type)
        {
            //TODO
        }

        public bool InsertEventSchedule(EventSchedule eventSchedule)
        {
            //TODO
        }

        public bool InsertPart(Part part)
        {
            //TODO
        }


    }
}