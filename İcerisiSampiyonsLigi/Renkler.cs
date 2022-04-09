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
    public partial class Renkler : Form
    {
        WeAreTheChampionsContex db = new WeAreTheChampionsContex();
        public Renkler()
        {
            InitializeComponent();
            RengiGoruntule();
            RenkListele();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Models.Color renk = new Models.Color();
            renk.ColorName = txtRenkAdi.Text;
            renk.Red = (int)nudR.Value;
            renk.Green = (int)nudR.Value;
            renk.Blue = (int)nudB.Value;
            db.Colors.Add(renk);
            db.SaveChanges();
            RenkListele();

        }

        private void nudR_ValueChanged(object sender, EventArgs e)
        {
            RengiGoruntule();
        }

        private void nudg_ValueChanged(object sender, EventArgs e)
        {
            RengiGoruntule();
        }

        private void nudB_ValueChanged(object sender, EventArgs e)
        {
            RengiGoruntule();
        }
        private void RengiGoruntule()
        {
            int r = (int)nudR.Value;
            int g = (int)nudg.Value;
            int b = (int)nudB.Value;
            pboRenk.BackColor = System.Drawing.Color.FromArgb(r, g, b);
        }

        private void lblAnaMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();

        }
        private void RenkListele()
        {
            lstRenkler.DataSource = db.Colors.ToList();
            lstRenkler.DisplayMember = "ColorName";


        }

        private void lstRenkler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int blue, green, red;
            Models.Color renk = new Models.Color();
            renk = (Models.Color)lstRenkler.SelectedItem;
            blue = renk.Blue;
            green = renk.Green;
            red = renk.Red;
            pboRenk.BackColor = System.Drawing.Color.FromArgb(red, green, blue);


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Models.Color renk = new Models.Color();
            renk = (Models.Color)lstRenkler.SelectedItem;
            db.Colors.Remove(renk);
            db.SaveChanges();
            RenkListele();
        }
    }
}

