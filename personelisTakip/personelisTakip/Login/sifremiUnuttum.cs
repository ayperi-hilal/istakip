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

namespace personelisTakip.Login
{
    public partial class sifremiUnuttum : Form
    {
        public sifremiUnuttum()
        {
            InitializeComponent();
        }

        isTakipEntities db = new isTakipEntities();

        private void hlk_kullaniciGiris_Click(object sender, EventArgs e)
        {
            login frm1 = new login();
            frm1.Show();
            this.Hide();

        }

        private void hlk_uygulamayiKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hlk_yardim_Click(object sender, EventArgs e)
        {
            yardim frm2 = new yardim();
            frm2.Show();
            this.Hide();
        }

        private void hlk_webPanel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Henüz Test Aşamasındadır");
        }

        private void btn_sifreDegistir_Click(object sender, EventArgs e)
        {
            if (txt_sifre.Text == txt_sifreTekrar.Text)
            {
                var kisi = db.tbl_personeller.Where(x => x.ad == txt_adi.Text && x.soyad == txt_soyadi.Text && x.mail == txt_kullaniciAdi.Text).FirstOrDefault();
                if (kisi != null)
                {                    kisi.sifre= txt_sifre.Text;
                                       
                    db.SaveChanges();

                    XtraMessageBox.Show("Şifre başarılı bir şekilde güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Kişi bulunamamıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Şifre ile Şifre Tekrar Uyuşmamaktadır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
