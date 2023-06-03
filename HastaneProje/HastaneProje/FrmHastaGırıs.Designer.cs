
namespace HastaneProje
{
    partial class FrmHastaGırıs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGırıs));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSıfre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.BtnGırıs = new System.Windows.Forms.Button();
            this.LnkUyeOl = new System.Windows.Forms.LinkLabel();
            this.LnkSıfremıUnuttum = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "TC Kimlik No:";
            // 
            // TxtSıfre
            // 
            this.TxtSıfre.Location = new System.Drawing.Point(151, 163);
            this.TxtSıfre.Name = "TxtSıfre";
            this.TxtSıfre.Size = new System.Drawing.Size(156, 26);
            this.TxtSıfre.TabIndex = 2;
            this.TxtSıfre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 41);
            this.label3.TabIndex = 30;
            this.label3.Text = "Hasta Giriş Paneli";
            // 
            // MskTc
            // 
            this.MskTc.Location = new System.Drawing.Point(151, 122);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(156, 26);
            this.MskTc.TabIndex = 1;
            this.MskTc.ValidatingType = typeof(int);
            // 
            // BtnGırıs
            // 
            this.BtnGırıs.Location = new System.Drawing.Point(151, 227);
            this.BtnGırıs.Name = "BtnGırıs";
            this.BtnGırıs.Size = new System.Drawing.Size(156, 33);
            this.BtnGırıs.TabIndex = 3;
            this.BtnGırıs.Text = "Giriş Yap";
            this.BtnGırıs.UseVisualStyleBackColor = true;
            this.BtnGırıs.Click += new System.EventHandler(this.BtnGırıs_Click);
            // 
            // LnkUyeOl
            // 
            this.LnkUyeOl.AutoSize = true;
            this.LnkUyeOl.LinkColor = System.Drawing.Color.Black;
            this.LnkUyeOl.Location = new System.Drawing.Point(197, 287);
            this.LnkUyeOl.Name = "LnkUyeOl";
            this.LnkUyeOl.Size = new System.Drawing.Size(57, 18);
            this.LnkUyeOl.TabIndex = 4;
            this.LnkUyeOl.TabStop = true;
            this.LnkUyeOl.Text = "Üye Ol";
            this.LnkUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkUyeOl_LinkClicked);
            // 
            // LnkSıfremıUnuttum
            // 
            this.LnkSıfremıUnuttum.AutoSize = true;
            this.LnkSıfremıUnuttum.LinkColor = System.Drawing.Color.Black;
            this.LnkSıfremıUnuttum.Location = new System.Drawing.Point(164, 324);
            this.LnkSıfremıUnuttum.Name = "LnkSıfremıUnuttum";
            this.LnkSıfremıUnuttum.Size = new System.Drawing.Size(128, 18);
            this.LnkSıfremıUnuttum.TabIndex = 5;
            this.LnkSıfremıUnuttum.TabStop = true;
            this.LnkSıfremıUnuttum.Text = "Şifremi Unuttum";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(-5, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 22);
            this.panel1.TabIndex = 60;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-5, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 75);
            this.panel2.TabIndex = 50;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.radioButton1.Location = new System.Drawing.Point(151, 195);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 22);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Beni Hatırla";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Honeydew;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(397, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // FrmHastaGırıs
            // 
            this.AcceptButton = this.BtnGırıs;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(610, 387);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LnkSıfremıUnuttum);
            this.Controls.Add(this.LnkUyeOl);
            this.Controls.Add(this.BtnGırıs);
            this.Controls.Add(this.MskTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSıfre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmHastaGırıs";
            this.Text = "Hasta Giriş";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSıfre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.Button BtnGırıs;
        private System.Windows.Forms.LinkLabel LnkUyeOl;
        private System.Windows.Forms.LinkLabel LnkSıfremıUnuttum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}