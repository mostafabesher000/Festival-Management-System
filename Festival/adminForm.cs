using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Festival
{
    public partial class adminForm : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;persistsecurityinfo=True;database=festivalmanagement;password=27439510");

        public adminForm()
        {
            InitializeComponent();
            refreshdata();
        }

        private void refreshdata()
        {

           
            MySqlCommand cmd = new MySqlCommand("requested_events", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.datagridviewevt.DataSource = dt;
        }

        private void btnapprove_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("approve_event", con);
                cmd.CommandType = CommandType.StoredProcedure;
               // this.datagridviewevt.CurrentRow.Cells[0].Value.ToString()
                cmd.Parameters.Add(new MySqlParameter("p_eventname", this.datagridviewevt.CurrentRow.Cells[0].Value.ToString()));

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Approved");

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
  
            }
        }

        private void btndisapprove_Click(object sender, EventArgs e)
        {

            try
            {

                MySqlCommand cmd = new MySqlCommand("disapprove_event", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new MySqlParameter("p_eventname", this.datagridviewevt.CurrentRow.Cells[0].Value.ToString()));

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Deleted");

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();

            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            refreshdata();
        }
    }
}
