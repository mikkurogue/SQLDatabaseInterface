using System;
using System.Collections.Generic;
using System.Text;

namespace SQLDatabaseInterface.Core
{
    public class Queries
    {
        public Queries() { }

        /// <summary>
        /// Insert Data into database
        /// </summary>
        /// <param name="tables"></param>
        /// <param name="columns"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public string Insert(string table, string[] columns, string[] values)
        {
            string a = "NULL";
            string b = "NULL";

            foreach (var i in columns)
            {
                a = i.ToString();
                a += ", " + i.ToString();
            }

            foreach(var j in columns)
            {
                b = "'" + j.ToString() + "'";
                b += ", '" + j.ToString() + "',";
            }

            string Insert = $"INSERT INTO {table} ({a}) VALUES ({b})";

            return Insert;
        }

        /// <summary>
        /// Select all data from the table
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public string SelectAll(string table)
        {
            return $"SELECT * FROM {table}";
        }

        /// <summary>
        /// Select data from certain columns
        /// </summary>
        /// <param name="table"></param>
        /// <param name="columns"></param>
        /// <returns></returns>
        public string SelectCertainDataFromTable(string table, string[] columns)
        {
            string a = "NULL";

            foreach (var i in columns)
            {
                a = i.ToString();
                a += ", " + i.ToString();
            }

            string Select = $"SELECT {a} FROM {table}";

            return Select;
        }

        /// <summary>
        /// Delete data from table. Need the ID column (Primary Key usually) and the ID you want to remove.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="idcolumn"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Delete(string table, string idcolumn, int id)
        {
            return $"DELETE FROM {table} WHERE {idcolumn} = '{id}'";
        }
    }
}
