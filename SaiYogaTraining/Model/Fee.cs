using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;

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

        public void GeneratePDF(FileStream fs)
        {
            Trainee tn = new Trainee();
            tn.GetDetail(int.Parse(TraineeEnroll));
            Document doc = new Document(PageSize.A4, 72, 72, 72, 180);
            PdfWriter wrt = PdfWriter.GetInstance(doc, fs);
            Font tFont = new Font(Font.FontFamily.TIMES_ROMAN, 20, Font.UNDERLINE);
            Font pFont = new Font(Font.FontFamily.HELVETICA, 14, Font.NORMAL);
            Font hFont = new Font(Font.FontFamily.HELVETICA, 14, Font.BOLD);
            var title = new Paragraph("FEE PAYMENT RECEIPT", tFont);
            var date = new Paragraph("Date: " + DateTime.Now.ToString("dd/MM/yyyy"), hFont);
            title.Alignment = 1;
            title.SpacingAfter = 20;
            date.SpacingAfter = 10;
            doc.Open();
            doc.Add(Image.GetInstance(UploadImage(global::SaiYogaTraining.Properties.Resources.reciept_logo)));
            doc.Add(title);
            doc.Add(date);
            doc.Add(new Paragraph("Enroll #: " + this.TraineeEnroll.ToString(), pFont));
            doc.Add(new Paragraph("Name: " + tn.Name, pFont));
            doc.Add(new Paragraph("Course: " + crs.GetCourseName(tn.CourseID), pFont));
            doc.Add(new Paragraph("Paid Amount: " + this.PayAmt, pFont));
            doc.Add(new Paragraph("Balance: " + this.Balance, pFont));
            doc.Add(new Paragraph("Paid Amount(in words): " + NumbersToWords(this.PayAmt) + " only.", pFont));
            doc.Close();
        }

        public static string NumbersToWords(int inputNumber)
        {
            int inputNo = inputNumber;

            if (inputNo == 0)
                return "Zero";

            int[] numbers = new int[4];
            int first = 0;
            int u, h, t;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            if (inputNo < 0)
            {
                sb.Append("Minus ");
                inputNo = -inputNo;
            }

            string[] words0 = {"" ,"One ", "Two ", "Three ", "Four ",
            "Five " ,"Six ", "Seven ", "Eight ", "Nine "};
            string[] words1 = {"Ten ", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ",
            "Fifteen ","Sixteen ","Seventeen ","Eighteen ", "Nineteen "};
            string[] words2 = {"Twenty ", "Thirty ", "Forty ", "Fifty ", "Sixty ",
            "Seventy ","Eighty ", "Ninety "};
            string[] words3 = { "Thousand ", "Lakh ", "Crore " };

            numbers[0] = inputNo % 1000; // units
            numbers[1] = inputNo / 1000;
            numbers[2] = inputNo / 100000;
            numbers[1] = numbers[1] - 100 * numbers[2]; // thousands
            numbers[3] = inputNo / 10000000; // crores
            numbers[2] = numbers[2] - 100 * numbers[3]; // lakhs

            for (int i = 3; i > 0; i--)
            {
                if (numbers[i] != 0)
                {
                    first = i;
                    break;
                }
            }
            for (int i = first; i >= 0; i--)
            {
                if (numbers[i] == 0) continue;
                u = numbers[i] % 10; // ones
                t = numbers[i] / 10;
                h = numbers[i] / 100; // hundreds
                t = t - 10 * h; // tens
                if (h > 0) sb.Append(words0[h] + "Hundred ");
                if (u > 0 || t > 0)
                {
                    if (h > 0 || i == 0) sb.Append("and ");
                    if (t == 0)
                        sb.Append(words0[u]);
                    else if (t == 1)
                        sb.Append(words1[u]);
                    else
                        sb.Append(words2[t - 2] + words0[u]);
                }
                if (i != 0) sb.Append(words3[i - 1]);
            }
            return sb.ToString().TrimEnd();
        }

        private byte[] UploadImage(System.Drawing.Image img)
        {
            MemoryStream tmpStream = new MemoryStream();
            img.Save(tmpStream, img.RawFormat);
            tmpStream.Seek(0, SeekOrigin.Begin);
            byte[] imgbyte = new byte[tmpStream.Length];
            tmpStream.Read(imgbyte, 0, (int)tmpStream.Length);
            return imgbyte;
        }
    }
}
