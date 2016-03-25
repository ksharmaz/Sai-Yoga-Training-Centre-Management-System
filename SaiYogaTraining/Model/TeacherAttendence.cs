using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SaiYogaTraining.Model
{
    class TeacherAttendence : Connection
    {
        public DateTime Date { get; set; }
        public int HrsPerDay { get; set; }

        public bool InitiateAttendence()
        {
            try
            {
                var conn = GetConnect();
                var query = @"INSERT INTO TeacherAttendance (tadate, status, hrs_per_day, teacher_id) " +
                    "(SELECT getdate(), 'Absent', '0', teacher_id FROM Teacher)";
                SqlCommand cmd = new SqlCommand(query, conn);
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

        public void UpdateAttendence(string status, string sr)
        {
            try
            {
                var query = @"UPDATE TeacherAttendance SET status=@status WHERE sr_no = @sr";
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
        public void UpdateHourPerDay(string hrs, string sr)
        {
            try
            {
                var query = @"UPDATE TeacherAttendance SET hrs_per_day=@hrs WHERE sr_no = @sr";
                SqlCommand cmd = new SqlCommand(query, GetConnect());
                cmd.Parameters.AddWithValue("@hrs", hrs);
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
