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

namespace newTestvms.Stocks
{
    public partial class StockDashCon : UserControl
    {

        newTestvms.dbconnection db = new newTestvms.dbconnection();
        public StockDashCon()
        {
            InitializeComponent();
        }

        private void MedEqStockBTN_Click(object sender, EventArgs e)
        {

        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            //vacstocksBindingSource.AddNew();
            if (IDBox.Text != "" && NameBox.Text != "" && BrandBox.Text != "" && dosageBox.Text != "" && LotBox.Text != "" && StockCapBox.Text != "" && IssueCapBox.Text != "" && AvaiCapBox.Text != ""){

                
                SqlCommand cmd = db.ExecuteQueries("insert into vacstocks(v_id,v_name,brand,dosage,lot_number,v_capacity,v_issued,v_availability)VALUES(@v_id,@v_name,@brand,@dosage,@lot_number,@v_capacity,@v_issued,@v_availability)");

                cmd.Parameters.AddWithValue("@v_id", IDBox.Text.ToString());
                cmd.Parameters.AddWithValue("@v_name", NameBox.Text.ToString());
                cmd.Parameters.AddWithValue("@brand", BrandBox.Text.ToString());
                cmd.Parameters.AddWithValue("@dosage", dosageBox.Text.ToString());
                cmd.Parameters.AddWithValue("@lot_number", LotBox.Text.ToString());
                cmd.Parameters.AddWithValue("@v_capacity", StockCapBox.Text.ToString());
                cmd.Parameters.AddWithValue("@v_issued", IssueCapBox.Text.ToString());
                cmd.Parameters.AddWithValue("@v_availability", AvaiCapBox.Text.ToString());

                cmd.ExecuteNonQuery();
                db.CloseConnection();

                MessageBox.Show("Added Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bunifuDataGridView1.DataSource = db.ShowDataInGridView("select * from vacstocks");
                resetData();


            }
            else
            {
                MessageBox.Show("Please Fill all the boxes");
            }



        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            //vacstocksBindingSource.EndEdit();
            //vacstocksTableAdapter.Update(vMSDataSet.vacstocks);
            if (IDBox.Text != "" && NameBox.Text != "" && BrandBox.Text != "" && dosageBox.Text != "" && LotBox.Text != "" && StockCapBox.Text != "" && IssueCapBox.Text != "" && AvaiCapBox.Text != "")
            {


                SqlCommand cmd = db.ExecuteQueries("update vacstocks set v_id=@v_id,v_name=@v_name,brand=@brand,dosage=@dosage,lot_number=@lot_number,v_capacity=@v_capacity,v_issued=@v_issued,v_availability=@v_availability where v_id=@v_id");

                cmd.Parameters.AddWithValue("@v_id", IDBox.Text.ToString());
                cmd.Parameters.AddWithValue("@v_name", NameBox.Text.ToString());
                cmd.Parameters.AddWithValue("@brand", BrandBox.Text.ToString());
                cmd.Parameters.AddWithValue("@dosage", dosageBox.Text.ToString());
                cmd.Parameters.AddWithValue("@lot_number", LotBox.Text.ToString());
                cmd.Parameters.AddWithValue("@v_capacity", StockCapBox.Text.ToString());
                cmd.Parameters.AddWithValue("@v_issued", IssueCapBox.Text.ToString());
                cmd.Parameters.AddWithValue("@v_availability", AvaiCapBox.Text.ToString());

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

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            //vacstocksBindingSource.RemoveCurrent();
            if (IDBox.Text != "")
            {

                try
                {

                    SqlCommand cmd = db.ExecuteQueries("delete vacstocks where v_id=@v_id");

                    cmd.Parameters.AddWithValue("@v_id", IDBox.Text.ToString());



                    DialogResult result = MessageBox.Show("Are you sure you Delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted Sucessfully", "DELETED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    db.CloseConnection();
                    bunifuDataGridView1.DataSource = db.ShowDataInGridView("select * from vacstocks");
                    resetData();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Error ");
                }
            }
            else
            {
                MessageBox.Show("Select the record to be deleted from the table", "MESSAGE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }

        private void StockDashCon_Load(object sender, EventArgs e)
        {
            bunifuDataGridView1.DataSource = db.ShowDataInGridView("select * from vacstocks");
            db.CloseConnection();
        }

        private void resetData()
        {

            IDBox.Text = "";
            NameBox.Text = "";
            BrandBox.Text = "";
            dosageBox.Text = "";
            LotBox.Text = "";
            StockCapBox.Text = "";
            IssueCapBox.Text = "";
            AvaiCapBox.Text = "";
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDBox.Text = bunifuDataGridView1.CurrentRow.Cells["v_id"].Value.ToString(); ;
            NameBox.Text = bunifuDataGridView1.CurrentRow.Cells["v_name"].Value.ToString();  
            BrandBox.Text = bunifuDataGridView1.CurrentRow.Cells["V_Brand"].Value.ToString();
            dosageBox.Text = bunifuDataGridView1.CurrentRow.Cells["V_dosage"].Value.ToString();
            LotBox.Text = bunifuDataGridView1.CurrentRow.Cells["V_lot"].Value.ToString();
            StockCapBox.Text = bunifuDataGridView1.CurrentRow.Cells["V_StCap"].Value.ToString();
            IssueCapBox.Text = bunifuDataGridView1.CurrentRow.Cells["V_IssuCap"].Value.ToString();
            AvaiCapBox.Text = bunifuDataGridView1.CurrentRow.Cells["V_avaiCap"].Value.ToString();      

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            resetData();
        }
    }
}
