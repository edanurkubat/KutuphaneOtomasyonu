namespace KutuphaneOtomasyonu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblKullanici = new System.Windows.Forms.Label();
            lblSifre = new System.Windows.Forms.Label();
            tbKullanici = new System.Windows.Forms.TextBox();
            btnGiris = new System.Windows.Forms.Button();
            btnUyeol = new System.Windows.Forms.Button();
            tbSifre = new System.Windows.Forms.TextBox();
            lblSonuc = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblKullanici
            // 
            lblKullanici.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblKullanici.AutoSize = true;
            lblKullanici.BackColor = System.Drawing.Color.Transparent;
            lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            lblKullanici.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lblKullanici.Location = new System.Drawing.Point(120, 58);
            lblKullanici.Name = "lblKullanici";
            lblKullanici.Size = new System.Drawing.Size(120, 20);
            lblKullanici.TabIndex = 0;
            lblKullanici.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            lblSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblSifre.AutoSize = true;
            lblSifre.BackColor = System.Drawing.Color.Transparent;
            lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            lblSifre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblSifre.Location = new System.Drawing.Point(120, 119);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new System.Drawing.Size(55, 20);
            lblSifre.TabIndex = 1;
            lblSifre.Text = "Şifre:";
            // 
            // tbKullanici
            // 
            tbKullanici.Anchor = System.Windows.Forms.AnchorStyles.None;
            tbKullanici.Location = new System.Drawing.Point(292, 51);
            tbKullanici.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbKullanici.Name = "tbKullanici";
            tbKullanici.Size = new System.Drawing.Size(134, 27);
            tbKullanici.TabIndex = 2;
            // 
            // btnGiris
            // 
            btnGiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnGiris.Location = new System.Drawing.Point(155, 192);
            btnGiris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new System.Drawing.Size(89, 38);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnUyeol
            // 
            btnUyeol.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnUyeol.Location = new System.Drawing.Point(281, 192);
            btnUyeol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUyeol.Name = "btnUyeol";
            btnUyeol.Size = new System.Drawing.Size(89, 38);
            btnUyeol.TabIndex = 4;
            btnUyeol.Text = "Üye Ol";
            btnUyeol.UseVisualStyleBackColor = true;
            btnUyeol.Click += btnUyeol_Click;
            // 
            // tbSifre
            // 
            tbSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            tbSifre.Location = new System.Drawing.Point(292, 109);
            tbSifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbSifre.Name = "tbSifre";
            tbSifre.Size = new System.Drawing.Size(134, 27);
            tbSifre.TabIndex = 5;
            tbSifre.UseSystemPasswordChar = true;
            // 
            // lblSonuc
            // 
            lblSonuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblSonuc.AutoSize = true;
            lblSonuc.BackColor = System.Drawing.SystemColors.Info;
            lblSonuc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblSonuc.Location = new System.Drawing.Point(146, 259);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new System.Drawing.Size(0, 23);
            lblSonuc.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(531, 321);
            Controls.Add(lblSonuc);
            Controls.Add(tbSifre);
            Controls.Add(btnUyeol);
            Controls.Add(btnGiris);
            Controls.Add(tbKullanici);
            Controls.Add(lblSifre);
            Controls.Add(lblKullanici);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Giriş Yap/Üye Ol";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox tbKullanici;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnUyeol;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.Label lblSonuc;
    }
}

