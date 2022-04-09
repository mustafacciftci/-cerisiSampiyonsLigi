using İcerisiSampiyonsLigi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İcerisiSampiyonsLigi
{
    public partial class PuanDurumu : Form
    {
        WeAreTheChampionsContex db = new WeAreTheChampionsContex();
        public PuanDurumu()
        {
            InitializeComponent();
            dgvPuanDurumu.AutoGenerateColumns = false;
            bunifuDataGridView1.AutoGenerateColumns = false;
            listele();
            listele2();
        }
        private void listele2()
        {
            bunifuDataGridView1.DataSource = db.Teams.OrderByDescending(x => x.Point).ToList();
           

        }

        private void listele()
        {
            dgvPuanDurumu.DataSource = db.Teams.OrderByDescending(x => x.Point).ToList();
            
        }

        private void lblAnaMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

    }
}
