using KutuphaneOtomasyonu;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    [SupportedOSPlatform("windows6.1")]

    public partial class Form5 : Form
    {
        private readonly DataGridView dataGridView1; 

        public Form5()
        {
            InitializeComponent();      
            this.Controls.Add(dataGridView1);

        }
        [SupportedOSPlatform("windows6.1")]

        private void Form5_Load(object sender, EventArgs e)
        {
            
            List<Kitap> kitaplar = new List<Kitap>();
            
            comboBoxKitaplar.DataSource = kitaplar;
            comboBoxKitaplar.DisplayMember = "Adi";
            

            List<Uye> uyeler = new List<Uye>();

            comboBoxUyeler.DataSource = uyeler;
            comboBoxUyeler.DisplayMember = "Ad"; 

        }

        [SupportedOSPlatform("windows6.1")]


        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); 
            form2.Show();
            this.Hide();
        }

        [SupportedOSPlatform("windows6.1")]



        private void btnOduncVer_Click_1(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(comboBoxKitaplar.Text) || string.IsNullOrEmpty(comboBoxUyeler.Text))
            {
                lblDurum.Text = "Lütfen Tüm Alanları Doldurunuz!";
                lblDurum.ForeColor = Color.Red;
            }
            else
            {
                lblDurum.Text = "Kitap Ödünç Verildi.";
                lblDurum.ForeColor = Color.Green;
            }
               
            

        }
        [SupportedOSPlatform("windows6.1")]

        private void btnTeslimAl_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxKitaplar.Text) || string.IsNullOrEmpty(comboBoxUyeler.Text))
            {
                lblDurum.Text = "Lütfen Tüm Alanları Doldurunuz!";
                lblDurum.ForeColor = Color.Red;
            }
            else
            {
                lblDurum.Text = "Kitap Teslim Edildi.";
                lblDurum.ForeColor = Color.Green;
            }
           
        }
    }

}
