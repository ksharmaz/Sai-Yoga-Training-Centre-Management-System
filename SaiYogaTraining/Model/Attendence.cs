using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SaiYogaTraining.Model
{
    class Attendence : Connection
    {

        public DateTime Date { get; set; }

        public bool InitiateAttendence(string cid, string tid)
        {
            try
            {
                var conn = GetConnect();
                var query = @"INSERT INTO Attendance (adate, status, enroll_no) " +
                    "(SELECT getdate(), 'Absent', enroll_no FROM Trainee JOIN Schedule ON Schedule.course_id=Trainee.course_id WHERE Trainee.course_id = @course AND Schedule.schedule_id = @schedule)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@course", cid));
                cmd.Parameters.Add(new SqlParameter("@schedule", tid));
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

        public DataTable SelectAttendence()
        {
            try
            {
                var conn = GetConnect();
                var query = @"SELECT sr_no 'Serial No.', Attendance.enroll_no 'Enrollment No.', Trainee.tname 'Trainee Name', adate 'Date' " +
                    "FROM Attendance JOIN Trainee ON Attendance.enroll_no=Trainee.enroll_no WHERE adate=@date";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@date", DateTime.Today));
                SqlDataAdapter adr = new SqlDataAdapter();
                adr.SelectCommand = cmd;
                DataSet ds = new DataSet();
                adr.Fill(ds);

                DataTable dt = ds.Tables[0];

                return dt;

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

        public void UpdateAttendence(string status, string sr)
        {
            try
            {
                var query = @"UPDATE Attendance SET status = @status WHERE sr_no = @sr";
                SqlCommand cmd = new SqlCommand(query, GetConnect());
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@sr", sr);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
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
