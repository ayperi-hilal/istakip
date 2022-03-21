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


namespace personelisTakip.PersonelGorevFormlari
{
    public partial class cagriListesi : Form
    {
        public cagriListesi()
        {
            InitializeComponent();
        }

        isTakipEntities db = new isTakipEntities();

        public string mail2;

        private void gridControl1_Load(object sender, EventArgs e)
        {
            var personelid = db.tbl_personeller.Where(x => x.mail == mail2).Select(y => y.id).FirstOrDefault();


            gridControl1.DataSource = (from x in db.tbl_cagrilar
                                       select new
                                       {
                                           x.id,
                                           x.tblFirmalar.ad,
                                           x.tblFirmalar.telefon,
                                           x.tblFirmalar.mail,
                                           x.aciklama,
                                           x.cagriPersonel,
                                           x.durum
                                       }).Where(y => y.durum == true  && y.cagriPersonel==personelid).ToList();
            gridView1.Columns["durum"].Visible = false;
            gridView1.Columns["id"].Visible = false;
            gridView1.Columns["cagriPersonel"].Visible = false;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            cagriDetayGirisi fr = new cagriDetayGirisi();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
            fr.Show();

        }
    }
}
