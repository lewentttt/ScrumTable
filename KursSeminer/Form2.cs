using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;


namespace KursSeminer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConn"].ToString());
        void Aktif(bool aa)
        {
            txtAciklama.Enabled = aa;                 
            txtNotlar.Enabled = aa;
            txtProjeNo.Enabled = aa;
            
            dtpBasTarih.Enabled = aa;
            dtpPlanTar.Enabled = aa;
            dtpBitisTar.Enabled = aa;

            btnYeni.Enabled = !aa;
            btnDuzelt.Enabled = !aa;
            btnKaydet.Enabled = aa;
            btnIptal.Enabled = aa;

            dgwGorev.Enabled = !aa;           
        }
        int GorevID;
        private void btnYeni_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spKartNo"; 

            SqlParameter hareket = new SqlParameter("@KartNo", SqlDbType.Int);
            hareket.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(hareket);
            cmd.ExecuteReader();
            int Sonuc = cmd.Parameters["@KartNo"].Value.ToString()==""?0: Convert.ToInt32(cmd.Parameters["@KartNo"].Value);
            cnn.Close();

            Aktif(true);
            dtpBitisTar.Enabled = false;

            txtAciklama.Text = "";           
            txtKartNo.Text =(Sonuc+1).ToString();
            txtNotlar.Text = "";
            txtProjeNo.Text = "";                   
            Bayrak = "Yeni";
            GorevID = 0;
            dgwGorev.ClearSelection();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Aktif(false);
            GorevAktif(false);
            Doldur();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Aktif(false);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            clsGorev Gorev = new clsGorev();
            if (txtProjeNo.Text == "" || txtKartNo.Text == "" || txtAciklama.Text == "")
                MessageBox.Show("Gerekli Alanları Doldurunuz", "Manisa Software", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Gorev.Aciklama = txtAciklama.Text;
                Gorev.BasTar = dtpBasTarih.Value;
                Gorev.GorevAd = txtProjeNo.Text;
                Gorev.Notlar = txtNotlar.Text;
                Gorev.PlanlananTar = dtpPlanTar.Value;
                if (Bayrak == "Yeni")              
                    Gorev.GorevKaydet();                
                else if(Bayrak=="Duzelt")
                {
                    Gorev.BitTar = dtpBitisTar.Value;
                    Gorev.GorevUpdate(GorevID);
                }
                Aktif(false);
                Doldur();
            }
        }
        void Doldur()
        {
            string sql = "Select * From tblGorev";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dgwGorev.Rows.Clear();
            int sat = 0;
            while (dr.Read())
            {
                dgwGorev.Rows.Add(1);
                dgwGorev.Rows[sat].Cells[0].Value = (sat + 1).ToString();
                dgwGorev.Rows[sat].Cells[1].Value = dr["GorevAd"].ToString();
                dgwGorev.Rows[sat].Cells[2].Value = DateTime.Parse(dr["BasTar"].ToString()).ToString("dd.MM.yyyy");
                dgwGorev.Rows[sat].Cells[3].Value = DateTime.Parse(dr["PlanlananTar"].ToString()).ToString("dd.MM.yyyy");
                dgwGorev.Rows[sat].Cells[4].Value = dr["BitTar"].ToString()==""?"": DateTime.Parse(dr["BitTar"].ToString()).ToString("dd.MM.yyyy");
                dgwGorev.Rows[sat].Cells[5].Value = dr["Aciklama"].ToString();
                dgwGorev.Rows[sat].Cells[6].Value = dr["pkGorevID"].ToString();
                sat++;
            }
            cnn.Close();
            GorevID = 0;
            dgwGorev.ClearSelection();
        }
        int KartID;

        string Bayrak;
        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            if (GorevID > 0)
            {
                Bayrak = "Duzelt";
                Aktif(true);
            }
            else
                MessageBox.Show("Düzeltme Yapılacak Kaydı Seçiniz", "Manisa Software", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgwGorev_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GorevID = int.Parse(dgwGorev.Rows[e.RowIndex].Cells[6].Value.ToString());

                string sql = "Select * From tblGorev Where pkGorevID=" + GorevID;
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cnn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtProjeNo.Text = dr["GorevAd"].ToString();                    
                    txtKartNo.Text = dr["pkGorevID"].ToString();
                    dtpBasTarih.Value = DateTime.Parse(dr["BasTar"].ToString());
                    dtpPlanTar.Value= DateTime.Parse(dr["PlanlananTar"].ToString());
                    dtpBitisTar.Value = dr["BitTar"].ToString()==""?DateTime.Now: DateTime.Parse(dr["BitTar"].ToString());
                    txtAciklama.Text = dr["Aciklama"].ToString();
                    txtNotlar.Text = dr["Notlar"].ToString();
                }
                cnn.Close();
                GorevDurumDoldur();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        void GorevAktif(bool aa)
        {
            txtGorevDurumAciklama.Enabled = aa;
            cmbDurum.Enabled = aa;
            cmbUzman.Enabled = aa;
            dtpTarih.Enabled = aa;

            btnGorevDuzelt.Enabled =! aa;
            btnGorevIptal.Enabled = aa;
            btnGorevKaydet.Enabled = aa;
            btnGorevYeni.Enabled = !aa;

            dgwKart.Enabled = !aa;
        }
        string GorevBayrak;
        private void btnGorevYeni_Click(object sender, EventArgs e)
        {
            if (GorevID > 0)
            {
                GorevAktif(true);
                GorevBayrak = "Yeni";
                txtGorevDurumAciklama.Text = "";
                cmbDurum.SelectedIndex = 0;
                cmbUzman.SelectedIndex = 0;
                dtpTarih.Value = DateTime.Now;
            }
            else
                MessageBox.Show("Kart Eklenecek Görevi Seçiniz", "Manisa Software", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnGorevDuzelt_Click(object sender, EventArgs e)
        {
            if (KartID > 0)
            {
                GorevBayrak = "Duzelt";
                GorevAktif(true);
            }
            else
                MessageBox.Show("Düzeltme Yapılacak Kaydı Seçiniz", "Manisa Software", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        void GorevDurumDoldur()
        {
            if (GorevID > 0)
            {
                string sql = "Select * From viewProje Where GorevID=" + GorevID;
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cnn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dgwKart.Rows.Clear();
                int sat = 0;
                while (dr.Read())
                {
                    dgwKart.Rows.Add(1);
                    dgwKart.Rows[sat].Cells[0].Value = (sat + 1).ToString();
                    dgwKart.Rows[sat].Cells[1].Value = DateTime.Parse(dr["Tarih"].ToString()).ToString("dd.MM.yyyy");
                    dgwKart.Rows[sat].Cells[2].Value = dr["GorevDurumAciklama"].ToString();
                    dgwKart.Rows[sat].Cells[3].Value = dr["KullaniciAd"].ToString();
                    dgwKart.Rows[sat].Cells[4].Value = dr["DurumAd"].ToString();
                    dgwKart.Rows[sat].Cells[5].Value = dr["pkGorevDurumID"].ToString();
                    sat++;
                }
                cnn.Close();                
                KartID = 0;
                dgwKart.ClearSelection();
            }
        }
        private void btnGorevKaydet_Click(object sender, EventArgs e)
        {
            clsGorevDurum GorevDurum = new clsGorevDurum();
            if (txtProjeNo.Text == "" || txtKartNo.Text == "" || txtAciklama.Text == "")
                MessageBox.Show("Gerekli Alanları Doldurunuz", "Manisa Software", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {                
                GorevDurum.GorevID = GorevID;
                GorevDurum.DurumID = cmbDurum.SelectedIndex;
                GorevDurum.KullaniciID = cmbUzman.SelectedIndex;
                GorevDurum.Tarih = dtpTarih.Value;
                GorevDurum.Aciklama = txtGorevDurumAciklama.Text;
                if (GorevBayrak == "Yeni")
                    GorevDurum.GorevDurumKaydet();
                else if (GorevBayrak == "Duzelt")               
                    GorevDurum.GorevDurumUpdate(GorevID);

                GorevAktif(false);
                GorevDurumDoldur();
            }
        }
        private void btnGorevIptal_Click(object sender, EventArgs e)
        {
            GorevAktif(false);
        }

        private void dgwKart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                KartID = int.Parse(dgwKart.Rows[e.RowIndex].Cells[5].Value.ToString());

                string sql = "Select * From tblServis Where pkTeknikServisID=" + KartID;
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cnn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtProjeNo.Text = dr["ProjeAd"].ToString();
                    txtKartNo.Text = dr["KartNo"].ToString();
                    dtpBasTarih.Value = DateTime.Parse(dr["Tarih"].ToString());
                    txtAciklama.Text = dr["Aciklama"].ToString();
                    txtNotlar.Text = dr["Notlar"].ToString();
                }
                cnn.Close();
            }
        }
    }
}
