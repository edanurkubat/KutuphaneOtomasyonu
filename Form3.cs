using KutuphaneOtomasyonu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Form3 : Form
    {
        List<Kitap> kitaplar = new List<Kitap>();
        [SupportedOSPlatform("windows6.1")]   // versiyon uyumu için eklemek zorunda kaldık

        public Form3()
        {
            InitializeComponent();
            KitaplariListele();
            TurleriYukle();
        }
        [SupportedOSPlatform("windows6.1")]

        private void KitaplariListele()
        {
            kitaplar = new ()
    {
        new Kitap { ID = 1, Adi = "Kürk Mantolu Madonna", Yazar = "Sabahattin Ali", Tur = "Roman", Sayfa = 160 },
        new Kitap { ID = 2, Adi = "İnce Mehmed", Yazar = "Yaşar Kemal", Tur = "Roman", Sayfa = 430 },
        new Kitap { ID = 3, Adi = "Beyaz Diş", Yazar = "Jack London", Tur = "Macera", Sayfa = 250 },
        new Kitap { ID = 4, Adi = "Suç ve Ceza", Yazar = "Dostoyevski", Tur = "Klasik", Sayfa = 670 },
        new Kitap { ID = 5, Adi = "Sefiller", Yazar = "Victor Hugo", Tur = "Klasik", Sayfa = 1200 },
        new Kitap { ID = 6, Adi = "1984", Yazar = "George Orwell", Tur = "Distopya", Sayfa = 328 },
        new Kitap { ID = 7, Adi = "Uçurtma Avcısı", Yazar = "Khaled Hosseini", Tur = "Roman", Sayfa = 370 },
        new Kitap { ID = 8, Adi = "Bülbülü Öldürmek", Yazar = "Harper Lee", Tur = "Roman", Sayfa = 281 },
        new Kitap { ID = 9, Adi = "Yabancı", Yazar = "Albert Camus", Tur = "Felsefi Roman", Sayfa = 123 },
        new Kitap { ID = 10, Adi = "Simyacı", Yazar = "Paulo Coelho", Tur = "Roman", Sayfa = 190 },
        new Kitap { ID = 11, Adi = "Fahrenheit 451", Yazar = "Ray Bradbury", Tur = "Distopya", Sayfa = 249 },
        new Kitap { ID = 12, Adi = "Tutunamayanlar", Yazar = "Oğuz Atay", Tur = "Modern", Sayfa = 724 },
        new Kitap { ID = 13, Adi = "Hayvan Çiftliği", Yazar = "George Orwell", Tur = "Allegori", Sayfa = 144 },
        new Kitap { ID = 14, Adi = "Çavdar Tarlasında Çocuklar", Yazar = "J. D. Salinger", Tur = "Gençlik Romanı", Sayfa = 277 },
        new Kitap { ID = 15, Adi = "Vadideki Zambak", Yazar = "Balzac", Tur = "Klasik", Sayfa = 305 }
    };

            dataGridView1.DataSource = kitaplar;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        [SupportedOSPlatform("windows6.1")]

        private void TurleriYukle()
        {
            var turler = kitaplar.Select(k => k.Tur.Trim()).Distinct().ToList();
            cmbTur.Items.Clear();
            cmbTur.Items.Add("Tümü");    
            cmbTur.Items.AddRange(turler.ToArray());
            cmbTur.SelectedIndex = 0;

        }

        [SupportedOSPlatform("windows6.1")]

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();            
            form2.Show();   
            this.Hide();
        }
        [SupportedOSPlatform("windows6.1")]

        private void btnTureGoreAra_Click_1(object sender, EventArgs e)
        {
            string secilenTur = cmbTur.SelectedItem != null ? cmbTur.SelectedItem.ToString().Trim() : string.Empty;


            if (string.IsNullOrEmpty(secilenTur))
            {
                MessageBox.Show("Lütfen bir tür seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //  Eğer "Tümü" seçildiyse, tüm kitapları göster
            if (secilenTur.Equals("Tümü", StringComparison.OrdinalIgnoreCase))
            {
                dataGridView1.DataSource = kitaplar;
                return;
            }

            var filtreli = kitaplar.Where(k =>
                k.Tur.Trim().Equals(secilenTur, StringComparison.OrdinalIgnoreCase)).ToList();

            if (filtreli.Count == 0)
            {
                MessageBox.Show("Bu türe ait kitap bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGridView1.DataSource = filtreli;
        }
        [SupportedOSPlatform("windows6.1")]

        private void btnAra_Click_1(object sender, EventArgs e)
        {
            string aranan = txtAra.Text.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(aranan))
            {
                dataGridView1.DataSource = kitaplar;
                return;
            }

            var filtreli = kitaplar.Where(k =>
                k.Adi.ToLower().Contains(aranan) ||
                k.Yazar.ToLower().Contains(aranan)).ToList();

            if (filtreli.Count == 0)
            {
                MessageBox.Show("Aradığınız kitap bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGridView1.DataSource = filtreli;
        }
    }

   

}