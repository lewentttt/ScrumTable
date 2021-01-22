using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursSeminer
{
    class clsGorev
    {
        public string GorevAd { get; set; }
        public string Aciklama { get; set; }
        public string Notlar { get; set; }
        public DateTime BasTar { get; set; }
        public DateTime PlanlananTar { get; set; }
        public DateTime BitTar { get; set; }
        SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConn"].ToString());
        public void GorevKaydet()
        {
            string sql = "Insert Into tblGorev(GorevAd,Aciklama,Notlar,BasTar,PlanlananTar) Values(@GorevAd,@Aciklama,@Notlar,@BasTar,@PlanlananTar)";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            cmd.Parameters.AddWithValue("@GorevAd", GorevAd);
            cmd.Parameters.AddWithValue("@Aciklama", Aciklama);
            cmd.Parameters.AddWithValue("@Notlar", Notlar);
            cmd.Parameters.AddWithValue("@BasTar", BasTar.ToString("yyyy.MM.dd"));
            cmd.Parameters.AddWithValue("@PlanlananTar", PlanlananTar.ToString("yyyy.MM.dd"));
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public void GorevUpdate(int ID)
        {
            string sql = "Update tblGorev Set BitTar=@BitTar where pkGorevID="+ID;
            SqlCommand cmd = new SqlCommand(sql, cnn);
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            cmd.Parameters.AddWithValue("@BitTar", BitTar.ToString("yyyy.MM.dd"));
            cmd.ExecuteNonQuery();
            cnn.Close();


        }
    }
}
