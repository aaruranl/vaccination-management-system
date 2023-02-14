using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newTestvms.ScheduleF
{
    public partial class SchedNew : UserControl
    {
        newTestvms.dbconnection db = new newTestvms.dbconnection();
        public SchedNew()
        {
            InitializeComponent();
        }

        private void SchedNew_Load(object sender, EventArgs e)
        {
            bunifuDataGridView1.DataSource = db.ShowDataInGridView("select nic,name,phoneno,ds from people");
            db.CloseConnection();
             dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy hh:mm:ss";

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //start with datapasing to the datagrid.

            NICBox.Text = bunifuDataGridView1.CurrentRow.Cells["Column1"].Value.ToString(); ;
            NameBox.Text = bunifuDataGridView1.CurrentRow.Cells["Column2"].Value.ToString();
            MobileBox.Text = bunifuDataGridView1.CurrentRow.Cells["Column4"].Value.ToString();
            CenterBox.Text = bunifuDataGridView1.CurrentRow.Cells["Column3"].Value.ToString();
           
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            if (NICBox.Text != "" && NameBox.Text != "" && MobileBox.Text != "" && CenterBox.Text != "" && bunifuDropdown2.Text != "" && dateTimePicker1.Text != "" )
            {


                SqlCommand cmd = db.ExecuteQueries("insert into scheduleList(NIC,P_name,s_date,mobile,Center,Vaccine)values (@NIC,@P_name,@s_date,@mobile,@Center,@Vaccine");

                

                cmd.Parameters.AddWithValue("@NIC", NICBox.Text.ToString());
                cmd.Parameters.AddWithValue("@P_name", NameBox.Text.ToString());
                cmd.Parameters.AddWithValue("@mobile", MobileBox.Text.ToString());
                cmd.Parameters.AddWithValue("@Center", CenterBox.Text.ToString());
                cmd.Parameters.AddWithValue("@s_date", dateTimePicker1.Text.ToString());
                cmd.Parameters.AddWithValue("@Vaccine", bunifuDropdown2.Text.ToString());
 
                cmd.ExecuteNonQuery();
                db.CloseConnection();

                MessageBox.Show("Updated Succefully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bunifuDataGridView1.DataSource = db.ShowDataInGridView("select * from vacstocks");
                resetData();


            }
            else
            {
                MessageBox.Show("Please Fill all the boxes");
            }


        }

        private void resetData()
        {

            NICBox.Text = "";
            NameBox.Text = "";
            MobileBox.Text = "";
            dateTimePicker1.Text = "";
            bunifuDropdown2.Text = "";
            CenterBox.Text = "";
            
        }
    }
}
