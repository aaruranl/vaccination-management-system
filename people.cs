using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        newTestvms.dbconnection db = new newTestvms.dbconnection();

        public Form1()
        {
            InitializeComponent();
            string[] Northern =new string[] { "Jaffna", "Vavuniya", "Mannar" };

           
        }

        private bool checkEmpty()
        {
            if (textBox6.Text == "" || textBox1.Text == "" || maskedTextBox1.Text == "" || textBox4.Text == "" || richTextBox1.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
            {
                return true;

            }
            return false;

        }

        private void resetData()
        {
            textBox6.Text = "";
            textBox1.Text = "";
            bunifuDatepicker1.Value = DateTime.Today;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            maskedTextBox1.Text = "";
            textBox4.Text = "";
            richTextBox1.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;

        }

        static Regex validate_emailaddress = email_validation();
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ShowDataInGridView("select * from people");
            db.CloseConnection();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (checkEmpty() == false)
            {
                if (validate_emailaddress.IsMatch(textBox4.Text) != true)
                {
                    MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox4.Focus();
                    textBox4.Clear();

                    return;
                }

                string gender;
                if (radioButton1.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }

                try
                {

                    SqlCommand cmd = db.ExecuteQueries("Insert into people(nic, name, dob, gender, phoneno, email, address, province, district, ds)  values(@nic, @name, @dob, @gender, @phoneno, @email, @address, @province, @district, @ds)");

                   
                    cmd.Parameters.AddWithValue("@nic", textBox6.Text.ToString());
                    cmd.Parameters.AddWithValue("@name", textBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@dob", bunifuDatepicker1.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@phoneno", maskedTextBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@email", textBox4.Text.ToString());

                    cmd.Parameters.AddWithValue("@address", richTextBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@province", comboBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@district", comboBox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@ds", comboBox3.Text.ToString());


                    cmd.ExecuteNonQuery();
                    db.CloseConnection();
                    MessageBox.Show("Added Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = db.ShowDataInGridView("select * from people");
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text.ToString() == "Jaffna")
            {
                string[] jds = new string[] { "Delft","Island North","Island South","Jaffna","Karainagar","Nallur","Thenmaradchi","Vadamaradchi East","Vadamaradchi North","Vadamaradchi South-West","Valikamam East","Valikamam North","Valikamam South","Valikamam South-West","Valikamam West"};
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(jds);

            }
            if (comboBox2.Text.ToString() == "Vavuniya")
            {
                string[] vds = new string[] { "Vavuniya","Vavuniya North","Vavuniya South","Vengalacheddikulam"};
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(vds);
            }
            if (comboBox2.Text.ToString() == "Kilinochchi")
            {
                string[] kds = new string[] { "Kandavalai", "Karachchi", "Pachchilaipalli", "Poonakary" };
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(kds);
            }
            if (comboBox2.Text.ToString() == "Mannar")
            {
                string[] mds = new string[] { "Madhu", "Mannar", "Manthai West", "Musalai", "Nanaddan" };
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(mds);
            }


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.ToString() == "Nothern Province")
            {
                string[] nothern = new string[] { "Jaffna", "Vavuniya", "Mannar", "Mullaithevu", "Kilinochi" };
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(nothern);

            }
            if (comboBox1.Text.ToString() == "Western Province")
            {
                string[] western = new string[] { "Colombo", "Gampaha", "Kalutara"};
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(western);

            }
            if (comboBox1.Text.ToString() == "Uva Province")
            {
                string[] uva = new string[] { "Baddulla", "Moneragala" };
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(uva);

            }
            if (comboBox1.Text.ToString() == "Central Province")
            {
                string[] central = new string[] { "Kandy", "Matale", "Nuwara Eliya" };
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(central);

            }
            if (comboBox1.Text.ToString() == "Eastern Province")
            {
                string[] Eastern= new string[] { "Ampara", "Baticaloa", "Trincomalee" };
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(Eastern);

            }
            if (comboBox1.Text.ToString() == "NorthCentral Province")
            {
                string[] NorthCentre = new string[] { "Anuradhapura", "Polannaruwa" };
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(NorthCentre);

            }
            if (comboBox1.Text.ToString() == "NorthWest Province")
            {
                string[] NorthWest = new string[] { "Kurunegala", "Puttalam" };
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(NorthWest);

            }
            if (comboBox1.Text.ToString() == "Sabaragamuwa Province")
            {
                string[] Sabaragamuwa = new string[] { "Kegalle", "Ratnapura" };
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(Sabaragamuwa);

            }
            if (comboBox1.Text.ToString() == "Southern Province")
            {
                string[] Southern = new string[] { "Galle", "Hambantota", "Matara"};
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(Southern);

            }



        }

        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
            maskedTextBox1.Select(0,0);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {

                try
                {

                    SqlCommand cmd = db.ExecuteQueries("delete people where nic=@nic");

                    cmd.Parameters.AddWithValue("@nic", textBox6.Text.ToString());


                    DialogResult result = MessageBox.Show("Are you sure you Delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Deleted Sucessfully", "DELETED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    db.CloseConnection();
                    dataGridView1.DataSource = db.ShowDataInGridView("select * from people");
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkEmpty() == false)
            {

                if (validate_emailaddress.IsMatch(textBox4.Text) != true)
                {
                    MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox4.Focus();
                    textBox4.Clear();

                    return;
                }

                string gender;
                if (radioButton1.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }

                try
                {

                    SqlCommand cmd = db.ExecuteQueries("update people set nic=@nic, name=@name, dob=@dob, gender=@gender, phoneno=@phoneno, email=@email, address=@address, province=@province, district=@district, ds=@ds   where nic=@nic");

                    cmd.Parameters.AddWithValue("@nic", textBox6.Text.ToString());
                    cmd.Parameters.AddWithValue("@name", textBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@dob", bunifuDatepicker1.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@phoneno", maskedTextBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@email", textBox4.Text.ToString());

                    cmd.Parameters.AddWithValue("@address", richTextBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@province", comboBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@district", comboBox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@ds", comboBox3.Text.ToString());

                    cmd.ExecuteNonQuery();
                    db.CloseConnection();
                    MessageBox.Show("Updated Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = db.ShowDataInGridView("select * from people");
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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            textBox6.Text = dataGridView1.CurrentRow.Cells["nic"].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
            bunifuDatepicker1.Text = dataGridView1.CurrentRow.Cells["dob"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["gender"].Value.ToString() == "Male")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;

            }
            else
            {
                radioButton2.Checked = true;
                radioButton1.Checked = false;
            }
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells["phoneno"].Value.ToString();

            textBox4.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells["address"].Value.ToString();


            comboBox1.Text = dataGridView1.CurrentRow.Cells["province"].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells["district"].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells["ds"].Value.ToString();




        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                MessageBox.Show("Please Enter the NIC!");
            }
            else
            {
                string query = "select * from people where nic = '" + textBox8.Text + "'";
                dataGridView1.DataSource = db.ShowDataInGridView(query);
                db.CloseConnection();
            }
        }
    }
}
