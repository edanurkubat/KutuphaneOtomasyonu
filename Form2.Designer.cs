namespace KutuphaneOtomasyonu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btnKitapEkle = new System.Windows.Forms.Button();
            btnEmanetEkle = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.BackColor = System.Drawing.Color.Transparent;
            btnKitapEkle.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnKitapEkle.BackgroundImage");
            btnKitapEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnKitapEkle.FlatAppearance.BorderSize = 0;
            btnKitapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnKitapEkle.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            btnKitapEkle.Location = new System.Drawing.Point(607, 136);
            btnKitapEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new System.Drawing.Size(200, 200);
            btnKitapEkle.TabIndex = 0;
            btnKitapEkle.Text = "KİTAPLAR";
            btnKitapEkle.UseVisualStyleBackColor = false;
            btnKitapEkle.Click += button1_Click;
            // 
            // btnEmanetEkle
            // 
            btnEmanetEkle.BackColor = System.Drawing.Color.Transparent;
            btnEmanetEkle.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnEmanetEkle.BackgroundImage");
            btnEmanetEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnEmanetEkle.FlatAppearance.BorderSize = 0;
            btnEmanetEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEmanetEkle.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            btnEmanetEkle.Location = new System.Drawing.Point(347, 136);
            btnEmanetEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEmanetEkle.Name = "btnEmanetEkle";
            btnEmanetEkle.Size = new System.Drawing.Size(200, 200);
            btnEmanetEkle.TabIndex = 1;
            btnEmanetEkle.Text = "EMANET EKLE";
            btnEmanetEkle.UseVisualStyleBackColor = false;
            btnEmanetEkle.Click += btnEmanetEkle_Click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.Transparent;
            button3.BackgroundImage = (System.Drawing.Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            button3.Location = new System.Drawing.Point(77, 136);
            button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(200, 200);
            button3.TabIndex = 2;
            button3.Text = "ÜYELER";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(2, 4);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 29);
            button1.TabIndex = 3;
            button1.Text = "Çıkış Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(878, 467);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(btnEmanetEkle);
            Controls.Add(btnKitapEkle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form2";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Anasayfa";
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnEmanetEkle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}