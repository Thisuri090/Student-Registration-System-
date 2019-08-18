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
    public partial class backDelete : Form
    {
        public backDelete()
        {
            InitializeComponent();
        }

        private void BunifuPictureBox2_Click(object sender, EventArgs e)
        {
            backadminpanel fs = new backadminpanel();
            fs.Show();
            this.Hide();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            backhome hg = new backhome();
            hg.Show();
            this.Hide();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            backAdd uy = new backAdd();
            uy.Show();
            this.Hide();
        }

        private void BtnUpdtae_Click(object sender, EventArgs e)
        {
            BackUpdate lk = new BackUpdate();
            lk.Show();
            this.Hide();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            backDelete del = new backDelete();
            del.Show();
            this.Hide();
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            string uid = txtunmae.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Student_Reg.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "DELETE FROM BackAdminLogin WHERE UserName = '" + uid + "'";

            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully.");

            }
            catch (SqlException se)
            {
                MessageBox.Show("UserName doesn't exist!");
            }
        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            string ConString1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Student_Reg.mdf;Integrated Security=True;Connect Timeout=30";
            string qry1 = "SELECT * FROM BackAdminLogin";

            SqlDataAdapter da = new SqlDataAdapter(qry1, ConString1);
            DataSet ds = new DataSet();

            da.Fill(ds, "BackAdminLogin");
            dgvi.DataSource = ds.Tables["BackAdminLogin"];
        }
    }
}
