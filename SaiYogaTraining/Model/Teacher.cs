using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SaiYogaTraining.Model
{
    class Teacher : Connection
    {
        public string TeacherID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Qualification { get; set; }


        public Dictionary<int,string> ListAll()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            try
            {
                var conn = GetConnect();
                var query = @"SELECT teacher_id, tname FROM Teacher";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    dict.Add(int.Parse(rdr["teacher_id"].ToString()), rdr["tname"].ToString());
                }
                return dict;
            }
            catch(Exception e)
            {
                throw;
            }
            finally
            {
                CloseConnect();
            }
        }

        public bool Insert()
        {
            try
            {
                var conn = GetConnect();
                var query = @"INSERT INTO Teacher (tname, taddress, tphone, tqualification) "+
                            "VALUES (@name, @address, @phone, @qualification)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@name", this.Name));
                cmd.Parameters.Add(new SqlParameter("@address", this.Address));
                cmd.Parameters.Add(new SqlParameter("@phone", this.Phone));
                cmd.Parameters.Add(new SqlParameter("@qualification", this.Qualification));
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
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

        public bool Update(string id)
        {
            try
            {
                var conn = GetConnect();
                var query = @"UPDATE Teacher SET tname = @name, taddress=@address, tphone=@phone, tqualification = @qualification "+
                    "WHERE teacher_id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@name", this.Name));
                cmd.Parameters.Add(new SqlParameter("@address", this.Address));
                cmd.Parameters.Add(new SqlParameter("@phone", this.Phone));
                cmd.Parameters.Add(new SqlParameter("@qualification", this.Qualification));
                cmd.Parameters.Add(new SqlParameter("@id", id));
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
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

        public bool Delete(string id)
        {
            try
            {
                var conn = GetConnect();
                var query = @"DELETE FROM Teacher " +
                    "WHERE teacher_id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;

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

        public void GetTeacher(string id)
        {
            try
            {
                var conn = GetConnect();
                var query = @"SELECT * FROM TEACHER WHERE teacher_id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    this.TeacherID = rdr["teacher_id"].ToString();
                    this.Name = rdr["tname"].ToString();
                    this.Address = rdr["taddress"].ToString();
                    this.Phone = rdr["tphone"].ToString();
                    this.Qualification = rdr["tqualification"].ToString();
                }
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
    }
}
