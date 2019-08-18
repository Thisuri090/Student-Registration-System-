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
    public partial class BackUpdate : Form
    {
        public BackUpdate()
        {
            InitializeComponent();
        }

        private void BunifuPictureBox2_Click(object sender, EventArgs e)
        {
            backadminpanel df = new backadminpanel();
            df.Show();
            this.Hide();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            backhome hg = new backhome();
            hg.Show();
            this.Hide();
        }

        private void BtnADD_Click(object sender, EventArgs e)
        {
            backAdd ds = new backAdd();
            ds.Show();
            this.Hide();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            BackUpdate io = new BackUpdate();
            io.Show();
            this.Hide();
        }

        private void BunifuPictureBox3_Click(object sender, EventArgs e)
        {
            string uidSearch = txtuname.Text; 

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Student_Reg.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "SELECT * FROM BackAdminLogin WHERE UserName = '" + uidSearch + "'";

            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    txtfirst.Text = sdr["FirstName"].ToString();
                    txtEmail.Text = sdr["Email"].ToString();
                    txtpaw.Text = sdr["Password"].ToString();
                }
                else
                {
                    MessageBox.Show("No records founds!");
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show("" + se);
            }
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            string fnmae = txtfirst.Text;
            string email = txtEmail.Text;
            string pw = txtpaw.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Student_Reg.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "UPDATE BackAdminLogin SET FirstName = '" + fnmae + "',Email = '" + email + "', Password = '" + pw + "' WHERE UserName = '" + txtuname.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record entered succuessfully!");
            }
            catch(SqlException se)
            {
                MessageBox.Show("No records found!");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            backDelete del = new backDelete();
            del.Show();
            this.Hide();
        }
    }
}
