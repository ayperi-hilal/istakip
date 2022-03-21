using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personelisTakip
{
    public partial class ekran : Form
    {
        public ekran()
        {
            InitializeComponent();
        }

        private void btnYeniGorevTanimla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gorevDetaylari frm1 = new gorevDetaylari();
            frm1.Show();
        }
        aktifCagrilar frm2;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new aktifCagrilar();

                frm2.MdiParent = this;
                frm2.Show();
            }
            else
            {
                xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[frm2];

            }
        }

        gorevListesi frm3;
        private void btnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new gorevListesi();

                frm3.MdiParent = this;
                frm3.Show();
            }
            else
            {
                xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[frm3];

            }
        }

        personelİstatistigi frm4;
        private void btnGorevIstatistigi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new personelİstatistigi();

                frm4.MdiParent = this;
                frm4.Show();
            }
            else
            {
                xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[frm4];

            }
        }

        anaform frm5;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm5 == null || frm5.IsDisposed)
            {
                frm5 = new anaform();

                frm5.MdiParent = this;
                frm5.Show();
            }
            else
            {
                xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[frm5];

            }
        }
    }
}
