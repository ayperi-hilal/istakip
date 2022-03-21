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
    public partial class departmanlar : Form
    {
        public departmanlar()
        {
            InitializeComponent();
        }
        isTakipEntities db = new isTakipEntities();
        void listele()
        {
          
            //sadece istediğimiz sutunları görmek için
            var degerler = (from x in db.tbl_departmanlar
                            select new
                            {
                                x.id,
                                x.ad
                                
                            }).ToList();
            gridControl1.DataSource = degerler;
          
            //gridControl1.DataSource = db.tbl_departmanlar.ToList();//bu şekilde tüm listeyi çekiyoruz.
        }


        private void btn_listele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            tbl_departmanlar t = new tbl_departmanlar();

            t.ad = txt_adi.Text;
            db.tbl_departmanlar.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı bir şekilde kaydedbilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void departmanlar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txt_id.Text);
            var deger = db.tbl_departmanlar.Find(x);
            db.tbl_departmanlar.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Departman silme işlemi başarılı bir şekilde gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_id.Text = gridView1.GetFocusedRowCellValue("id").ToString();
            txt_adi.Text = gridView1.GetFocusedRowCellValue("ad").ToString();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txt_id.Text);
            var deger = db.tbl_departmanlar.Find(x);
            deger.ad = txt_adi.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Departman güncelleme işlemi başarılı bir şekilde gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
