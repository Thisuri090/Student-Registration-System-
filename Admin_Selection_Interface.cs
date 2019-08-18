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
    public partial class Admin_Selection_Interface : Form
    {
        public Admin_Selection_Interface()
        {
            InitializeComponent();
        }

        private void FrontAdmin_Click(object sender, EventArgs e)
        {
            Front_Admin_Login_Interface front = new Front_Admin_Login_Interface();
            front.Show();
            this.Hide();
        }

        private void BackAdmin_Click(object sender, EventArgs e)
        {
            BackLogin rtg = new BackLogin();
            rtg.Show();
            this.Hide();
        }
    }
}
