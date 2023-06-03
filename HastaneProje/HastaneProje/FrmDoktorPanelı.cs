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
    public partial class FrmDoktorPanelı : Form
    {
        public FrmDoktorPanelı()
        {
            InitializeComponent();
        }
        SqlBaglantısı bgl = new SqlBaglantısı();
        private void FrmDoktorPanelı_Load(object sender, EventArgs e)
        {
            //doktorları datagride ekleme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Branşları comboboxa aktarma
            SqlCommand komut1 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                CmbBrans.Items.Add(dr1[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komutekle = new SqlCommand("insert into Tbl_Doktorlar(DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSıfre) values(@p1,@p2,@p3,@p4,@p5)",bgl.baglanti());
            komutekle.Parameters.AddWithValue("@p1", TxtAd.Text);
            komutekle.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komutekle.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komutekle.Parameters.AddWithValue("@p4", MskTc.Text);
            komutekle.Parameters.AddWithValue("@p5", TxtSifre.Text);
            komutekle.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Doktor ekleme işlemi tamamlanmıştır.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnSıl_Click(object sender, EventArgs e)
        {
            SqlCommand komutsıl = new SqlCommand("Delete From Tbl_Doktorlar where DoktorTc=@p1",bgl.baglanti());
            komutsıl.Parameters.AddWithValue("@p1", MskTc.Text);
            komutsıl.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor kaydı silinmiştir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskTc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSıfre=@p4 where DoktorTC=@p5",bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", TxtAd.Text);
            komutguncelle.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komutguncelle.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komutguncelle.Parameters.AddWithValue("@p5", MskTc.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor kaydı güncellenmiştir");
        }
    }
}
