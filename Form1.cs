using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Form1: Form
    {
        [SupportedOSPlatform("windows6.1")]

        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnGiris; // Enter tuşuna basıldığında giriş butonu çalışır
        }
        
        [SupportedOSPlatform("windows6.1")]


        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullanici = tbKullanici.Text.Trim();
            string sifre = tbSifre.Text.Trim();

            if (kullanici == "admin" && sifre == "1234")
            {
                lblSonuc.Text = "Giriş başarılı!";
                lblSonuc.ForeColor = Color.Green;

               // formdan forma atlama
                Form2 form2 = new();

                // Form2'yi göster
                form2.Show();

                // Form1'i gizle
                this.Hide();
            }
            else
            {
                lblSonuc.Text = "Böyle bir kullanıcı bulunamadı!";
                lblSonuc.ForeColor = Color.Red;
            }
            if (kullanici == "edanurrkbt" && sifre == "şifre123")
            {
                lblSonuc.Text = "Giriş başarılı!";
                lblSonuc.ForeColor = Color.Green;

                Form2 form2 = new ();

                // Form2'yi göster
                form2.Show();

                // Form1'i gizle 
                this.Hide();
            }
            else
            {
                lblSonuc.Text = "Böyle bir kullanıcı bulunamadı!";
                lblSonuc.ForeColor = Color.Red;
            }
            if (kullanici == "sudekirk" && sifre == "şifre123")
            {
                lblSonuc.Text = "Giriş başarılı!";
                lblSonuc.ForeColor = Color.Green;

                Form2 form2 = new();

                // Form2'yi göster
                form2.Show();

                // Form1'i gizle 
                this.Hide();
            }
            else
            {
                lblSonuc.Text = "Böyle bir kullanıcı bulunamadı!";
                lblSonuc.ForeColor = Color.Red;
            }
            if (kullanici == "nehirzeynepyildirim" && sifre == "şifre123")
            {
                lblSonuc.Text = "Giriş başarılı!";
                lblSonuc.ForeColor = Color.Green;

                Form2 form2 = new ();

                // Form2'yi göster
                form2.Show();

                // Form1'i gizle 
                this.Hide();
            }
            else
            {
                lblSonuc.Text = "Böyle bir kullanıcı bulunamadı!";
                lblSonuc.ForeColor = Color.Red;
            }
            if (string.IsNullOrEmpty(tbKullanici.Text) || string.IsNullOrEmpty(tbSifre.Text))
            {
                lblSonuc.Text = "Kullanıcı Adı Veya Şifre Boş Bırakılamaz!";
                lblSonuc.ForeColor = Color.Red;
            }


        }
        [SupportedOSPlatform("windows6.1")]

        private void btnUyeol_Click(object sender, EventArgs e)
        {
            string kullanici = tbKullanici.Text.Trim();
            string sifre = tbSifre.Text.Trim();

            if (kullanici != "" && sifre != "")
            {
                
                lblSonuc.Text = "Üye olma başarılı! Giriş yapabilirsiniz.";
                lblSonuc.ForeColor = Color.Green;

                
                tbKullanici.Clear();
                tbSifre.Clear();
            }
            else
            {
                lblSonuc.Text = "Kullanıcı Adı Veya Şifre Boş Bırakılamaz!";
                lblSonuc.ForeColor = Color.Red;
            }
        }

        [SupportedOSPlatform("windows6.1")]

        private void Form1_Load(object sender, EventArgs e)
        {
            // silemedim
        }
    }
}
