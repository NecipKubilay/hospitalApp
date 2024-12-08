using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp.Forms
{
    public partial class frmSekreterEkran : Form
    {
        public frmSekreterEkran()
        {
            InitializeComponent();
        }

        private void dktrDetay_Click(object sender, EventArgs e)
        {
            frmDoktorEkle frm = new frmDoktorEkle();
            frm.Show();
        }

        private void rndvOlustur_Click(object sender, EventArgs e)
        {
            frmRandevuOlustur frm = new frmRandevuOlustur();
            frm.Show();
        }

        private void brnsEkle_Click(object sender, EventArgs e)
        {
            frmBransEkle frm = new frmBransEkle();
            frm.Show();
        }

        private void hastaEkle_Click(object sender, EventArgs e)
        {
            frmHastaEkle frm = new frmHastaEkle();
            frm.Show();
        }

        private void raporlama_Click(object sender, EventArgs e)
        {
            Raporlar.raporlama frm = new Raporlar.raporlama();
            frm.Show();
        }
    }
}
