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
    public partial class FrmHastaGırıs : Form
    {
        public FrmHastaGırıs()
        {
            InitializeComponent();
        }
        SqlBaglantısı bgl = new SqlBaglantısı();
        private void BtnGırıs_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1 and HastaSıfre=@p2", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", MskTc.Text);
            komut1.Parameters.AddWithValue("@p2", TxtSıfre.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read()) // dr okuma işlemini doğru yaptıysa anlamına geliuor
            {
                FrmHastaDetay frm = new FrmHastaDetay();
                frm.tc = MskTc.Text;   // Hasta detay formunda tanımlanan public nitelemeli değişken 
                frm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Kullamıcı adı veya şifre hatalı");
            }
            bgl.baglanti().Close();
        }

        private void LnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayıt fr = new FrmHastaKayıt();
            fr.Show();
            
        }

      
    }
}
