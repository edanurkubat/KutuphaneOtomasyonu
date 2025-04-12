namespace KutuphaneOtomasyonu
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            dataGridView1 = new System.Windows.Forms.DataGridView();
            txtAra = new System.Windows.Forms.TextBox();
            btnAra = new System.Windows.Forms.Button();
            btnTureGoreAra = new System.Windows.Forms.Button();
            cmbTur = new System.Windows.Forms.ComboBox();
            btnAnaSayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(255, 128, 128);
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(69, 149);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(764, 344);
            dataGridView1.TabIndex = 0;
            // 
            // txtAra
            // 
            txtAra.Location = new System.Drawing.Point(69, 63);
            txtAra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtAra.Name = "txtAra";
            txtAra.Size = new System.Drawing.Size(311, 27);
            txtAra.TabIndex = 1;
            // 
            // btnAra
            // 
            btnAra.Location = new System.Drawing.Point(410, 63);
            btnAra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAra.Name = "btnAra";
            btnAra.Size = new System.Drawing.Size(93, 35);
            btnAra.TabIndex = 2;
            btnAra.Text = "İsim Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click_1;
            // 
            // btnTureGoreAra
            // 
            btnTureGoreAra.Location = new System.Drawing.Point(758, 63);
            btnTureGoreAra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnTureGoreAra.Name = "btnTureGoreAra";
            btnTureGoreAra.Size = new System.Drawing.Size(75, 36);
            btnTureGoreAra.TabIndex = 3;
            btnTureGoreAra.Text = "Tür Ara";
            btnTureGoreAra.UseVisualStyleBackColor = true;
            btnTureGoreAra.Click += btnTureGoreAra_Click_1;
            // 
            // cmbTur
            // 
            cmbTur.FormattingEnabled = true;
            cmbTur.Location = new System.Drawing.Point(519, 62);
            cmbTur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbTur.Name = "cmbTur";
            cmbTur.Size = new System.Drawing.Size(221, 28);
            cmbTur.TabIndex = 4;
            // 
            // btnAnaSayfa
            // 
            btnAnaSayfa.BackColor = System.Drawing.Color.Transparent;
            btnAnaSayfa.FlatAppearance.BorderSize = 0;
            btnAnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAnaSayfa.Location = new System.Drawing.Point(-11, -1);
            btnAnaSayfa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAnaSayfa.Name = "btnAnaSayfa";
            btnAnaSayfa.Size = new System.Drawing.Size(125, 39);
            btnAnaSayfa.TabIndex = 5;
            btnAnaSayfa.Text = "Ana Sayfa";
            btnAnaSayfa.UseVisualStyleBackColor = false;
            btnAnaSayfa.Click += btnAnaSayfa_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(905, 565);
            Controls.Add(btnAnaSayfa);
            Controls.Add(cmbTur);
            Controls.Add(btnTureGoreAra);
            Controls.Add(btnAra);
            Controls.Add(txtAra);
            Controls.Add(dataGridView1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form3";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Kitaplar";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnTureGoreAra;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Button btnAnaSayfa;
    }
}