using System;

namespace SQLDatabaseInterface
{
    public class Server
    {
        public Server() { }

        /// <summary>
        /// Host name for connection
        /// </summary>
        public string Host { get; set; }
        /// <summary>
        /// Database name for connection
        /// </summary>
        public string DatabaseName { get; set; }
        /// <summary>
        /// Username for connection to MySQL server
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Password for connection to MySQL server
        /// </summary>
        public string Password { get; set; }

        public string SQLiteDatabaseLocation { get; set; }

        /// <summary>
        /// Generate connection string to database (MYSQL)
        /// </summary>
        /// <param name="host"></param>
        /// <param name="dbname"></param>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public string GenerateSQLConnection(string host, string dbname, string user, string pass)
        {
            Host = host;
            DatabaseName = dbname;
            Username = user;
            Password = pass;

            return $"Server={Host};Database={DatabaseName};Uid={Username};Pwd={Password};";
        }

        /// <summary>
        /// Generate connection string to database (SQLITE)
        /// </summary>
        /// <param name="dbname"></param>
        /// <returns></returns>
        public string GenerateSQLiteConnection(string dbname)
        {
            DatabaseName = dbname;

            return $"Data Source={DatabaseName};Version=3;";
        }
    }
}
