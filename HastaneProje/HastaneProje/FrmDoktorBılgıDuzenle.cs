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
    public partial class FrmDoktorBılgıDuzenle : Form
    {
        public FrmDoktorBılgıDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglantısı bgl = new SqlBaglantısı();
        public string tc;
        private void FrmDoktorBılgıDuzenle_Load(object sender, EventArgs e)
        {
            MskTc.Text = tc;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAD.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                CmbBrans.Text = dr[3].ToString();
                TxtSıfre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnBılgıGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSıfre=@p4 where DoktorTC=@p5", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", TxtAD.Text);
            komutguncelle.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komutguncelle.Parameters.AddWithValue("@p4", TxtSıfre.Text);
            komutguncelle.Parameters.AddWithValue("@p5", MskTc.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme işlemi tamamlanmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
