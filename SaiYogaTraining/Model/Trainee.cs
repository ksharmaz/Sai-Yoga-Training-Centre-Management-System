using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SaiYogaTraining.Model
{
    class Trainee : Connection
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public DateTime Date { get; set; }
        public string CourseID { get; set; }
        public byte[] Photo { get; set; }
        public string ID { get; set; }

        public List<int> IDList()
        {
            List<int> lst = new List<int>();
            try
            {
                var conn = GetConnect();
                var query = @"SELECT enroll_no FROM TRAINEE";
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

                throw;
            }
            finally
            {
                CloseConnect();
            }
        }

        public void GetDetail(int id)
        {
            try
            {
                var conn = GetConnect();
                var query = @"SELECT * FROM TRAINEE WHERE enroll_no = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    this.ID = rdr["enroll_no"].ToString();
                    this.Name = rdr["tname"].ToString();
                    this.Address = rdr["taddress"].ToString();
                    this.Contact = rdr["contact"].ToString();
                    this.Date = Convert.ToDateTime(rdr["enroll_date"].ToString());
                    this.CourseID = rdr["course_id"].ToString();
                    this.Photo = (byte[])rdr["image"];
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

        public bool Delete(string id)
        {
            try
            {
                var conn = GetConnect();
                var query = "DELETE FROM Trainee WHERE enroll_no=@id";
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

        public string Insert()
        {
            try
            {
                var conn = GetConnect();
                var query = @"INSERT INTO Trainee (tname, taddress, contact, enroll_date, course_id, image) "+
                             "VALUES (@name, @address, @contact, @date, @course_id, @photo);SELECT CAST(scope_identity() AS int)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@name", this.Name));
                cmd.Parameters.Add(new SqlParameter("@address", this.Address));
                cmd.Parameters.Add(new SqlParameter("@contact", this.Contact));
                cmd.Parameters.Add(new SqlParameter("@date", this.Date));
                cmd.Parameters.Add(new SqlParameter("@course_id", this.CourseID));
                cmd.Parameters.Add(new SqlParameter("@photo", this.Photo));
                int id = -1;
                id = (int)cmd.ExecuteScalar();
                if (id != -1)
                    return id.ToString();
                else
                    return null;
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

        public bool Update(string id)
        {
            try
            {
                var conn = GetConnect();
                var query = @"UPDATE Trainee SET tname = @name, taddress = @address, " +
                            "contact = @contact WHERE enroll_no = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.Parameters.Add(new SqlParameter("@name", this.Name));
                cmd.Parameters.Add(new SqlParameter("@address", this.Address));
                cmd.Parameters.Add(new SqlParameter("@contact", this.Contact));
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
