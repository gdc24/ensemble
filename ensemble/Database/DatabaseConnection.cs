using System;
using Npgsql;

namespace ensemble
{
    public class DatabaseConnection
    {
        public static readonly string SERVER = "";
        public static readonly string USER = "";
        public static readonly string DATABASE = "";
        public static readonly string PASS = "";

        public static NpgsqlConnection GetConnection()
        {
            NpgsqlConnection conn = new NpgsqlConnection("" +
                "Server=" + SERVER + ";" +
                "User Id=" + USER + ";" +
                "Password=" + PASS + ";" +
                "Database=" + DATABASE + ";");

            return conn;
        }

    }
}
