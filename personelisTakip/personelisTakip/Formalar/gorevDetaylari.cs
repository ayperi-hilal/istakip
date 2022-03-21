using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using personelisTakip.Entity;

namespace personelisTakip
{
    public partial class gorevDetaylari : Form
    {
        public gorevDetaylari()
        {
            InitializeComponent();
        }
        isTakipEntities db = new isTakipEntities();

        private void btn_vazgec_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            tblGorevler t = new tblGorevler();
            t.aciklama = txt_aciklama.Text;
            t.durum = true;
          t.gorevAlan =int.Parse( look_gorevAlan.EditValue.ToString());
            t.tarih = DateTime.Parse(date_tarih.Text);
            t.gorevVeren = 1;

            db.tblGorevler.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Görev Kaydedilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gorevDetaylari_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.tbl_personeller
                                select new
                                {
                                    x.id,
                                   AdSoyad= x.ad+" "+x.soyad
                                }).ToList();
            look_gorevAlan.Properties.ValueMember = "id";
            look_gorevAlan.Properties.DisplayMember = "AdSoyad";
            look_gorevAlan.Properties.DataSource = degerler;
        }
    }
}
