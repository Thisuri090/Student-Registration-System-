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
    public partial class frontadminupdate : Form
    {
        public frontadminupdate()
        {
            InitializeComponent();
        }

        private void BunifuPictureBox2_Click(object sender, EventArgs e)
        {
            Front_Admin_Panel fd = new Front_Admin_Panel();
            fd.Show();
            this.Hide();
        }

        private void BunifuPictureBox3_Click(object sender, EventArgs e)
        {
            string uidSearch = txtid.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Student_Reg.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "SELECT * FROM FrontAdminLogin WHERE Id = '" + uidSearch + "'";

            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                if(sdr.Read())
                {
                    txtnmae.Text = sdr["UserName"].ToString();
                    txtpw.Text = sdr["Password"].ToString();

                }
                else
                {
                    MessageBox.Show("No records founds!");
                }
            }
            catch(SqlException se )
            {
                MessageBox.Show("" + se);
            }
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            frontadminadd add = new frontadminadd();
            add.Show();
            this.Hide();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            frontadminhome home = new frontadminhome();
            home.Show();
            this.Hide();
        }

        private void Btnpdateclicking_Click(object sender, EventArgs e)
        {
            string name = txtnmae.Text;
            string pw = txtpw.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Student_Reg.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "UPDATE FrontAdminLogin SET UserName = '" + name + "',Password = '" + pw + "'WHERE Id = '" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data updated successfully.");

            }
            catch(SqlException se)
            {
                MessageBox.Show("" + se);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            frontadmindelete del = new frontadmindelete();
            del.Show();
            this.Hide();
        }

        private void Txtid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
