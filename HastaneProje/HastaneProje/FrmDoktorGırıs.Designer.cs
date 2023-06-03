
namespace HastaneProje
{
    partial class FrmDoktorGırıs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorGırıs));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.LnkSıfremıUnuttum = new System.Windows.Forms.LinkLabel();
            this.BtnGırıs = new System.Windows.Forms.Button();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSıfre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.radioButton1.Location = new System.Drawing.Point(149, 209);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 22);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Beni Hatırla";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // LnkSıfremıUnuttum
            // 
            this.LnkSıfremıUnuttum.AutoSize = true;
            this.LnkSıfremıUnuttum.LinkColor = System.Drawing.Color.Black;
            this.LnkSıfremıUnuttum.Location = new System.Drawing.Point(167, 301);
            this.LnkSıfremıUnuttum.Name = "LnkSıfremıUnuttum";
            this.LnkSıfremıUnuttum.Size = new System.Drawing.Size(128, 18);
            this.LnkSıfremıUnuttum.TabIndex = 4;
            this.LnkSıfremıUnuttum.TabStop = true;
            this.LnkSıfremıUnuttum.Text = "Şifremi Unuttum";
            this.LnkSıfremıUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkSıfremıUnuttum_LinkClicked);
            // 
            // BtnGırıs
            // 
            this.BtnGırıs.Location = new System.Drawing.Point(149, 241);
            this.BtnGırıs.Name = "BtnGırıs";
            this.BtnGırıs.Size = new System.Drawing.Size(156, 33);
            this.BtnGırıs.TabIndex = 3;
            this.BtnGırıs.Text = "Giriş Yap";
            this.BtnGırıs.UseVisualStyleBackColor = true;
            this.BtnGırıs.Click += new System.EventHandler(this.BtnGırıs_Click);
            // 
            // MskTc
            // 
            this.MskTc.Location = new System.Drawing.Point(149, 136);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(156, 26);
            this.MskTc.TabIndex = 1;
            this.MskTc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Şifre:";
            // 
            // TxtSıfre
            // 
            this.TxtSıfre.Location = new System.Drawing.Point(149, 177);
            this.TxtSıfre.Name = "TxtSıfre";
            this.TxtSıfre.Size = new System.Drawing.Size(156, 26);
            this.TxtSıfre.TabIndex = 2;
            this.TxtSıfre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "TC Kimlik No:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(-8, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 77);
            this.panel2.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(373, 41);
            this.label4.TabIndex = 30;
            this.label4.Text = "Doktor Giriş Paneli";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(-8, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 22);
            this.panel1.TabIndex = 61;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Honeydew;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(419, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDoktorGırıs
            // 
            this.AcceptButton = this.BtnGırıs;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(642, 401);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.LnkSıfremıUnuttum);
            this.Controls.Add(this.BtnGırıs);
            this.Controls.Add(this.MskTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSıfre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorGırıs";
            this.Text = "Doktor Giriş";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.LinkLabel LnkSıfremıUnuttum;
        private System.Windows.Forms.Button BtnGırıs;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSıfre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}