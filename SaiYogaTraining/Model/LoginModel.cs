using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SaiYogaTraining.Model
{
    class LoginModel : Connection
    {
        private string loginType = null;
        private string loginID = null;

        public bool ValidateLogin(string user, string pass, string ltype)
        {
            var conn = this.GetConnect();
            string query = "SELECT TOP 1 employee.emp_id, login.userid, login.passwd, employee.etype from Login JOIN Employee ON Login.emp_id = Employee.emp_id " +
                           "WHERE userid = @id and passwd = @pass and etype = @type;";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add(new SqlParameter("@id", user));
            cmd.Parameters.Add(new SqlParameter("@pass", pass));
            cmd.Parameters.Add(new SqlParameter("@type", ltype));
            try
            {
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        loginID = rdr[0].ToString();
                        loginType = rdr[3].ToString();
                    }
                    return true;
                }
                else
                    return false;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                CloseConnect();
            }
        }

        #region Accessor
        public string GetLoginType()
        {
            return loginType;
        }

        public string GetLoginID()
        {
            return loginID;
        }
        #endregion
    }
}
