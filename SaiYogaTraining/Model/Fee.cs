using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SaiYogaTraining.Model
{
    class Fee : Connection
    {
        private int bal;
        private int prevBal;

        public int PayAmt { get; set; }
        public int Balance { get; set; }
        public DateTime PayDate { get; set; }
        public string PayType { get; set; }
        public string TraineeEnroll { get; set; }
        public string Other { get; set; }

        public int CalculateBalance(int bal, int payamnt)
        {
            Balance = bal;
            this.bal = bal;
            if (Balance == 0)
                return -1;
            else if (Balance < payamnt)
                return -1;
            else
                return Balance - payamnt;
        }

        public bool insert()
        {
            try
            {
                var conn = GetConnect();
                var query = @"INSERT INTO Payment (pay_amount, balance, pay_date, pay_type, other, enroll_no) VALUES "+
                    "(@amt, @bal, @date, @type, @other, @enroll)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@amt",this.PayAmt));
                cmd.Parameters.Add(new SqlParameter("@bal", this.Balance));
                cmd.Parameters.Add(new SqlParameter("@date",this.PayDate));
                cmd.Parameters.Add(new SqlParameter("@type",this.PayType));
                cmd.Parameters.Add(new SqlParameter("@other",this.Other));
                cmd.Parameters.Add(new SqlParameter("@enroll",this.TraineeEnroll));
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                {
                    this.Balance = bal;
                    return false;
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

        public int CheckLastBalance(string id)
        {
            try
            {
                prevBal = 0;
                var conn = GetConnect();
                var query = @"SELECT TOP 1 balance FROM Payment WHERE enroll_no=@id ORDER BY pay_id DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                    prevBal = int.Parse(rdr[0].ToString());
                return prevBal;
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
