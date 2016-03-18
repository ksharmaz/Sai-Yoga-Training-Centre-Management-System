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
        public int Duration { get; set; }
        public string CType { get; set; }
        public string Benefits { get; set; }
        public Image CImage { get; set; }

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
    }
}
