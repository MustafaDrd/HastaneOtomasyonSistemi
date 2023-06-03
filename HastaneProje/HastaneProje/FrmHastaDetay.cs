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
namespace HastaneProje
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        SqlBaglantısı bgl = new SqlBaglantısı();
        public string tc;

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            LblTc.Text = tc;
            //ad soyad çekme
            SqlCommand komut2 = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTc=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", LblTc.Text);
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }

            bgl.baglanti().Close();

            // randevu geçmişi

            DataTable dtt = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=" + tc, bgl.baglanti());
            daa.Fill(dtt);
            dataGridView1.DataSource = dtt; 

            //branşları çekme
            SqlCommand komut4 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut4.ExecuteReader();
            while (dr2.Read())
            {
                CmbBolum.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void CmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();

            SqlCommand komut5 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut5.Parameters.AddWithValue("@p1", CmbBolum.Text);
            SqlDataReader dr3 = komut5.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='" + CmbBolum.Text + "'" + " and  RandevuDoktor='" + CmbDoktor.Text + "' and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void LnkBılgıDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBılgıDuzenle fr = new FrmHastaBılgıDuzenle();
            fr.TcNo = LblTc.Text;
            fr.Show();
        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Randevular Set RandevuDurum=1,HastaTC=@p1,HastaSıkayet=@p2 where Randevu_İd=@p3", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", LblTc.Text);
            komutguncelle.Parameters.AddWithValue("@p2", RchSikayet.Text);
            komutguncelle.Parameters.AddWithValue("@p3", textBox1.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
