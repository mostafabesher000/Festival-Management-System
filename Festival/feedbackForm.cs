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
    public partial class feedbackForm : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;persistsecurityinfo=True;database=festivalmanagement;password=27439510");

        public feedbackForm()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {

            try
            {

                MySqlCommand cmd = new MySqlCommand("feedback", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("p_username",txtboxusername.Text));
                cmd.Parameters.Add(new MySqlParameter("EventName", txtboxevtname.Text));
                cmd.Parameters.Add(new MySqlParameter("p_message", richtxtboxfeedback.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Feedback is Submitted", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
                vistorForm visform = new vistorForm();
                visform.Show();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
