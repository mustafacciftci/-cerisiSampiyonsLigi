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
    public partial class MatchEkrani : Form
    {
        WeAreTheChampionsContex db = new WeAreTheChampionsContex();
        public MatchEkrani()
        {
            InitializeComponent();
            cmbTeam1inMatch.DataSource = db.Teams.ToList();
            cmbTeam2inMatch.DataSource = db.Teams.ToList();
            Listele();
            // SkorAyari();
        }

        private void SkorAyari()
        {
            if (dtpDate.Value > DateTime.Now)
            {
                nudDeplasman.Enabled = false;
                nudEv.Enabled = false;

            }
            else
            {
                nudDeplasman.Enabled = true;
                nudEv.Enabled = true;

            }
        }

        private void lblAnaMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            if (cmbTeam1inMatch.SelectedItem == cmbTeam2inMatch.SelectedItem)
            {
                MessageBox.Show("Takım Kendi İle Maç Yapamaz");


            }
            else
            {

                Match match = new Match();
                var takim1 = (Team)cmbTeam1inMatch.SelectedItem;
                var takim2 = (Team)cmbTeam2inMatch.SelectedItem;
                match.MatchDate = dtpDate.Value;
                match.MatchTime = dtpTime.Value;
                match.Team1 = takim1;
                match.Team2 = takim2;

                if (dtpDate.Value < DateTime.Now)
                {
                    match.Score1 = (int)nudEv.Value;
                    match.Score2 = (int)nudDeplasman.Value;

                }
                else
                {
                    match.Score1 = null;
                    match.Score2 = null;
                    match.Result = null;

                }
                if (nudEv.Value > nudDeplasman.Value)
                {
                    match.Result = Result.Team1Wins;
                    takim1.Point += 3;

                }
                else if (nudDeplasman.Value > nudEv.Value)
                {
                    match.Result = Result.Team2Wins;
                    takim2.Point += 3;
                }
                else if (nudEv.Value == -1)
                {
                    takim1.Point += 0;
                    takim2.Point += 0;

                }
                else if (nudEv.Value != 0)
                {
                    if (nudEv.Value == nudDeplasman.Value)
                    {

                        match.Result = Result.Evenly;
                        takim1.Point += 1;
                        takim2.Point += 1;
                    }

                }
                db.Matches.Add(match);
                db.SaveChanges();
                Listele();
            }
        }

        private void Listele()
        {
            bunifuDataGridView1.DataSource = db.Matches.Where(x => x.Score1 != null).ToList();
        }

        private void cmbTeam1inMatch_SelectedIndexChanged(object sender, EventArgs e)
        {

            var takim1 = (Team)cmbTeam1inMatch.SelectedItem;
            pboEv.ImageLocation = takim1.Amblem;

        }

        private void cmbTeam2inMatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            var takim1 = (Team)cmbTeam2inMatch.SelectedItem;
            pboDeplasman.ImageLocation = takim1.Amblem;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            SkorAyari();
        }
    }
}
