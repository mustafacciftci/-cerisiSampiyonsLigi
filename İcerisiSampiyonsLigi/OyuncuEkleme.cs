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
    public partial class OyuncuEkleme : Form
    {
        WeAreTheChampionsContex db = new WeAreTheChampionsContex();
        public OyuncuEkleme()
        {
            InitializeComponent();
            cmbTakimlar.DataSource = db.Teams.ToList();
            dgvOyuncular.AutoGenerateColumns = false;
            Listele();
            // Excel Expot 
            // Tabloları expoet et 
            // fotor mu 

        }

        private void Listele()
        {
            dgvOyuncular.DataSource = db.Players.ToList();
            cmbDuzTakım.DataSource = db.Teams.ToList();
        }

        private void lblAnaMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnOyunucEkle_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            player.PlayerName = txtOyuncuAdi.Text;
            player.Mevkii = Convert.ToInt32(txtmevkii.Text);
            Team team = (Team)cmbTakimlar.SelectedItem;
            player.TeamId = team.Id;
            player.Resim = txtResim.Text;
            db.Players.Add(player);
            db.SaveChanges();
            Listele();

        }

        private void cmbTakimlar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void btnOyuncuDuzenle_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            player = (Player)dgvOyuncular.SelectedRows[0].DataBoundItem;
            player.Mevkii = Convert.ToInt32(txtduzMevki.Text);
            player.PlayerName = txtdüzOyuncuAd.Text;
            player.Resim = txtDuzResim.Text;

            db.SaveChanges();
            Listele();
        }

        private void dgvOyunculars_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOyuncular.SelectedRows.Count > 0)
            {
                Player player = new Player();
                player = (Player)dgvOyuncular.SelectedRows[0].DataBoundItem;
                txtdüzOyuncuAd.Text = player.PlayerName;
                txtDuzResim.Text = player.Resim;
                txtduzMevki.Text = player.Mevkii.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player player2 = new Player();
            player2 = (Player)dgvOyuncular.SelectedRows[0].DataBoundItem;
            db.Players.Remove(player2);
            db.SaveChanges();
            Listele();


        }
    }
}
