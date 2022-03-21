using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using personelisTakip.Entity;
using DevExpress.XtraEditors;

namespace personelisTakip.PersonelGorevFormlari
{
    public partial class cagriDetayGirisi : Form
    {
        public cagriDetayGirisi()
        {
            InitializeComponent();
        }

        isTakipEntities db = new isTakipEntities();

        public int id;

        private void btn_vazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cagriDetayGirisi_Load(object sender, EventArgs e)
        {
            txt_cagriID.Enabled = false;
            txt_cagriID.Text = id.ToString();
            string saat, tarih;
            tarih = DateTime.Now.ToShortDateString();
            saat = DateTime.Now.ToShortTimeString();
            txt_saat.Text = saat;
            date_tarih.Text = tarih;

        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            tblCagriDetay t = new tblCagriDetay();

            t.cagri = int.Parse(txt_cagriID.Text);
            t.aciklama = txt_aciklama.Text;
            t.saat = txt_saat.Text;
            t.tarih = DateTime.Parse(date_tarih.Text);
            db.tblCagriDetay.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Çağrı Detayları Başarılı Bir Şekilde Kaydedilmiştir.");

        }

       
    }
}
