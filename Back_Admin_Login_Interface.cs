using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_Registration_System
{
    public partial class Back_Admin_Login_Interface : Form
    {
        public Back_Admin_Login_Interface()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string pw = txtpassword.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Student_Reg.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "SELECT UserName ,Password FROM BackAdminLogin WHERE UserName = '" + username + "' AND Password='" + pw + "'";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    Back_Admin_Panel bc = new Back_Admin_Panel();
                    bc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User Name or Password doesn't exist.");
                }
            }

            catch (SqlException se)
            {
                MessageBox.Show("" + se);
            }

            txtUserName.Text = "";
            txtpassword.Text = "";
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtpassword.Text = "";

        }

        private void BunifuPictureBox2_Click(object sender, EventArgs e)
        {
            Admin_Selection_Interface asd = new Admin_Selection_Interface();
            asd.Show();
            this.Hide();

        }
    }
}
