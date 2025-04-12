namespace KutuphaneOtomasyonu
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            dataGridView1 = new System.Windows.Forms.DataGridView();
            txtAra = new System.Windows.Forms.TextBox();
            btnAra = new System.Windows.Forms.Button();
            btnAnaSayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(255, 128, 128);
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(64, 181);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(677, 299);
            dataGridView1.TabIndex = 0;
            // 
            // txtAra
            // 
            txtAra.Location = new System.Drawing.Point(64, 91);
            txtAra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtAra.Name = "txtAra";
            txtAra.Size = new System.Drawing.Size(567, 27);
            txtAra.TabIndex = 1;
            // 
            // btnAra
            // 
            btnAra.Location = new System.Drawing.Point(659, 87);
            btnAra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAra.Name = "btnAra";
            btnAra.Size = new System.Drawing.Size(82, 35);
            btnAra.TabIndex = 2;
            btnAra.Text = "Üye Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // btnAnaSayfa
            // 
            btnAnaSayfa.BackColor = System.Drawing.Color.Transparent;
            btnAnaSayfa.FlatAppearance.BorderSize = 0;
            btnAnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAnaSayfa.Location = new System.Drawing.Point(-4, 4);
            btnAnaSayfa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAnaSayfa.Name = "btnAnaSayfa";
            btnAnaSayfa.Size = new System.Drawing.Size(97, 29);
            btnAnaSayfa.TabIndex = 3;
            btnAnaSayfa.Text = "Ana Sayfa";
            btnAnaSayfa.UseVisualStyleBackColor = false;
            btnAnaSayfa.Click += btnAnaSayfa_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 562);
            Controls.Add(btnAnaSayfa);
            Controls.Add(btnAra);
            Controls.Add(txtAra);
            Controls.Add(dataGridView1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form4";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Üyeler";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnAnaSayfa;
    }
}