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
    public partial class CanlıFikstür : Form
    {
        WeAreTheChampionsContex db = new WeAreTheChampionsContex();
        public CanlıFikstür()
        {
            InitializeComponent();
            bunifuDataGridView1.AutoGenerateColumns = false;
            bunifuDataGridView1.DataSource = db.Matches.Where(x => x.Score1 == null).ToList();

        }

        private void lblAnaMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Match secili = (Match)bunifuDataGridView1.SelectedRows[0].DataBoundItem;
            
            if (secili.MatchDate.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Henüz Maç Oynanmadı");
            }
            else
            {
                secili.Score1 = (int)numericUpDown1.Value;
                secili.Score2 = (int)numericUpDown2.Value;

                bunifuDataGridView1.DataSource = db.Matches.Where(x => x.Score1 == null).ToList();
                if (numericUpDown1.Value > numericUpDown2.Value)
                {
                    secili.Team1.Point += 3;

                    secili.Result = Result.Team1Wins;
                }
                else if (numericUpDown2.Value > numericUpDown1.Value)
                {
                    secili.Team2.Point += 3;
                    secili.Result = Result.Team2Wins;

                }
                else
                {
                    secili.Team1.Point += 1;
                    secili.Team2.Point += 1;
                    secili.Result = Result.Evenly;
                }
                db.SaveChanges();
            }

        }
    }
}
