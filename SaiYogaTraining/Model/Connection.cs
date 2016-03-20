using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SaiYogaTraining.Model
{
    class Connection
    {
        private static SqlConnection conn;

        protected Connection()
        {
            conn = new SqlConnection(global::SaiYogaTraining.Properties.Settings.Default.SaiYogaDBConnectionString);
        }
        public static SqlConnection GetConnect()
        {
            conn.Open();
            return conn;
        }
        public static void CloseConnect()
        {
            conn.Close();
        }
    }
}
