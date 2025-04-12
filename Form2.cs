using KutuphaneOtomasyonu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show(); // yeni formu açar
            this.Hide();  // şu anki formu gizler

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();    // yeni formu açar
            this.Hide();     // şu anki formu gizler
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

           
            form4.Show();

            
            this.Hide();
        }

        private void btnEmanetEkle_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();

            
            form5.Show();

            
            this.Hide();
        }
    }
}
