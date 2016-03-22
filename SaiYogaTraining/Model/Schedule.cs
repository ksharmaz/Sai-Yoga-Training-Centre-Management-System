using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public Schedule GetScheduleByCourse(string param)
        {
            try
            {
                var conn = GetConnect();
                var query = @"SELECT schedule_id, class_date, class_time, teacher_id, course_id FROM Schedule "+
                    "JOIN Course on Schedule.course_id = Course.course_id WHERE course_name LIKE '%'@param'%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@param", param));
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    this.ScheduleID = rdr["schedule_id"].ToString();
                    this.ClassDate = Convert.ToDateTime(rdr["class_date"].ToString());
                    this.ClassTime = Convert.ToDateTime(rdr["class_time"].ToString());
                    this.TeacherID = rdr["teacher_id"].ToString();
                    this.CourseID = rdr["course_id"].ToString();
                }

                return this;
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

        public Schedule GetScheduleByTeacher(string param)
        {
            try
            {
                var conn = GetConnect();
                var query = @"SELECT schedule_id, class_date, class_time, teacher_id, course_id FROM Schedule " +
                    "JOIN Teacher on Schedule.teacher_id = Teacher.teacher_id WHERE course_name LIKE '%'@param'%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@param", param));
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    this.ScheduleID = rdr["schedule_id"].ToString();
                    this.ClassDate = Convert.ToDateTime(rdr["class_date"].ToString());
                    this.ClassTime = Convert.ToDateTime(rdr["class_time"].ToString());
                    this.TeacherID = rdr["teacher_id"].ToString();
                    this.CourseID = rdr["course_id"].ToString();
                }

                return this;
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
