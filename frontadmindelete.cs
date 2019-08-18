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
    public partial class frontadmindelete : Form
    {
        public frontadmindelete()
        {
            InitializeComponent();
        }

        private void HOME_Click(object sender, EventArgs e)
        {
            Front_Admin_Panel fp = new Front_Admin_Panel();
            fp.Show();
            this.Hide();
        }

        private void BunifuPictureBox2_Click(object sender, EventArgs e)
        {
            string uidSearch = txtid.Text;

            string ConString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Student_Reg.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM FrontAdminLogin WHERE Id = '" + uidSearch + "'";

            SqlDataAdapter da = new SqlDataAdapter(qry, ConString);
            DataSet ds = new DataSet();

            da.Fill(ds, "FrontAdminLogin");
            dgvi.DataSource = ds.Tables["FrontAdminLogin"];
        }

        private void Btndel_Click(object sender, EventArgs e)
        {
            string uid = txtid.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Student_Reg.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "DELETE FROM FrontAdminLogin WHERE Id = '" + uid + "'";

            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully.");
                
            }
            catch(SqlException se)
            {
                MessageBox.Show("ID doesn't exist!");
            }

            txtid.Text = "";

            string ConString1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Student_Reg.mdf;Integrated Security=True;Connect Timeout=30";
            string qry1 = "SELECT * FROM FrontAdminLogin";

            SqlDataAdapter da = new SqlDataAdapter(qry1, ConString1);
            DataSet ds = new DataSet();

            da.Fill(ds, "FrontAdminLogin");
            dgvi.DataSource = ds.Tables["FrontAdminLogin"];
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            frontadminhome hoem = new frontadminhome();
            hoem.Show();
            this.Hide();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            frontadminadd add = new frontadminadd();
            add.Show();
            this.Hide();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            frontadminupdate up = new frontadminupdate();
            up.Show();
            this.Hide();
        }
    }
}

