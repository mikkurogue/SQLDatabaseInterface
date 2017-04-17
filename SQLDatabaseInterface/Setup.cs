using System;

namespace SQLDatabaseInterface
{
    public class Setup
    {
        public Setup() { }

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

        /// <summary>
        /// Generate connection string to database
        /// </summary>
        /// <param name="host"></param>
        /// <param name="dbname"></param>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public string GenerateSQLConnection(string host, string dbname, string user, string pass)
        {
            host = Host;
            dbname = DatabaseName;
            user = Username;
            pass = Password;

            return $"Server={host};Database={dbname};Uid={user};Pwd={pass};";
        }
    }
}
