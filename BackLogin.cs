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
    public partial class BackLogin : Form
    {
        public BackLogin()
        {
            InitializeComponent();
        }

        private void BackLogin_Load(object sender, EventArgs e)
        {

        }

        private void BunifuPictureBox1_Click(object sender, EventArgs e)
        {
            Admin_Selection_Interface asre = new Admin_Selection_Interface();
            asre.Show();
            this.Hide();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string uname = txtUserName.Text;
            string pw = txtpw.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Student_Reg.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "SELECT UserName , Password from BackAdminLogin where UserName ='" + uname + "' and Password = '" + pw + "'";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    backadminpanel kgh = new backadminpanel();
                    kgh.Show();
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
           txtpw.Text = "";
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtpw.Text = "";
        }
    }
}
