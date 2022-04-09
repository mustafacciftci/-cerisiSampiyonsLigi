using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace İcerisiSampiyonsLigi
{
    public partial class Giris : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
   (
       int nLeftRect,
       int nTopRect,
       int nRightRect,
       int nBottomRect,
       int nWidthEllipse,
       int nHeightEllipse
   );
        public Giris()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashBoard.Height;
            pnlNav.Top = btnDashBoard.Top;
            pnlNav.Left = btnDashBoard.Left;
            btnDashBoard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnTakimlar_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnTakimlar.Height;
            pnlNav.Top = btnTakimlar.Top;
            pnlNav.Left = btnTakimlar.Left;
            btnTakimlar.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void btnOyuncular_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnOyuncular.Height;
            pnlNav.Top = btnOyuncular.Top;
            pnlNav.Left = btnOyuncular.Left;
            btnOyuncular.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnRenkler_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnRenkler.Height;
            pnlNav.Top = btnRenkler.Top;
            pnlNav.Left = btnRenkler.Left;
            btnRenkler.BackColor = Color.FromArgb(46, 51, 73);
            

        }
    }
}
