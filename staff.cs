using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMS.Forms
{
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }

        private void addcontrols(UserControl uc)
        {

            panel3.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);
            uc.BringToFront();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void staff_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            doctor d = new doctor();
            addcontrols(d);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            nurse n = new nurse();
            addcontrols(n);
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            phi p = new phi();
            addcontrols(p);
        }
    }
}
