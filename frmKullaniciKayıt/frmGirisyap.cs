using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmKullaniciKayıt.ORM.Context;
using frmKullaniciKayıt.ORM.Entity;

namespace frmKullaniciKayıt
{
    public partial class frmGirisyap : Form
    {
        ProjectContext db = new ProjectContext();
        string TC = "";
        string sifre = "";
        int id;
        public frmGirisyap()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            List<Yoneticiler> ynt = new List<Yoneticiler>();
            ynt = db.Yoneticilers.Where(y => y.TC == txt_TC.Text).ToList();

            foreach (Yoneticiler yonetici in ynt)
            {
                TC = yonetici.TC.ToString();
                sifre = yonetici.Sifre.ToString();
                id = yonetici.Id;
            }

            if (TC == txt_TC.Text)
            {
                if (sifre == txt_sifre.Text)
                {
                    MessageBox.Show("Hoşgeldiniz");
                }
                else
                {
                    MessageBox.Show("Şifre Hatalı");
                }
            }
            else
            {
                MessageBox.Show("TC Hatalı");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKayıtol frmKayıtol = new frmKayıtol();
            frmKayıtol.Show();
            this.Hide();
        }
    }
}
