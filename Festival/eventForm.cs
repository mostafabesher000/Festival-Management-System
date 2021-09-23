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
    public partial class eventForm : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;persistsecurityinfo=True;database=festivalmanagement;password=27439510");

        public eventForm()
        {
            InitializeComponent();
        }

        private void btncreatevt_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlCommand cmd = new MySqlCommand("create_event", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new MySqlParameter("p_eventname", txtboxname.Text));
                cmd.Parameters.Add(new MySqlParameter("p_location", txtboxlocation.Text));
                cmd.Parameters.Add(new MySqlParameter("p_eventdescription", richtxtboxdescription.Text));
                cmd.Parameters.Add(new MySqlParameter("p_start", txtboxstart.Text));
                cmd.Parameters.Add(new MySqlParameter("p_end", txtboxend.Text));
         
                cmd.Parameters.Add(new MySqlParameter("p_price", Convert.ToInt32(txtboxprice.Text)));
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
