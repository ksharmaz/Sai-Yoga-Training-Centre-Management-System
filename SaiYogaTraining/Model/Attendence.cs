using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SaiYogaTraining.Model
{
    class Attendence : Connection
    {

        public DateTime Date { get; set; }

        public bool InitiateAttendence(string cid)
        {
            try
            {
                var conn = GetConnect();
                var query = @"INSERT INTO Attendence (adate, status, enroll_no) " +
                    "(SELECT '@date', 'Absent', enroll_no FROM Trainee WHERE course_id = @course)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@course", cid));
                cmd.Parameters.Add(new SqlParameter("@date", DateTime.Today));
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {

                throw;
            }
            finally
            {
                CloseConnect();
            }
        }
    }
}
