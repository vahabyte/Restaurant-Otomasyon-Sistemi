namespace Exa_restaurant
{
    partial class giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.KadiTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.Ksifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.GirisBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HataLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.MediumBlue;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.DarkViolet;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.MediumVioletRed;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(224, 349);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(351, 51);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(84, 85);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // KadiTb
            // 
            this.KadiTb.BackColor = System.Drawing.Color.Transparent;
            this.KadiTb.BorderColor = System.Drawing.Color.White;
            this.KadiTb.BorderRadius = 5;
            this.KadiTb.BorderThickness = 2;
            this.KadiTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KadiTb.DefaultText = "";
            this.KadiTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.KadiTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.KadiTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KadiTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KadiTb.FillColor = System.Drawing.Color.BlueViolet;
            this.KadiTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KadiTb.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KadiTb.ForeColor = System.Drawing.Color.White;
            this.KadiTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KadiTb.Location = new System.Drawing.Point(275, 154);
            this.KadiTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KadiTb.Name = "KadiTb";
            this.KadiTb.PasswordChar = '\0';
            this.KadiTb.PlaceholderForeColor = System.Drawing.Color.White;
            this.KadiTb.PlaceholderText = "Kullanıcı Adı";
            this.KadiTb.SelectedText = "";
            this.KadiTb.Size = new System.Drawing.Size(235, 38);
            this.KadiTb.TabIndex = 13;
            // 
            // Ksifre
            // 
            this.Ksifre.BackColor = System.Drawing.Color.Transparent;
            this.Ksifre.BorderColor = System.Drawing.Color.White;
            this.Ksifre.BorderRadius = 5;
            this.Ksifre.BorderThickness = 2;
            this.Ksifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Ksifre.DefaultText = "";
            this.Ksifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Ksifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Ksifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Ksifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Ksifre.FillColor = System.Drawing.Color.BlueViolet;
            this.Ksifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Ksifre.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ksifre.ForeColor = System.Drawing.Color.White;
            this.Ksifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Ksifre.Location = new System.Drawing.Point(275, 212);
            this.Ksifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ksifre.Name = "Ksifre";
            this.Ksifre.PasswordChar = '*';
            this.Ksifre.PlaceholderForeColor = System.Drawing.Color.White;
            this.Ksifre.PlaceholderText = "Şifre";
            this.Ksifre.SelectedText = "";
            this.Ksifre.Size = new System.Drawing.Size(235, 38);
            this.Ksifre.TabIndex = 14;
            // 
            // GirisBtn
            // 
            this.GirisBtn.Animated = true;
            this.GirisBtn.AutoRoundedCorners = true;
            this.GirisBtn.BackColor = System.Drawing.Color.Transparent;
            this.GirisBtn.BorderRadius = 18;
            this.GirisBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GirisBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GirisBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GirisBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GirisBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GirisBtn.FillColor = System.Drawing.Color.RoyalBlue;
            this.GirisBtn.FillColor2 = System.Drawing.Color.HotPink;
            this.GirisBtn.Font = new System.Drawing.Font("Source Sans Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisBtn.ForeColor = System.Drawing.Color.White;
            this.GirisBtn.Location = new System.Drawing.Point(307, 287);
            this.GirisBtn.Name = "GirisBtn";
            this.GirisBtn.Size = new System.Drawing.Size(166, 38);
            this.GirisBtn.TabIndex = 15;
            this.GirisBtn.Text = "Giriş Yap";
            this.GirisBtn.Click += new System.EventHandler(this.GirisBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(303, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "EXA RESTAURANT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(530, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HataLbl
            // 
            this.HataLbl.AutoSize = true;
            this.HataLbl.BackColor = System.Drawing.Color.Transparent;
            this.HataLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HataLbl.ForeColor = System.Drawing.Color.Red;
            this.HataLbl.Location = new System.Drawing.Point(262, 259);
            this.HataLbl.Name = "HataLbl";
            this.HataLbl.Size = new System.Drawing.Size(0, 16);
            this.HataLbl.TabIndex = 18;
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(565, 349);
            this.Controls.Add(this.HataLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GirisBtn);
            this.Controls.Add(this.Ksifre);
            this.Controls.Add(this.KadiTb);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exa restaurant";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Guna.UI2.WinForms.Guna2GradientButton GirisBtn;
        private Guna.UI2.WinForms.Guna2TextBox Ksifre;
        private Guna.UI2.WinForms.Guna2TextBox KadiTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label HataLbl;
    }
}

