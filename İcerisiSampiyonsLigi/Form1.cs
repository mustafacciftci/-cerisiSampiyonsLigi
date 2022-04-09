using İcerisiSampiyonsLigi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İcerisiSampiyonsLigi
{
    public partial class Form1 : Form
    {
        WeAreTheChampionsContex db = new WeAreTheChampionsContex();
        public Form1()
        {
            InitializeComponent();
        
           
           
        }

        private void btnMac_Click(object sender, EventArgs e)
        {
            MatchEkrani matchEkrani = new MatchEkrani();
            this.Hide();
            matchEkrani.ShowDialog();
        }

        private void btnOyuncu_Click(object sender, EventArgs e)
        {
            OyuncuEkleme oyuncuEkleme = new OyuncuEkleme();
            this.Hide();
            oyuncuEkleme.ShowDialog();

        }

        private void btnTakim_Click(object sender, EventArgs e)
        {
            Takimlar takimlar = new Takimlar();
            this.Hide();
            takimlar.ShowDialog();

        }

        private void btnPuan_Click(object sender, EventArgs e)
        {
            PuanDurumu puanDurumu = new PuanDurumu();
            this.Hide();
            puanDurumu.ShowDialog();

        }

        private void btnFikstür_Click(object sender, EventArgs e)
        {
            CanlıFikstür canlıFikstür = new CanlıFikstür();
            this.Hide();
            canlıFikstür.ShowDialog();

        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            Renkler renkler = new Renkler();
            this.Hide();
            renkler.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.ShowDialog();
        }
    }
}
