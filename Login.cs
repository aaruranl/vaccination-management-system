using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VMS.Forms
{
    public partial class Login : Form
    {
        newTestvms.dbconnection db = new newTestvms.dbconnection();
        public Login()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "" || bunifuMaterialTextbox2.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-PVBM0T3\\SQLEXPRESS; Initial Catalog=VMS;Integrated Security=true;");
                SqlCommand cmd = new SqlCommand("Select * from login where username=@username and password=@password", con);
                cmd.Parameters.AddWithValue("@username", bunifuMaterialTextbox1.Text);
                cmd.Parameters.AddWithValue("@password", bunifuMaterialTextbox2.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    Forms.Dashboard DB = new Forms.Dashboard();
                    DB.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
                    
      
           
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
