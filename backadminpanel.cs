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
    public partial class backadminpanel : Form
    {
        public backadminpanel()
        {
            InitializeComponent();
        }

        private void BunifuPictureBox2_Click(object sender, EventArgs e)
        {
            Admin_Selection_Interface ad = new Admin_Selection_Interface();
            ad.Show();
            this.Hide();

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            backhome home = new backhome();
            home.Show();
            this.Hide();

        }
    }
}
