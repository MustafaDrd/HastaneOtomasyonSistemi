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
    public partial class FrmBransPanelı : Form
    {
        public FrmBransPanelı()
        {
            InitializeComponent();
        }
        SqlBaglantısı bgl = new SqlBaglantısı();
        private void FrmBransPanelı_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komutekle = new SqlCommand("insert into Tbl_Branslar(BransAd) values (@p1)", bgl.baglanti());
            komutekle.Parameters.AddWithValue("@p1", TxtAd.Text);
            komutekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş ekleme işlemi tamamlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSıl_Click(object sender, EventArgs e)
        {
            SqlCommand komutsıl = new SqlCommand("Delete From Tbl_Branslar where Bransİd=@p1", bgl.baglanti());
            komutsıl.Parameters.AddWithValue("@p1", Txtİd.Text);
            komutsıl.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş kaydı silinmiştir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtİd.Text= dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Branslar set BransAd=@p1 where Bransİd=@p2",bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", TxtAd.Text);
            komutguncelle.Parameters.AddWithValue("@p2", Txtİd.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme işlemi tamamlanmıştır");
        }
    }
}
