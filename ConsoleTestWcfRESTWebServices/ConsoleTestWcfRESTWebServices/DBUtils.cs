using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleTestWcfRESTWebServices
{
    class DBUtils
    {
        private string DatabaseName;
        private SqlDataAdapter myData;
        private SqlConnection sqlConnection;
        private string connectionString = String.Empty;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public DBUtils(string dbName)
        {
            DatabaseName = dbName;
            connectionString = "Data Source=(local); Integrated Security=SSPI;Initial Catalog=" + dbName;
            

        }


    }
}
