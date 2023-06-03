
namespace HastaneProje
{
    partial class FrmHastaBılgıDuzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaBılgıDuzenle));
            this.CmbCınsıyet = new System.Windows.Forms.ComboBox();
            this.BtnBılgıGuncelle = new System.Windows.Forms.Button();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAD = new System.Windows.Forms.TextBox();
            this.TxtSıfre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbCınsıyet
            // 
            this.CmbCınsıyet.FormattingEnabled = true;
            this.CmbCınsıyet.Items.AddRange(new object[] {
            "Erkek\t",
            "Kadın\t"});
            this.CmbCınsıyet.Location = new System.Drawing.Point(145, 228);
            this.CmbCınsıyet.Name = "CmbCınsıyet";
            this.CmbCınsıyet.Size = new System.Drawing.Size(156, 26);
            this.CmbCınsıyet.TabIndex = 6;
            // 
            // BtnBılgıGuncelle
            // 
            this.BtnBılgıGuncelle.Location = new System.Drawing.Point(145, 269);
            this.BtnBılgıGuncelle.Name = "BtnBılgıGuncelle";
            this.BtnBılgıGuncelle.Size = new System.Drawing.Size(156, 34);
            this.BtnBılgıGuncelle.TabIndex = 7;
            this.BtnBılgıGuncelle.Text = "Güncelle";
            this.BtnBılgıGuncelle.UseVisualStyleBackColor = true;
            this.BtnBılgıGuncelle.Click += new System.EventHandler(this.BtnBılgıGuncelle_Click);
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(145, 151);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(156, 26);
            this.MskTelefon.TabIndex = 4;
            // 
            // MskTc
            // 
            this.MskTc.Location = new System.Drawing.Point(146, 110);
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(156, 26);
            this.MskTc.TabIndex = 3;
            this.MskTc.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "Şifre:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(145, 73);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(156, 26);
            this.TxtSoyad.TabIndex = 2;
            // 
            // TxtAD
            // 
            this.TxtAD.Location = new System.Drawing.Point(146, 38);
            this.TxtAD.Name = "TxtAD";
            this.TxtAD.Size = new System.Drawing.Size(156, 26);
            this.TxtAD.TabIndex = 1;
            // 
            // TxtSıfre
            // 
            this.TxtSıfre.Location = new System.Drawing.Point(145, 191);
            this.TxtSıfre.Name = "TxtSıfre";
            this.TxtSıfre.Size = new System.Drawing.Size(156, 26);
            this.TxtSıfre.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "TC Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cınsıyet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ad:";
            // 
            // FrmHastaBılgıDuzenle
            // 
            this.AcceptButton = this.BtnBılgıGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(370, 338);
            this.Controls.Add(this.CmbCınsıyet);
            this.Controls.Add(this.BtnBılgıGuncelle);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.MskTc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAD);
            this.Controls.Add(this.TxtSıfre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmHastaBılgıDuzenle";
            this.Text = "Bilgi Düzenle";
            this.Load += new System.EventHandler(this.FrmHastaBılgıDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbCınsıyet;
        private System.Windows.Forms.Button BtnBılgıGuncelle;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAD;
        private System.Windows.Forms.TextBox TxtSıfre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}