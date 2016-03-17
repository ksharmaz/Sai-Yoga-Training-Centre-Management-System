using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SaiYogaTraining.Model
{
    class Employee : Connection
    {
        public string Name { get; set; }
        private string Address { get; set; }
        private string Phone { get; set; }
        public string Type { get; set; }

        public Employee(string emp_id)
        {
            try
            {
                var conn = GetConnect();
                var query = "SELECT ename, eaddress, ephone, etype FROM Employee JOIN Session on Employee.emp_id = Session.emp_id WHERE sid=@emp_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@emp_id", emp_id));
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Name = reader["ename"].ToString();
                    Address = reader["eaddress"].ToString();
                    Phone = reader["ephone"].ToString();
                    Type = reader["etype"].ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                CloseConnect();
            }
        }
    }
}
