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
    public partial class FrmHastaKayıt : Form
    {
        public FrmHastaKayıt()
        {
            InitializeComponent();
        }
        
        SqlBaglantısı bgl = new SqlBaglantısı();
        private void BtnKayıtOl_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSıfre,HastaCınsıyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAD.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTc.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p5", TxtSıfre.Text);
            komut.Parameters.AddWithValue("@p6", CmbCınsıyet.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
           
            
            MessageBox.Show("Kayıt İşlemi Tamamlanmıştır \n \nŞifreniz: " + TxtSıfre.Text , "Bıigi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmHastaKayıt_Load(object sender, EventArgs e)
        {
            
        }
    }
}
