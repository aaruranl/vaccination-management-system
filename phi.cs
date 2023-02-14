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
using System.Text.RegularExpressions;

namespace VMS
{
    public partial class phi : UserControl
    {
        newTestvms.dbconnection db = new newTestvms.dbconnection();

        static Regex validate_emailaddress = email_validation();
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        private bool checkEmpty()
        {
            if (maskedTextBox1.Text == "" ||bunifuCustomTextbox2.Text == "" || bunifuCustomTextbox6.Text == "" || richTextBox1.Text == "" || richTextBox2.Text == "" || bunifuCustomTextbox3.Text == "" || maskedTextBox2.Text == "" || bunifuCustomTextbox5.Text == "")
            {
                return true;

            }
            return false;

        }

        private void resetData()
        {
            maskedTextBox1.Text = "";
            
            bunifuCustomTextbox2.Text = "";
            bunifuCustomTextbox6.Text = "";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            bunifuRadioButton1.Checked = true;
            bunifuRadioButton2.Checked = false;
            bunifuCustomTextbox3.Text = "";
            bunifuDatepicker1.Value = DateTime.Today;
            maskedTextBox2.Text = "";
            bunifuCustomTextbox5.Text = "";

        }

        public phi()
        {
            InitializeComponent();
        }

        private void phi_Load(object sender, EventArgs e)
        {
            bunifuDataGridView1.DataSource = db.ShowDataInGridView("select * from phi");
            db.CloseConnection();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

            if (checkEmpty() == false)
            {
                if (validate_emailaddress.IsMatch(bunifuCustomTextbox5.Text) != true)
                {
                    MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    bunifuCustomTextbox5.Focus();
                    bunifuCustomTextbox5.Clear();

                    return;
                }

                string gender;
                if (bunifuRadioButton1.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }

                try
                {

                    SqlCommand cmd = db.ExecuteQueries("Insert into phi(p_id, f_name, l_name, qualification, address, gender, nic, dob, phoneno, email)  values(@p_id, @f_name, @l_name, @qualification, @address, @gender, @nic, @dob, @phoneno, @email)");



           
                    cmd.Parameters.AddWithValue("@p_id", maskedTextBox1.Text.ToString());
                    
                    cmd.Parameters.AddWithValue("@f_name", bunifuCustomTextbox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@l_name", bunifuCustomTextbox6.Text.ToString());
                    cmd.Parameters.AddWithValue("@qualification", richTextBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@address", richTextBox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@nic", bunifuCustomTextbox3.Text.ToString());
                    cmd.Parameters.AddWithValue("@dob", bunifuDatepicker1.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@phoneno", maskedTextBox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@email", bunifuCustomTextbox5.Text.ToString());


                    cmd.ExecuteNonQuery();
                    db.CloseConnection();
                    MessageBox.Show("Added Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bunifuDataGridView1.DataSource = db.ShowDataInGridView("select * from phi");
                    resetData();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {

            if (checkEmpty() == false)
            {
                if (validate_emailaddress.IsMatch(bunifuCustomTextbox5.Text) != true)
                {
                    MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    bunifuCustomTextbox5.Focus();
                    bunifuCustomTextbox5.Clear();

                    return;
                }

                string gender;
                if (bunifuRadioButton1.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }

                try
                {

                    SqlCommand cmd = db.ExecuteQueries("update phi set p_id=@p_id, f_name=@f_name, l_name=@l_name, qualification=@qualification, address=@address, gender=@gender, nic=@nic, dob=@dob, phoneno=@phoneno, email=@email where p_id=@p_id");



                   
                    cmd.Parameters.AddWithValue("@p_id", maskedTextBox1.Text.ToString());
                    
                    cmd.Parameters.AddWithValue("@f_name", bunifuCustomTextbox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@l_name", bunifuCustomTextbox6.Text.ToString());
                    cmd.Parameters.AddWithValue("@qualification", richTextBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@address", richTextBox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@nic", bunifuCustomTextbox3.Text.ToString());
                    cmd.Parameters.AddWithValue("@dob", bunifuDatepicker1.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@phoneno", maskedTextBox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@email", bunifuCustomTextbox5.Text.ToString());


                    cmd.ExecuteNonQuery();
                    db.CloseConnection();
                    MessageBox.Show("Updated Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bunifuDataGridView1.DataSource = db.ShowDataInGridView("select * from phi");
                    resetData();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "P_")
            {

                try
                {

                    SqlCommand cmd = db.ExecuteQueries("delete phi where p_id=@p_id");

                    cmd.Parameters.AddWithValue("@p_id", maskedTextBox1.Text.ToString());
                    
                    

                    DialogResult result = MessageBox.Show("Are you sure you Delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted Sucessfully", "DELETED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    db.CloseConnection();
                    bunifuDataGridView1.DataSource = db.ShowDataInGridView("select * from phi");
                    resetData();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Select the record to be deleted from the table", "MESSAGE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            maskedTextBox1.Text = bunifuDataGridView1.CurrentRow.Cells["p_id"].Value.ToString();
            
            bunifuCustomTextbox2.Text = bunifuDataGridView1.CurrentRow.Cells["f_name"].Value.ToString();
            bunifuCustomTextbox6.Text = bunifuDataGridView1.CurrentRow.Cells["l_name"].Value.ToString();
            richTextBox1.Text = bunifuDataGridView1.CurrentRow.Cells["qualification"].Value.ToString();
            richTextBox2.Text = bunifuDataGridView1.CurrentRow.Cells["address"].Value.ToString();
            if (bunifuDataGridView1.CurrentRow.Cells["gender"].Value.ToString() == "Male")
            {
                bunifuRadioButton1.Checked = true;
                bunifuRadioButton2.Checked = false;

            }
            else
            {
                bunifuRadioButton2.Checked = true;
                bunifuRadioButton1.Checked = false;
            }

            bunifuCustomTextbox3.Text = bunifuDataGridView1.CurrentRow.Cells["nic"].Value.ToString();
            bunifuDatepicker1.Text = bunifuDataGridView1.CurrentRow.Cells["dob"].Value.ToString();
            maskedTextBox2.Text = bunifuDataGridView1.CurrentRow.Cells["phoneno"].Value.ToString();
            bunifuCustomTextbox5.Text = bunifuDataGridView1.CurrentRow.Cells["email"].Value.ToString();

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (bunifuCustomTextbox7.Text == "")
            {
                MessageBox.Show("Please Enter the Doctor ID or NIC!");
            }
            else
            {
                string query = "select * from phi where p_id='" + bunifuCustomTextbox7.Text + "' OR nic = '" + bunifuCustomTextbox7.Text + "'";
                bunifuDataGridView1.DataSource = db.ShowDataInGridView(query);
                db.CloseConnection();
            }
        }
    }
}
