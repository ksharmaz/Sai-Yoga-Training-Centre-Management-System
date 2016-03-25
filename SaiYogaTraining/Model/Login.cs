using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace SaiYogaTraining.Model
{
    class Login : Connection
    {
        public string loginID { get; set; }

        public bool ValidateLogin(string user, string pass)
        {
            var conn = GetConnect();
            string query = @"SELECT TOP 1  loginid, userid, passwd from Login " +
                           "WHERE userid = @id and passwd = @pass;";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add(new SqlParameter("@id", user));
            cmd.Parameters.Add(new SqlParameter("@pass", Encrypt(pass)));
            try
            {
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        loginID = rdr["loginid"].ToString();
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

        public bool CreateLogin(string user, string pass)
        {
            try
            {
                string query = @"INSERT INTO Login (userid, passwd) VALUES (@user, @pass)";
                SqlCommand cmd = new SqlCommand(query, GetConnect());
                cmd.Parameters.Add(new SqlParameter("@user", user));
                cmd.Parameters.Add(new SqlParameter("@pass", Encrypt(pass)));
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

        #region Encryption Function (Using MD5 Encryption technique)
        private string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
        #endregion
    }
}
