using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProje
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void BtnHasta_Click(object sender, EventArgs e)
        {
            FrmHastaGırıs fr = new FrmHastaGırıs();
            fr.Show();
            this.Hide();
        }

        private void BtnDoktor_Click(object sender, EventArgs e)
        {
            FrmDoktorGırıs fr = new FrmDoktorGırıs();
            fr.Show();
            this.Hide();
        }

        private void BtnSekreter_Click(object sender, EventArgs e)
        {
            FrmSekreterGırıs fr = new FrmSekreterGırıs();
            fr.Show();
            this.Hide();
        }

        
    }
}
