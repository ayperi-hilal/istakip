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

namespace personelisTakip
{
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }

        isTakipEntities db = new isTakipEntities();

        private void anaform_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.tblGorevler
                                       select new
                                       {
                                           Görev = x.aciklama,
                                           Personel = x.tbl_personeller.ad + " " + x.tbl_personeller.soyad,
                                           x.durum

                                       }).Where(y => y.durum == true).ToList();
            gridView1.Columns["durum"].Visible = false;

            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());



            //bugn yapılan işler,

            gridControl2.DataSource = (from s in db.tblGorevDetaylari
                                       select new
                                       {
                                           Görev = s.tblGorevler.aciklama,
                                           s.aciklama,
                                           s.tarih


                                       }).Where(h => h.tarih == bugun).ToList();







            //aktif çağrı

            gridControl3.DataSource = (from q in db.tbl_cagrilar
                                       select new
                                       {
                                           Firma = q.tblFirmalar.ad,
                                           Konu = q.konu,
                                           Tarih = q.tarih,
                                           q.durum

                                       }).Where(w => w.durum == true).ToList();
            gridView3.Columns["durum"].Visible = false;






            //fihrist komutları

            gridControl4.DataSource = (from x in db.tblFirmalar
                                    select new
                                    {
                                        x.ad,
                                        x.telefon,
                                        x.adres
                                    }
                                  ).ToList();


            //çağrı grafikleri

           
            int aktif_cagrilar= db.tbl_cagrilar.Where(x => x.durum == true).Count();
            int pasif_cagrilar = db.tbl_cagrilar.Where(x => x.durum == false).Count();
          

            chartControl1.Series["Series 1"].Points.AddPoint("Aktif Görevler",aktif_cagrilar);
            chartControl1.Series["Series 1"].Points.AddPoint("Pasif Görevler", pasif_cagrilar);









        }
    }
}
