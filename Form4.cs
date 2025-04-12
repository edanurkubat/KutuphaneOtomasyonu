using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Form4 : Form
    {
        private List<Uye> uyeler;

        public Form4()
        {
            InitializeComponent();
            UyeListesiniYukle();
        }
        private void UyeListesiniYukle()
        {
            uyeler = new List<Uye>
            {
                new Uye { Id = 1, Ad = "Helin", Soyad = "Dağ", Telefon = "05446546576", Eposta = "helindaq@gmail.com" },
                new Uye { Id = 2, Ad = "Ebru", Soyad = "Dalkıran", Telefon = "05432348790", Eposta = "ebrudlkrn@gmail.com" },
                new Uye { Id = 3, Ad = "Edanur", Soyad = "Kubat", Telefon = "05445546956", Eposta = "edanurkubat@gmail" },
                new Uye { Id = 4, Ad = "İclal", Soyad = "Özden", Telefon = "05645678992", Eposta = "iclalozden@gmail.com" },
                new Uye { Id = 5, Ad = "Melisa", Soyad = "Saatçi", Telefon = "05678978976", Eposta = "melisaatci@gmail" },
                new Uye { Id = 6, Ad = "Ali", Soyad = "Bayındır", Telefon = "05443456789", Eposta = "alibyndr@gmail.com" },
                new Uye { Id = 7, Ad = "Mehmet Ali", Soyad = "Erbil", Telefon = "05443324567", Eposta = "mehmetalierbil@gmail.com" },
                new Uye { Id = 8, Ad = "Ekrem", Soyad = "İmamoğlu", Telefon = "05448908765", Eposta = "ekremimaro@gmail.com" },
                new Uye { Id = 9, Ad = "Meryem", Soyad = "Sevindik", Telefon = "05876789808", Eposta = "merysevindik@gmail.com" },
                new Uye { Id = 10, Ad = "Recep Tayip", Soyad = "Erdoğan", Telefon = "05446789808", Eposta = "tayip@gmail.com" },
                new Uye { Id = 11, Ad = "Beyza", Soyad = "Şeker", Telefon = "05326789077", Eposta = "beyzaseker@gmail.com" },
                new Uye { Id = 12, Ad = "Edanur", Soyad = "Uslu", Telefon = "05678900099", Eposta = "edanuruslu@gmail.com" },
                new Uye { Id = 13, Ad = "Ebrar", Soyad = "Doğru", Telefon = "05443346700", Eposta = "ebrardogru@gmail.com" },
                new Uye { Id = 14, Ad = "Devlet", Soyad = "Bahçeli", Telefon = "05678908766", Eposta = "devletbahceli@gmail.com" },
                new Uye { Id = 15, Ad = "Nehir Zeynep", Soyad = "Yıldırım", Telefon = "05678904312", Eposta = "nehiryildirim@gmail.com" },
                new Uye { Id = 16, Ad = "Kadriye Sude", Soyad = "Kırk", Telefon = "05431236700", Eposta = "ksudekirk@gmail.com" }
            };

            dataGridView1.DataSource = uyeler;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranan = txtAra.Text.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(aranan))
            {
                dataGridView1.DataSource = uyeler;
                return;
            }

            var filtreli = uyeler.Where(k =>
                k.Ad.ToLower().Contains(aranan) ||
                k.Soyad.ToLower().Contains(aranan)).ToList();

            if (filtreli.Count == 0)
            {
                MessageBox.Show("Aradığınız kişi bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGridView1.DataSource = filtreli;


            if (filtreli.Count == 0)
                MessageBox.Show("Aradığın kişi bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


       

        private void Form4_Load(object sender, EventArgs e)
        {
            UyeListesiniYukle();
            dataGridView1.AutoGenerateColumns = true;

        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private static object GetDebuggerDisplay()
        {
            throw new NotImplementedException();
        }
    }
    
}
