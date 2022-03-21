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
    public partial class personelİstatistigi : Form
    {
        public personelİstatistigi()
        {
            InitializeComponent();
        }

        isTakipEntities db = new isTakipEntities();
        private void personelİstatistigi_Load(object sender, EventArgs e)
        {
            lbl_departman.Text = db.tbl_departmanlar.Count().ToString();
            lbl_firma.Text = db.tblFirmalar.Count().ToString();
           lbl_toplampersonel.Text = db.tbl_personeller.Count().ToString();

            lbl_aktifIs.Text = db.tblGorevler.Count(x => x.durum==true).ToString();
            lbl_PasitIsSayisi.Text = db.tblGorevler.Count(x => x.durum==false).ToString();
            lbl_sonGorev.Text = db.tblGorevler.OrderByDescending(x => x.id).Select(x => x.aciklama).FirstOrDefault();//veri tabanı tablosunu id göre ters sıralayıp ilk görevi alarak son verilen görevi görmüş oluyorum.
            lbl_SonGorevTarihi.Text= db.tblGorevler.OrderByDescending(x => x.id).Select(x => x.tarih).FirstOrDefault().ToString();
            lbl_sehir.Text = db.tblFirmalar.Select(x=>x.il).Distinct().Count().ToString();
            lbl_sektor.Text = db.tblFirmalar.Select(x => x.sektor).Distinct().Count().ToString();
            DateTime bugun = DateTime.Today;
            lbl_bugunAcilanGorevler.Text = db.tblGorevler.Count(x => x.tarih == bugun).ToString();
          //  lbl_ayinPersoneli.Text = db.tblGorevler.GroupBy(x => x.gorevAlan).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault().ToString();//bu kısım ayın personelinin sadece id sini getirmektedir.
            var d1 = db.tblGorevler.GroupBy(x => x.gorevAlan).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            lbl_ayinPersoneli.Text = db.tbl_personeller.Where(x => x.id == d1).Select(y => y.ad+" "+y.soyad).FirstOrDefault().ToString();
            lbl_ayindepartman.Text = db.tbl_departmanlar.Where(x => x.id ==db.tbl_personeller.Where(t=>t.id==d1).Select(z=>z.departman).FirstOrDefault()).Select(y => y.ad).FirstOrDefault().ToString();

        }
    }
}
