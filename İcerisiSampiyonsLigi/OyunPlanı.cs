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
    public partial class OyunPlanı : Form
    {
        WeAreTheChampionsContex db = new WeAreTheChampionsContex();
        public OyunPlanı()
        {
            InitializeComponent();
            comboBox1.DataSource = db.Teams.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Team team = new Team();
            team = (Team)comboBox1.SelectedItem;

            dgvOyunPlanı.DataSource = team.Players.OrderBy(x => x.Mevkii).ToList();

            Player player = new Player();
            for (int i = 1; i <= 11; i++)
            {
                player = (Player)dgvOyunPlanı.Rows[i-1].DataBoundItem;
                if (i == 1)
                {
                    pbo1.ImageLocation = player.Resim;
                }
                else if (i == 2)
                {
                    pbo2.ImageLocation = player.Resim;

                }
                else if (i == 3)
                {
                    pbo3.ImageLocation = player.Resim;
                }
                else if (i == 4)
                {
                    pbo4.ImageLocation = player.Resim;
                }
                else if (i == 5)
                {
                    pbo5.ImageLocation = player.Resim;
                }
                else if (i == 6)
                {
                    pbo6.ImageLocation = player.Resim;
                }
                else if (i == 7)
                {
                    pbo7.ImageLocation = player.Resim;
                }
                else if (i == 8)
                {
                    pbo8.ImageLocation = player.Resim;
                }
                else if (i == 9)
                {
                    pbo9.ImageLocation = player.Resim;
                }
                else if (i == 10)
                {
                    pbo10.ImageLocation = player.Resim;
                }
                else if (i == 11)
                {
                    pbo11.ImageLocation = player.Resim;
                }



            }



        }



        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Team team = new Team();
            dgvOyunPlanı.DataSource = team.Players.ToList();
        }
    }
}
