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
using Color = İcerisiSampiyonsLigi.Models.Color;

namespace İcerisiSampiyonsLigi
{
    public partial class Takimlar : Form
    {
        WeAreTheChampionsContex db = new WeAreTheChampionsContex();
        public Takimlar()
        {
            InitializeComponent();
            listele();
            bunifuDataGridView1.AutoGenerateColumns = false;
            bunifuDataGridView1.DataSource = db.Teams.ToList();
            bool duzenle;
        }

        private void listele()
        {
            bunifuDataGridView1.AutoGenerateColumns = false;
            bunifuDataGridView1.DataSource = db.Teams.ToList();
            cmbColorinTeamsColor.DataSource = db.Colors.ToList();
            cmbTeamsinTeamColors.DataSource = db.Teams.ToList();
        }

        private void btnTakimEkle_Click(object sender, EventArgs e)
        {
            Team takim = new Team();
            takim.TeamName = txtTakimAdi.Text;
            takim.Amblem = txtAmblem.Text;
            
            db.Teams.Add(takim);
            db.SaveChanges();
            listele();

        }

        private void btnTakımaRenk_Click(object sender, EventArgs e)
        {

            Color color = (Color)cmbColorinTeamsColor.SelectedItem;
            Team team = (Team)cmbTeamsinTeamColors.SelectedItem;
            if (db.TeamColors.Any(x => (x.TeamId == team.Id) && (x.ColorId == color.Id)))
            {
                MessageBox.Show($"{color.ColorName} rengi zaten  {team.TeamName}'a ekli ");
                return;
            }
            db.TeamColors.Add(new TeamColor() { ColorId = color.Id, TeamId = team.Id });
            db.SaveChanges();
            listele();
        }

        private void lblAnaMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Team takim = (Team)bunifuDataGridView1.SelectedRows[0].DataBoundItem;
            db.Teams.Remove(takim);
            db.SaveChanges();
            listele();
        }

        private void bntDuzenle_Click(object sender, EventArgs e)
        {
            Team takim = (Team)bunifuDataGridView1.SelectedRows[0].DataBoundItem;
            takim.TeamName = txtDuzenleTakimAdi.Text;
            takim.Amblem = txtAmblemDuzenle.Text;
            db.SaveChanges();
            listele();

        }

        private void bunifuDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (bunifuDataGridView1.SelectedRows.Count > 0)
            {
            Team takim = (Team)bunifuDataGridView1.SelectedRows[0].DataBoundItem;
            txtDuzenleTakimAdi.Text = takim.TeamName;

            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            OyunPlanı oyunPlanı = new OyunPlanı();
            oyunPlanı.ShowDialog();

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            OyunPlanı oyunPlanı = new OyunPlanı();
            oyunPlanı.ShowDialog();
        }
    }
}
