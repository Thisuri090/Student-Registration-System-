using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration_System
{
    public partial class Front_Admin_Panel : Form
    {
        public Front_Admin_Panel()
        {
            InitializeComponent();
        }

        private void DoubleBitmapControl5_Click(object sender, EventArgs e)
        {
            Admin_Selection_Interface asd = new Admin_Selection_Interface();
            asd.Show();
            this.Hide();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            frontadminhome fh = new frontadminhome();
            fh.Show();
            this.Hide();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            frontadminadd fd = new frontadminadd();
            fd.Show();
            this.Hide();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            frontadminupdate up = new frontadminupdate();
            up.Show();
            this.Hide();
        }

        private void BunifuPictureBox1_Click(object sender, EventArgs e)
        {
            Admin_Selection_Interface ad = new Admin_Selection_Interface();
            ad.Show();
            this.Hide();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            frontadmindelete del = new frontadmindelete();
            del.Show();
            this.Hide();

        }

        private void BunifuPictureBox1_Click_1(object sender, EventArgs e)
        {
            Admin_Selection_Interface asd = new Admin_Selection_Interface();
            asd.Show();
            this.Hide();
        }
    }
}
