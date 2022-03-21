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
    public partial class personeller : Form
    {
        public personeller()
        {
            InitializeComponent();
        }

        isTakipEntities db = new isTakipEntities();
        void personelleri()
        {
            var degerler = from x in db.tbl_personeller
                           select new
                           {
                               x.id,
                               x.ad,
                               x.soyad,
                               x.mail,
                               x.telefon,
                              // x.departman,//bu şekilde departmanların id gelmetedir.
                              Departman=x.tbl_departmanlar.ad,//bu şeklde hem aynı olan isimler çakışmamış oldu hemde sutun isimlendirmiş olduk
                               x.durum
                           };
            gridControl1.DataSource = degerler.Where(x=>x.durum==true).ToList();
        }
        private void personeller_Load(object sender, EventArgs e)
        {

            personelleri();
            //var deparmanlar = db.tbl_departmanlar.ToList();

            var departmanlar = (from x in db.tbl_departmanlar
                                select new
                                {
                                    x.id,
                                    x.ad
                                }
            ).ToList();
            look_departman.Properties.ValueMember = "id";
            look_departman.Properties.DisplayMember = "ad";
            look_departman.Properties.DataSource = departmanlar;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            tbl_personeller t = new tbl_personeller();
            t.ad = txt_adi.Text;
            t.soyad = txt_soyadı.Text;
            t.mail = txt_mail.Text;
          
           t.gorsel = txt_gorsel.Text;
            t.departman = int.Parse(look_departman.EditValue.ToString());
            db.tbl_personeller.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni personel başarılı bir şekilde kaydeilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personelleri();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            var x = int.Parse(txt_id.Text);
            var deger = db.tbl_personeller.Find(x);
            deger.durum = false;
            db.SaveChanges();
            XtraMessageBox.Show("Personeller başarılı bir şekilde silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            personelleri();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_id.Text = gridView1.GetFocusedRowCellValue("id").ToString();
            txt_adi.Text = gridView1.GetFocusedRowCellValue("ad").ToString();
            txt_soyadı.Text = gridView1.GetFocusedRowCellValue("soyad").ToString();
            txt_mail.Text = gridView1.GetFocusedRowCellValue("mail").ToString();
           // txt_gorsel.Text = gridView1.GetFocusedRowCellValue("gorsel").ToString();
            look_departman.Text = gridView1.GetFocusedRowCellValue("departman").ToString();
            

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txt_id.Text);
            var deger = db.tbl_personeller.Find(x);
            deger.ad = txt_adi.Text;
            deger.soyad = txt_soyadı.Text;
            deger.mail = txt_mail.Text;
            deger.gorsel = txt_gorsel.Text;
            deger.departman = int.Parse(look_departman.EditValue.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("Personeller başarılı bir şekilde güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            personelleri();

        }
    }
}
