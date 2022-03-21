using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personelisTakip.PersonelGorevFormlari
{
    public partial class personelFormu : Form
    {
        public personelFormu()
        {
            InitializeComponent();
        }

        public string mail;
     
        aktifGorevler frm1;

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm1 == null || frm1.IsDisposed)
            {
                frm1 = new aktifGorevler();
                frm1.MdiParent = this;
                frm1.mail2 = mail;
                frm1.Show();
            }
            else
            {
                xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[frm1];

            }
        }
        pasifGorevler frm2;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new pasifGorevler();
                frm2.MdiParent = this;
                frm2.mail2 = mail;
                frm2.Show();
            }
            else
            {
                xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[frm2];

            }
        }

        cagriListesi frm3;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new cagriListesi();
                frm3.MdiParent = this;
                frm3.mail2 = mail;
                frm3.Show();
            }
            else
                xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[frm3];
        }

        private void personelFormu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
