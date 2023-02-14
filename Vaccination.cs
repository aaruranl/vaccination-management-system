using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;

namespace VMS
{
    public partial class Vaccination : System.Windows.Forms.Form
    {

        Bunifu.DataViz.DataPoint datapoint1;


        public Vaccination()
        {
            InitializeComponent();
            
        }

        private void Vaccination_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Forms.VCNow VCN = new Forms.VCNow() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            VCN.FormBorderStyle = FormBorderStyle.None;
            ActiveForm.Controls.Add(VCN);

            //Forms.Dashboard.tabPage1.Controls.Add(VC1);
            //VC1.Show();
            //bunifuPages1.SetPage("VaccinationPg");




            /*
            Forms.VCNow VCN = new Forms.VCNow() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            VCN.FormBorderStyle = FormBorderStyle.None;
            this.Hide();
            Forms.Dashboard Newd = new Forms.Dashboard();
            Newd.VacPanel.Controls.Add(VCN);
            Newd.Show();
            */
            
        }

       

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
            datapoint1 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_area);
            Bunifu.DataViz.Canvas canvas = new Bunifu.DataViz.Canvas();
            Random random = new Random();

            datapoint1.addLabely("1", random.Next(0, 50).ToString());
            datapoint1.addLabely("2", random.Next(0, 50).ToString());
            datapoint1.addLabely("3", random.Next(0, 50).ToString());
            datapoint1.addLabely("4", random.Next(0, 50).ToString());
            datapoint1.addLabely("5", random.Next(0, 50).ToString());
            datapoint1.addLabely("6", random.Next(0, 50).ToString());
            datapoint1.addLabely("7", random.Next(0, 50).ToString());
            datapoint1.addLabely("8", random.Next(0, 50).ToString());
            datapoint1.addLabely("9", random.Next(0, 50).ToString());
            datapoint1.addLabely("10", random.Next(0, 50).ToString());
            datapoint1.addLabely("11", random.Next(0, 50).ToString());
            datapoint1.addLabely("12", random.Next(0, 50).ToString());

            canvas.addData(datapoint1);
            bunifuDataViz1.Render(canvas);

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCards1_Paint_3(object sender, PaintEventArgs e)
        {

        }

        private void BunifuButton3_Click(object sender, EventArgs e)
        {
            Forms.Dashboard DB = new Forms.Dashboard();
            DB.Show();
            this.Hide();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            

            Forms.Dashboard DB = new Forms.Dashboard();
            DB.Show();
            this.Hide();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
