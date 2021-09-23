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
    public partial class discountForm : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;persistsecurityinfo=True;database=festivalmanagement;password=27439510");

        public discountForm()
        {
            InitializeComponent();
        }

        private void btnpost_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlCommand cmd = new MySqlCommand("discount", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new MySqlParameter("p_username", txtboxusername.Text));
                cmd.Parameters.Add(new MySqlParameter("EventName", txtboxevtname.Text));
                double per = Convert.ToDouble(txtboxdiscount.Text);
                per /= 100.0;
                cmd.Parameters.Add(new MySqlParameter("disc",per ));

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("etsgl");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            businessmanForm busmanForm = new businessmanForm();
            busmanForm.Show();
        }
    }
}
