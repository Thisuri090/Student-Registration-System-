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
    public partial class backhome : Form
    {
        public backhome()
        {
            InitializeComponent();
        }

        private void BunifuPictureBox2_Click(object sender, EventArgs e)
        {
            backadminpanel bp = new backadminpanel();
            bp.Show();
            this.Hide();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string name = txtID.Text;

            

            string ConString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Student_Reg.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM BackAdminLogin WHERE UserName = '" + name + "'";

          

                SqlDataAdapter da = new SqlDataAdapter(qry, ConString);
                DataSet ds = new DataSet();

                da.Fill(ds, "BackAdminLogin");
                dgvi.DataSource = ds.Tables["BackAdminLogin"];
           
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {

            string ConString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Student_Reg.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM BackAdminLogin ";

            SqlDataAdapter da = new SqlDataAdapter(qry, ConString);
            DataSet ds = new DataSet();

            da.Fill(ds, "BackAdminLogin");
            dgvi.DataSource = ds.Tables["BackAdminLogin"];
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            backhome hmo = new backhome();
            hmo.Show();
            this.Hide();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            backAdd bn = new backAdd();
            bn.Show();
            this.Hide();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            BackUpdate fd = new BackUpdate();
            fd.Show();
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
