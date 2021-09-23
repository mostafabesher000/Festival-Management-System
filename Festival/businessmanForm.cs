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
    public partial class businessmanForm : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;persistsecurityinfo=True;database=festivalmanagement;password=27439510");
        public businessmanForm()
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

        private void btncreatevt_Click(object sender, EventArgs e)
        {
            eventForm evt = new eventForm();
            evt.Show();
            this.Hide();
        }

        private void btnoffer_Click(object sender, EventArgs e)
        {
            offerForm offform = new offerForm();
            offform.Show();
            this.Hide();
        }

        private void btndisoffer_Click(object sender, EventArgs e)
        {
            this.Hide();
            discountForm disForm = new discountForm();
            disForm.Show();
        }
    }
}
