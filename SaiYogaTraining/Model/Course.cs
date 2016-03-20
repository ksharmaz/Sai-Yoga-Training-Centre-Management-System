using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace SaiYogaTraining.Model
{
    class Course : Connection
    {

        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public string Duration { get; set; }
        public string CType { get; set; }
        public string Benefits { get; set; }
        public int Fee { get; set; }

        public DataSet SearchAll(string param)
        {
            try
            {
                var conn = GetConnect();
                var query = @"SELECT * FROM Course WHERE course_name LIKE('%' + @param + '%')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@param", param));
                SqlDataAdapter adr = new SqlDataAdapter(cmd);
                DataSet dr = new DataSet();
                adr.Fill(dr);
                return dr;
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

        public bool Delete(string id)
        {
            try
            {
                var conn = GetConnect();
                var query = "DELETE FROM Course WHERE course_id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@id", id));
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

        public static string GetCourseName(string id)
        {
            List<string> str = new List<string>();
            try
            {
                var conn = GetConnect();
                var query = "SELECT course_name FROM Course WHERE course_id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    str.Add(rdr[0].ToString());
                }
                return str[0];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
                return null;
            }
            finally
            {
                CloseConnect();
            }
        }

        public bool AddCourse()
        {
            try
            {
                var conn = GetConnect();
                var query = @"INSERT INTO Course (course_name, duration, ctype, benefits, fee) VALUES (@courseName, @duration, @ctype, @benefits, @fee)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@courseName", this.CourseName));
                cmd.Parameters.Add(new SqlParameter("@duration", this.Duration));
                cmd.Parameters.Add(new SqlParameter("@ctype", this.CType));
                cmd.Parameters.Add(new SqlParameter("@benefits", this.Benefits));
                cmd.Parameters.Add(new SqlParameter("@fee", this.Fee));
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
        }

        public bool UpdateCourse(string id)
        {
            try
            {
                var conn = GetConnect();
                var query = @"UPDATE Course SET course_name = @courseName, duration = @duration, " +
                            "ctype = @ctype, benefits = @benefits, fee = @fee WHERE course_id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@courseName", this.CourseName));
                cmd.Parameters.Add(new SqlParameter("@duration", this.Duration));
                cmd.Parameters.Add(new SqlParameter("@ctype", this.CType));
                cmd.Parameters.Add(new SqlParameter("@benefits", this.Benefits));
                cmd.Parameters.Add(new SqlParameter("@fee", this.Fee));
                cmd.Parameters.Add(new SqlParameter("@id", id));
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
        }

        public List<int> IDList()
        {
            List<int> lst = new List<int>();
            try
            {
                var conn = GetConnect();
                var query = @"SELECT course_id FROM COURSE";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    lst.Add(int.Parse(rdr[0].ToString()));
                }

                return lst;
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

        public void GetDetail(string id)
        {
            try
            {
                var conn = GetConnect();
                var query = @"SELECT * FROM COURSE WHERE course_id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    this.CourseID = rdr["course_id"].ToString();
                    this.CourseName = rdr["course_name"].ToString();
                    this.Duration = rdr["duration"].ToString();
                    this.CType = rdr["ctype"].ToString();
                    this.Benefits = rdr["benefits"].ToString();
                    this.Fee = int.Parse(rdr["fee"].ToString());
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

        public static Dictionary<int,string> CourseList()
        {
            try
            {
                Dictionary<int, string> dict = new Dictionary<int, string>();
                var conn = GetConnect();
                var query = @"SELECT course_id, course_name FROM COURSE";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    dict.Add(int.Parse(rdr["course_id"].ToString()), rdr["course_name"].ToString());
                }

                return dict;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
