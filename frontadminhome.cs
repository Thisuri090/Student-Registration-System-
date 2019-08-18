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
    public partial class frontadminhome : Form
    {
        public frontadminhome()
        {
            InitializeComponent();
        }

        private void BunifuPictureBox2_Click(object sender, EventArgs e)
        {
            Front_Admin_Panel fd = new Front_Admin_Panel();
            fd.Show();
            this.Hide();
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            string name = txtEnterName.Text;

            string ConString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Student_Reg.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM FrontAdminLogin WHERE UserName = '" + name + "'";

            SqlDataAdapter da = new SqlDataAdapter(qry, ConString);
            DataSet ds = new DataSet();
            
            da.Fill(ds, "FrontAdminLogin");
            dgvi.DataSource = ds.Tables["FrontAdminLogin"];


        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string ConString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Student_Reg.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM FrontAdminLogin ";

            SqlDataAdapter da = new SqlDataAdapter(qry, ConString);
            DataSet ds = new DataSet();

            da.Fill(ds, "FrontAdminLogin");
            dgvi.DataSource = ds.Tables["FrontAdminLogin"];

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            frontadminadd ad = new frontadminadd();
            ad.Show();
            this.Hide();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            frontadminupdate up = new frontadminupdate();
            up.Show();
            this.Hide();

        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            frontadmindelete del = new frontadmindelete();
            del.Show();
            this.Hide();

        }
    }
}
