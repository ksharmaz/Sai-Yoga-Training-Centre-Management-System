using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SaiYogaTraining.Model
{
    class Salary : Connection
    {
        public string SalaryNo { get; set; }
        public int TotalNoHrs { get; set; }
        public int ChargesPerHrs { get; set; }
        public int Total { get; set; }
        public string TeacherID { get; set; }

        public void CalculateTotalHrs(string tID)
        {
            try
            {
                Nullable<DateTime> lastDate = null;

                var conn = GetConnect();
                var query = @"SELECT TOP 1 pay_date FROM Salary WHERE teacher_id = @id ORDER BY salary_no DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@id", tID));
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lastDate = Convert.ToDateTime(rdr["pay_date"].ToString());
                }
                rdr.Close();
                if (lastDate.Equals(null))
                {
                    int count = 0;
                    query = @"SELECT hrs_per_day FROM TeacherAttendance WHERE teacher_id = @id";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add(new SqlParameter("@id", tID));
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        count += int.Parse(rdr["hrs_per_day"].ToString());
                    }
                    this.TotalNoHrs = count;
                    rdr.Close();
                }
                else
                {
                    int count = 0;
                    query = @"SELECT hrs_per_day FROM TeacherAttendance WHERE teacher_id = @id AND tadate > @date";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add(new SqlParameter("@date", lastDate));
                    cmd.Parameters.Add(new SqlParameter("@id", tID));
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        count += int.Parse(rdr["hrs_per_day"].ToString());
                    }
                    this.TotalNoHrs = count;
                }
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

        public int CalculateTotal()
        {
            return this.TotalNoHrs * this.ChargesPerHrs;
        }

        public bool Insert()
        {
            try
            {
                var conn = GetConnect();
                var query = @"INSERT INTO Salary (total_no_hrs, charges_per_hrs, total, pay_date, teacher_id) VALUES "+
                    "(@totalhrs, @chargehrs, @total, getdate(), @id)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@totalhrs",this.TotalNoHrs));
                cmd.Parameters.Add(new SqlParameter("@chargehrs",this.ChargesPerHrs));
                cmd.Parameters.Add(new SqlParameter("@total", this.Total));
                cmd.Parameters.Add(new SqlParameter("@id",this.TeacherID));
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
