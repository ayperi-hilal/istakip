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

namespace personelisTakip.Formalar
{
    public partial class atama : Form
    {
        public atama()
        {
            InitializeComponent();
        }

        isTakipEntities db = new isTakipEntities();

        public int id;

        private void btn_vazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCagriAtama_Load(object sender, EventArgs e)
        {
            //lookupedt için verilerin listelenmesi.
            var degerler = (from x in db.tbl_personeller
                            select new
                            {
                                x.id,
                                AdSoyad = x.ad + " " + x.soyad
                            }).ToList();

            look_gorevAlan.Properties.ValueMember = "id";
            look_gorevAlan.Properties.DisplayMember = "AdSoyad";
            look_gorevAlan.Properties.DataSource = degerler;

            txt_cagriID.Text = id.ToString();
            var gelenveri = db.tbl_cagrilar.Find(id);
            txt_aciklama.Text = gelenveri.aciklama;
            date_tarih.Text = gelenveri.tarih.ToString();
            txt_konu.Text = gelenveri.konu;

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            var gelenveri = db.tbl_cagrilar.Find(id);
            gelenveri.aciklama = txt_aciklama.Text;
            gelenveri.konu = txt_konu.Text;
            gelenveri.tarih = Convert.ToDateTime(date_tarih.Text);
            gelenveri.cagriPersonel = int.Parse(look_gorevAlan.EditValue.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("Görev ataması başarılı bir şekilde gerçekleştirilmiştir.");



        }
    }
}
