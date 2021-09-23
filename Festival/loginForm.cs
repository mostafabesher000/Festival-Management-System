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
    public partial class loginForm : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;persistsecurityinfo=True;database=festivalmanagement;password=27439510");

        public loginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            regesterationForm regform = new regesterationForm();
            regform.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string user = txtboxusername.Text;
                string pass = txtboxpassword.Text;
                string vis = "Visitor";
                string buss = "BusinessMan";
                string admin = "Admin";
                MySqlCommand cmd = new MySqlCommand("select count(*) from users where Username = @user and UserPass = @pass and Title = @vis;", con);
                
                cmd.Parameters.AddWithValue("@user", txtboxusername.Text);
                cmd.Parameters.AddWithValue("@pass", txtboxpassword.Text);
                cmd.Parameters.AddWithValue("@vis", "Visitor");
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                MySqlCommand cmd2 = new MySqlCommand("select count(*) from users where Username = @user and UserPass = @pass and Title = @buss;", con);

                cmd2.Parameters.AddWithValue("@user", txtboxusername.Text);
                cmd2.Parameters.AddWithValue("@pass", txtboxpassword.Text);
                cmd2.Parameters.AddWithValue("@buss", "BusinessMan");
                int count2 = Convert.ToInt32(cmd2.ExecuteScalar());

                MySqlCommand cmd3 = new MySqlCommand("select count(*) from users where Username = @user and UserPass = @pass and Title = @admin;", con);

                cmd3.Parameters.AddWithValue("@user", txtboxusername.Text);
                cmd3.Parameters.AddWithValue("@pass", txtboxpassword.Text);
                cmd3.Parameters.AddWithValue("@admin", "Admin");
                int count3 = Convert.ToInt32(cmd3.ExecuteScalar());

                int mx, mn, md;
                mx = Math.Max(count, Math.Max(count2, count3));
                mn = Math.Min(count, Math.Min(count2, count3));
                md = (count + count2 + count3) - (mx + mn);
                if (mx==count2)
                {
                    this.Hide();
                    businessmanForm bmForm = new businessmanForm();
                    bmForm.Show();
                }
                
                else if(mx==count)
                {
                    this.Hide();
                    vistorForm visForm = new vistorForm();
                    visForm.Show();
                    
                }

                else if (mx == count3)
                {
                    this.Hide();
                    adminForm admForm = new adminForm();
                    admForm.Show();
          
                }

                //other
                else
                {
                    MessageBox.Show("Your are not registered ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    regesterationForm regform =new regesterationForm() ;
                    regform.Show();
                }

                con.Open();
                cmd.ExecuteNonQuery();
                this.Hide();
                loginForm logform = new loginForm();
                logform.Show();

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
    }
}
