CREATE TABLE "groups" (
  "intGroupID" SERIAL PRIMARY KEY,
  "strName" varchar(255)
);

CREATE TABLE "events" (
  "intEventID" SERIAL PRIMARY KEY,
  "strName" varchar(255),
  "intDate" int,
  "strLocation" varchar(255),
  "intGroupID" int
);

CREATE TABLE "callboard" (
  "intCallboardID" SERIAL PRIMARY KEY,
  "strSubject" varchar(255),
  "strNote" varchar(255),
  "intDateTime" int,
  "intPostedByMemberID" int,
  "intEventID" int
);

CREATE TABLE "members" (
  "intMemberID" SERIAL PRIMARY KEY,
  "strName" varchar(255),
  "strNmail" varchar(255),
  "intPhone" int,
  "intEventID" int
);

CREATE TABLE "rehearsals" (
  "intRehearsalID" SERIAL PRIMARY KEY,
  "intStartDateTime" int,
  "intEndDateTime" int,
  "strLocation" varchar(255),
  "strNotes" varchar(255),
  "intEventID" int
);

CREATE TABLE "rehearsalparts" (
  "intRehearsalpartID" SERIAL PRIMARY KEY,
  "intStartTime" int,
  "intEndTime" int,
  "intRehearsalID" int,
  "intTypeID" int
);

CREATE TABLE "types" (
  "intTypeID" SERIAL PRIMARY KEY,
  "strName" varchar(255),
  "intEventID" int
);

CREATE TABLE "conflicts" (
  "intConflictID" SERIAL PRIMARY KEY,
  "intStartDateTime" int,
  "intEndDateTime" int,
  "intMemberID" int
);

CREATE TABLE "eventSchedule" (
  "intEventScheduleID" SERIAL PRIMARY KEY,
  "intMondayStart" int,
  "intTuesdayStart" int,
  "intWednesdayStart" int,
  "intThursdayStart" int,
  "intFridayStart" int,
  "intSaturdayStart" int,
  "intSundayStart" int,
  "intWeekdayDuration" int,
  "intWeekendDuration" int,
  "intEventID" int
);

CREATE TABLE "attendancePlanned" (
  "intAttendancePlannedID" SERIAL PRIMARY KEY,
  "intRehearsalpartID" int,
  "intMemberID" int
);

CREATE TABLE "attendanceActual" (
  "intAttendanceActualID" SERIAL PRIMARY KEY,
  "intInTime" int,
  "intOutTime" int,
  "ysnDidShow" bool,
  "intAttendancePlannedID" int
);

CREATE TABLE "tasks" (
  "intTaskID" SERIAL PRIMARY KEY,
  "intDueDate" int,
  "strName" varchar(255),
  "strAttachment" varchar(255),
  "intAssignedToMemberID" int,
  "intAssignedByMemberID" int,
  "intEventID" int
);

CREATE TABLE "parts" (
  "intPartID" SERIAL PRIMARY KEY,
  "strRole" varchar(255),
  "intMemberID" int,
  "intEventID" int
);

ALTER TABLE "events" ADD FOREIGN KEY ("intGroupID") REFERENCES "groups" ("intGroupID");

ALTER TABLE "callboard" ADD FOREIGN KEY ("intPostedByMemberID") REFERENCES "members" ("intMemberID");

ALTER TABLE "callboard" ADD FOREIGN KEY ("intEventID") REFERENCES "events" ("intEventID");

ALTER TABLE "members" ADD FOREIGN KEY ("intEventID") REFERENCES "events" ("intEventID");

ALTER TABLE "rehearsals" ADD FOREIGN KEY ("intEventID") REFERENCES "events" ("intEventID");

ALTER TABLE "rehearsalparts" ADD FOREIGN KEY ("intRehearsalID") REFERENCES "rehearsals" ("intRehearsalID");

ALTER TABLE "rehearsalparts" ADD FOREIGN KEY ("intTypeID") REFERENCES "types" ("intTypeID");

ALTER TABLE "types" ADD FOREIGN KEY ("intEventID") REFERENCES "events" ("intEventID");

ALTER TABLE "conflicts" ADD FOREIGN KEY ("intMemberID") REFERENCES "members" ("intMemberID");

ALTER TABLE "eventSchedule" ADD FOREIGN KEY ("intEventID") REFERENCES "events" ("intEventID");

ALTER TABLE "attendancePlanned" ADD FOREIGN KEY ("intRehearsalpartID") REFERENCES "rehearsalparts" ("intRehearsalpartID");

ALTER TABLE "attendancePlanned" ADD FOREIGN KEY ("intMemberID") REFERENCES "members" ("intMemberID");

ALTER TABLE "attendanceActual" ADD FOREIGN KEY ("intAttendancePlannedID") REFERENCES "attendancePlanned" ("intAttendancePlannedID");

ALTER TABLE "tasks" ADD FOREIGN KEY ("intAssignedToMemberID") REFERENCES "members" ("intMemberID");

ALTER TABLE "tasks" ADD FOREIGN KEY ("intAssignedByMemberID") REFERENCES "members" ("intMemberID");

ALTER TABLE "tasks" ADD FOREIGN KEY ("intEventID") REFERENCES "events" ("intEventID");

ALTER TABLE "parts" ADD FOREIGN KEY ("intMemberID") REFERENCES "members" ("intMemberID");

ALTER TABLE "parts" ADD FOREIGN KEY ("intEventID") REFERENCES "events" ("intEventID");
