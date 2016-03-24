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
    }
}
