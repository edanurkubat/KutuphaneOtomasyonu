namespace KutuphaneOtomasyonu
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            comboBoxKitaplar = new System.Windows.Forms.ComboBox();
            comboBoxUyeler = new System.Windows.Forms.ComboBox();
            btnOduncVer = new System.Windows.Forms.Button();
            btnTeslimAl = new System.Windows.Forms.Button();
            lblDurum = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnAnaSayfa = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // comboBoxKitaplar
            // 
            comboBoxKitaplar.FormattingEnabled = true;
            comboBoxKitaplar.Items.AddRange(new object[] { "Kürk Mantolu Madonna", "İnce Mehmet", "Beyaz Diş", "Suç ve Ceza", "Sefiller", "1984", "Uçurtma Avcısı", "Bülbülü Öldürmek", "Yabancı", "Simyacı", "Fahrenheit 451", "Tutunamayanlar", "Hayvan Çiftliği", "Çavdar Tarlasında Çocuklar", "Vadideki Zambak" });
            comboBoxKitaplar.Location = new System.Drawing.Point(268, 70);
            comboBoxKitaplar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBoxKitaplar.Name = "comboBoxKitaplar";
            comboBoxKitaplar.Size = new System.Drawing.Size(386, 28);
            comboBoxKitaplar.TabIndex = 0;
            // 
            // comboBoxUyeler
            // 
            comboBoxUyeler.FormattingEnabled = true;
            comboBoxUyeler.Items.AddRange(new object[] { "Helin Dağ", "Ebru Dalkıran", "Edanur Kubat", "İclal Özden", "Melisa Saatçi", "Ali Bayındır", "Mehmet Ali Erbil", "Ekrem İmamoğlu", "Recep Tayip Erdoğan", "Beyza Şeker", "Edanur Uslu", "Devlet Bahçeli", "Ebrar Doğru", "Nehir Zeynep Yıldırım", "Kadriye Sude Kırk" });
            comboBoxUyeler.Location = new System.Drawing.Point(268, 175);
            comboBoxUyeler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBoxUyeler.Name = "comboBoxUyeler";
            comboBoxUyeler.Size = new System.Drawing.Size(386, 28);
            comboBoxUyeler.TabIndex = 1;
            // 
            // btnOduncVer
            // 
            btnOduncVer.Location = new System.Drawing.Point(295, 296);
            btnOduncVer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnOduncVer.Name = "btnOduncVer";
            btnOduncVer.Size = new System.Drawing.Size(75, 29);
            btnOduncVer.TabIndex = 2;
            btnOduncVer.Text = "Ödünç Ver";
            btnOduncVer.UseVisualStyleBackColor = true;
            btnOduncVer.Click += btnOduncVer_Click_1;
            // 
            // btnTeslimAl
            // 
            btnTeslimAl.Location = new System.Drawing.Point(505, 293);
            btnTeslimAl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnTeslimAl.Name = "btnTeslimAl";
            btnTeslimAl.Size = new System.Drawing.Size(75, 32);
            btnTeslimAl.TabIndex = 3;
            btnTeslimAl.Text = "Teslim Al";
            btnTeslimAl.UseVisualStyleBackColor = true;
            btnTeslimAl.Click += btnTeslimAl_Click_1;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.BackColor = System.Drawing.SystemColors.Info;
            lblDurum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            lblDurum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblDurum.Location = new System.Drawing.Point(252, 386);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new System.Drawing.Size(0, 28);
            lblDurum.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(135, 76);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(127, 22);
            label1.TabIndex = 5;
            label1.Text = "Kitap Seçimi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(135, 176);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(116, 22);
            label2.TabIndex = 6;
            label2.Text = "Üye Seçimi:";
            // 
            // btnAnaSayfa
            // 
            btnAnaSayfa.BackColor = System.Drawing.Color.Transparent;
            btnAnaSayfa.FlatAppearance.BorderSize = 0;
            btnAnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAnaSayfa.Location = new System.Drawing.Point(-11, 1);
            btnAnaSayfa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAnaSayfa.Name = "btnAnaSayfa";
            btnAnaSayfa.Size = new System.Drawing.Size(118, 29);
            btnAnaSayfa.TabIndex = 7;
            btnAnaSayfa.Text = "Ana Sayfa";
            btnAnaSayfa.UseVisualStyleBackColor = false;
            btnAnaSayfa.Click += btnAnaSayfa_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 486);
            Controls.Add(btnAnaSayfa);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDurum);
            Controls.Add(btnTeslimAl);
            Controls.Add(btnOduncVer);
            Controls.Add(comboBoxUyeler);
            Controls.Add(comboBoxKitaplar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form5";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Emanet Ekle";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKitaplar;
        private System.Windows.Forms.ComboBox comboBoxUyeler;
        private System.Windows.Forms.Button btnOduncVer;
        private System.Windows.Forms.Button btnTeslimAl;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnaSayfa;
    }
}