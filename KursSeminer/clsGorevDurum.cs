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
    class clsGorevDurum
    {
        public int GorevID { get; set; }
        public int DurumID { get; set; }
        public int KullaniciID { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConn"].ToString());
        public void GorevDurumKaydet()
        {
            string sql = "Insert Into tblGorevDurum(GorevID,DurumID,Aciklama,Tarih,KullaniciID) Values(@GorevID,@DurumID,@Aciklama,@Tarih,@KullaniciID)";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            cmd.Parameters.AddWithValue("@GorevID", GorevID);
            cmd.Parameters.AddWithValue("@DurumID", DurumID);
            cmd.Parameters.AddWithValue("@Aciklama", Aciklama);
            cmd.Parameters.AddWithValue("@Tarih", Tarih.ToString("yyyy.MM.dd"));
            cmd.Parameters.AddWithValue("@KullaniciID", KullaniciID);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public void GorevDurumUpdate(int GorevDurumID)
        {
            string sql = "Update tblGorevDurum set GorevID=@GorevID,DurumID=@DurumID,Aciklama=@Aciklama,Tarih=@Tarih,KullaniciID=@KullaniciID Where pkGorevDurumID="+ GorevDurumID;
            SqlCommand cmd = new SqlCommand(sql, cnn);
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            cmd.Parameters.AddWithValue("@GorevID", GorevID);
            cmd.Parameters.AddWithValue("@DurumID", DurumID);
            cmd.Parameters.AddWithValue("@Aciklama", Aciklama);
            cmd.Parameters.AddWithValue("@Tarih", Tarih.ToString("yyyy.MM.dd"));
            cmd.Parameters.AddWithValue("@KullaniciID", KullaniciID);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
