using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace KursSeminer
{
    [TestFixture] 
    public class TestClass
    {       
        SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConn"].ToString());
        [Test] 
        public void ServerCheck() 
        {
            cnn.Open();            
            Assert.AreEqual(ConnectionState.Open, cnn.State); 
        }
        [Test]
        public void KaydetCheck()
        {
            string sql = "Insert Into tblGorev(GorevAd,Aciklama,Notlar,BasTar,PlanlananTar) Values(@GorevAd,@Aciklama,@Notlar,@BasTar,@PlanlananTar)";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            cmd.Parameters.AddWithValue("@GorevAd", "GorevAd");
            cmd.Parameters.AddWithValue("@Aciklama", "Aciklama");
            cmd.Parameters.AddWithValue("@Notlar", "Notlar");
            cmd.Parameters.AddWithValue("@BasTar", "2021.01.22");
            cmd.Parameters.AddWithValue("@PlanlananTar", "2021.01.22");
            cmd.ExecuteNonQuery();
            cnn.Close();
            Assert.AreEqual(ConnectionState.Closed, cnn.State);
        }
        [Test]
        public void UpdateCheck()
        {
            string sql = "Update tblGorev Set BitTar=@BitTar where pkGorevID=1";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            cmd.Parameters.AddWithValue("@BitTar", "2021.01.01");
            cmd.ExecuteNonQuery();
            cnn.Close();


            sql = "Select BitTar From tblGorev where pkGorevID=1";
            cmd = new SqlCommand(sql, cnn);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            Assert.AreEqual(DateTime.Parse(dr["BitTar"].ToString()).ToString("dd.MM.yyyy"), "01.01.2021");
        }
    }
}
