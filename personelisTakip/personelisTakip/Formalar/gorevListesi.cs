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
    public partial class gorevListesi : Form
    {
        public gorevListesi()
        {
            InitializeComponent();
        }
        isTakipEntities db = new isTakipEntities();

        private void gorevListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.tblGorevler
                                       select new
                                       {
                                          
                                           x.aciklama
                                       }).ToList();
            lbl_toplamDepartman.Text = db.tbl_departmanlar.Count().ToString();
            lbl_aktifGorev.Text = db.tblGorevler.Where(x=>x.durum==true).Count().ToString();
            lbl_pasifGorev.Text = db.tblGorevler.Where(x=>x.durum==false).Count().ToString();

            chartControl1.Series["Durum"].Points.AddPoint("Aktif Görevler", int.Parse(lbl_aktifGorev.Text));
            chartControl1.Series["Durum"].Points.AddPoint("Pasif Görevler", int.Parse(lbl_pasifGorev.Text));







        }
    }
}
