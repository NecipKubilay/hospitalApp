using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Secretary_Click(object sender, EventArgs e)
        {
            frmSekreterGiris fr = new frmSekreterGiris();
            fr.Show();
            this.Hide();
        }

        private void Doctor_Click(object sender, EventArgs e)
        {
            frmDoktorGiris fr = new frmDoktorGiris();
            fr.Show();
            this.Hide();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            frmAdminGiris fr = new frmAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
