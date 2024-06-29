using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmKullaniciKayıt
{
    public partial class frmKayıtol : Form
    {
        public frmKayıtol()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmGirisyap frmGirisyap = new frmGirisyap();
            frmGirisyap.Show();
            this.Hide();
        }
    }
}
