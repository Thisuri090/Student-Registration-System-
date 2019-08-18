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
    public partial class backAdd : Form
    {
        public backAdd()
        {
            InitializeComponent();
        }

        private void BunifuPictureBox2_Click(object sender, EventArgs e)
        {
            backadminpanel bd = new backadminpanel();
            bd.Show();
            this.Hide();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            backhome bg = new backhome();
            bg.Show();
            this.Hide();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            backAdd bd = new backAdd();
            bd.Show();
            this.Hide();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (txtemail.Text != "" && txtfirst.Text != "" && txtgender.Text != "" && txtlast.Text != "" && txtPw.Text != "" && txtUname.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Student_Reg.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "INSERT INTO BackAdminLogin VALUES ('','" + txtUname.Text + "','" + txtPw.Text + "','" + txtfirst.Text + "','" + txtlast.Text + "','" + txtemail.Text + "','" + txtgender.Text + "') ";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record entered successfully.");
                }
                catch (SqlException se)
                {
                    MessageBox.Show("Fill all the fields.");
                }
                txtfirst.Text = "";
                txtlast.Text = "";
                txtemail.Text = "";
                txtgender.Text = "";
                txtPw.Text = "";
                txtUname.Text = "";
            }

        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtfirst.Text = "";
            txtlast.Text = "";
            txtemail.Text = "";
            txtgender.Text = "";
            txtPw.Text = "";
            txtUname.Text = "";
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            BackUpdate df = new BackUpdate();
            df.Show();
            this.Hide();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            backDelete del = new backDelete();
            del.Show();
            this.Hide();
        }
    }
}


