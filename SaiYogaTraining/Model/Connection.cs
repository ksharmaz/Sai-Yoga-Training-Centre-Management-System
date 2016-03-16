using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SaiYogaTraining.Model
{
    class Connection
    {
        private SqlConnection conn;

        protected Connection()
        {
            conn = new SqlConnection(global::SaiYogaTraining.Properties.Settings.Default.SaiYogaDBConnectionString);
        }
        public SqlConnection GetConnect()
        {
            conn.Open();
            return conn;
        }
        public void CloseConnect()
        {
            conn.Close();
        }
    }
}
