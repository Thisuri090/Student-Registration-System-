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
    public partial class frontadminadd : Form
    {
        public frontadminadd()
        {
            InitializeComponent();
        }

        private void BunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BunifuPictureBox2_Click(object sender, EventArgs e)
        {
            Front_Admin_Panel fd = new Front_Admin_Panel();
            fd.Show();
            this.Hide();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            frontadminhome home = new frontadminhome();
            home.Show();
            this.Hide();

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUserID.Text);
            string name = txtUser.Text;
            string pw = txtPw.Text;
            string cpw = txtcpw.Text;

            if (id == null && name == null && pw == null && cpw == null)
            {
                MessageBox.Show("Fill the required fields.");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Student_Reg.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "INSERT INTO FrontAdminLogin VALUES ('" + id + "','" + name + "','" + pw + "')";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    if (pw == cpw)
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New record inserted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Password mismatched.");
                    }
                }
                catch (SqlException se)
                {
                    MessageBox.Show("Incorrect attempt.");
                }

                txtUserID.Text = "";
                txtUser.Text = "";
                txtPw.Text = "";
                txtcpw.Text = "";
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            frontadminupdate up = new frontadminupdate();
            up.Show();
            this.Hide();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            frontadmindelete del = new frontadmindelete();
            del.Show();
            this.Hide();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }
    }

}


