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
    public partial class Front_Admin_Login_Interface : Form
    {
        public Front_Admin_Login_Interface()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string uname = txtUserName.Text;
            string pw = txtPassword.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Student_Reg.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "SELECT UserName , Password from FrontAdminLogin where UserName ='" + uname + "' and Password = '" + pw + "'";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                if(sdr.Read())
                {
                    Front_Admin_Panel fp = new Front_Admin_Panel();
                    fp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User Name or Password doesn't exist.");
                }
            }

            catch(SqlException se )
            {
                MessageBox.Show("" + se);
            }

            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void BunifuPictureBox2_Click(object sender, EventArgs e)
        {
            Admin_Selection_Interface asd = new Admin_Selection_Interface();
            asd.Show();
            this.Hide();

        }
    }
}
