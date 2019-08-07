using Sql.Database.Interface.Core.Core.Wrapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sql.Database.Interface.Core
{
    public class testimplementation
    {
        public Server s = new Server();

        public void Test()
        {
            
            var columns = new Columns();
            var q = new Queries();

            Tables.TableNames = new string[] { "test", "sets" } ;

            q.SelectAll(Tables.TableNames[1]);

            q.Delete(Tables.TableNames[1], "id", 1);
        }
    }
}
