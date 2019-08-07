using System;
using System.Collections.Generic;
using System.Text;

namespace Sql.Database.Interface.Core
{
    public class Server : ServerExtensions
    {
        public string Host { get; set; }
        public string DatabaseName { get; set; }
       
    }

    public class ServerExtensions : SQLiteServerInformation
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class SQLiteServerInformation
    {
        public string SQLiteDatabaseLocation { get; set; }
    }
}
