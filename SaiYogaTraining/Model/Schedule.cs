using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SaiYogaTraining.Model
{
    class Schedule : Connection
    {

        public string ScheduleID { get; set; }
        public DateTime ClassDate { get; set; }
        public DateTime ClassTime { get; set; }
        public string TeacherID { get; set; }
        public string CourseID { get; set; }

        public bool AddSchedule()
        {
            try
            {
                var conn = GetConnect();
                var query = @"INSERT INTO Schedule (class_date, class_time, teacher_id, course_id) VALUES "+
                            "(@date, @time, @teacher, @course)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@date", this.ClassDate));
                cmd.Parameters.Add(new SqlParameter("@time", this.ClassTime));
                cmd.Parameters.Add(new SqlParameter("@teacher", this.TeacherID));
                cmd.Parameters.Add(new SqlParameter("@course", this.CourseID));
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

        public DataTable GetScheduleByCourse(string param)
        {
            try
            {
                var conn = GetConnect();
                var query = @"SELECT schedule_id 'Schedule ID', class_date 'Class Date', class_time 'Class Time', Course.course_id 'Course ID', Course.course_name 'Course Name', Teacher.tname 'Teacher Name' FROM Schedule " +
                    "JOIN Course on Schedule.course_id = Course.course_id JOIN Teacher ON Schedule.teacher_id = Teacher.teacher_id WHERE course_name LIKE '%' + @param +'%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@param", param));
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

        public DataTable GetScheduleByTeacher(string param)
        {
            try
            {
                var conn = GetConnect();
                var query = @"SELECT schedule_id 'Schedule ID', class_date 'Class Date', class_time 'Class Time', Course.course_id 'Course ID', Course.course_name 'Course Name', Teacher.tname 'Teacher Name' FROM Schedule " +
                    "JOIN Teacher ON Schedule.teacher_id = Teacher.teacher_id JOIN Course ON Schedule.course_id = Course.course_id WHERE tname LIKE '%'+@param+'%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@param", param));
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

        public Dictionary<KeyValuePair<string, string>, string> GetList()
        {
            try
            {
                Dictionary<KeyValuePair<string,string>, string> dict = new Dictionary<KeyValuePair<string, string>, string>();
                var conn = GetConnect();
                var query = @"SELECT schedule_id, class_date, class_time, Course.course_id, Course.course_name FROM Schedule JOIN Teacher ON Schedule.teacher_id=Teacher.teacher_id "+
                    "JOIN Course ON Course.course_id=Schedule.course_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    KeyValuePair<string, string> sc = new KeyValuePair<string, string>(rdr["schedule_id"].ToString(), rdr["course_id"].ToString());
                    dict.Add(sc, string.Concat(rdr["course_name"].ToString().Trim(), " On ",  Convert.ToDateTime(rdr["class_date"].ToString()).ToString("dd/MM/yyyy"), " ",
                        Convert.ToDateTime(rdr["class_time"].ToString()).ToString("hh:mm tt")));
                }
                return dict;
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
