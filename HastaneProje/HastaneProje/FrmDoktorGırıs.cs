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
    public partial class FrmDoktorGırıs : Form
    {
        public FrmDoktorGırıs()
        {
            InitializeComponent();
        }
        SqlBaglantısı bgl = new SqlBaglantısı();

        private void BtnGırıs_Click(object sender, EventArgs e)
        {
            SqlCommand komut5 = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1 and DoktorSıfre=@p2", bgl.baglanti());
            komut5.Parameters.AddWithValue("@p1", MskTc.Text);
            komut5.Parameters.AddWithValue("@p2", TxtSıfre.Text);
            SqlDataReader dr = komut5.ExecuteReader();
            if (dr.Read()) 
            {
                FrmDoktorDetay fr = new FrmDoktorDetay();
                fr.tc = MskTc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
            bgl.baglanti().Close();
        }

        private void LnkSıfremıUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
