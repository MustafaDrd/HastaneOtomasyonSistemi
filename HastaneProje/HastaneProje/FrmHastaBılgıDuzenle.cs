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
    public partial class FrmHastaBılgıDuzenle : Form
    {
        public FrmHastaBılgıDuzenle()
        {
            InitializeComponent();
        }
        public string TcNo;
        SqlBaglantısı bgl = new SqlBaglantısı();
        private void FrmHastaBılgıDuzenle_Load(object sender, EventArgs e)
        {
            MskTc.Text = TcNo;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                TxtAD.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                MskTelefon.Text = dr[4].ToString();
                TxtSıfre.Text = dr[5].ToString();
                CmbCınsıyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnBılgıGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSıfre=@p4,HastaCınsıyet=@p5 where HastaTC=@p6", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", TxtAD.Text);
            komut1.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut1.Parameters.AddWithValue("@p3", MskTelefon.Text);
            komut1.Parameters.AddWithValue("@p4", TxtSıfre.Text);
            komut1.Parameters.AddWithValue("@p5", CmbCınsıyet.Text);
            komut1.Parameters.AddWithValue("@p6", MskTc.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellenmiştir ", "Bilgi" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
        }
    }
}
