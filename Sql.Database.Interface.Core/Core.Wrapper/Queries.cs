using System;
using System.Collections.Generic;
using System.Text;

namespace Sql.Database.Interface.Core.Core.Wrapper
{
    public class Queries
    {
        public Queries() { }

        /// <summary>
        /// Insert data into specific table
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columns"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public string Insert(Tables tableName, Columns[] columns, string[] values)
        {
            string cols = "NULL";
            string vals = "NULL";

            foreach (var item in columns)
            {
                cols = item.ToString();
                cols += ", " + item.ToString();
            }

            foreach (var item in values)
            {
                vals = $"'{item.ToString()}'";
                vals += $", {item.ToString()}'"; 
            }

            string Insert = $"INSERT INTO {tableName} ({cols}) VALUES ({vals})";
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
        public string SelectCertainDataFromTable(string table, Columns[] columns)
        {
            string val = "NULL";

            foreach (var item in columns)
            {
                val = item.ToString();
                val += ", " + item.ToString();
            }

            string Select = $"SELECT {val} FROM {table}";

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

        public string Update(string table, string idcolumn, int id, string[] columns, string[] values)
        {

            string Update = $"UPDATE {table} SET {columns[0]} = '{values[0]}' WHERE {idcolumn} = {id}";

            return Update;
        }
    }
}
