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
using personelisTakip.Formalar;

namespace personelisTakip
{
    public partial class aktifCagrilar : Form
    {
        public aktifCagrilar()
        {
            InitializeComponent();
        }
        isTakipEntities db = new isTakipEntities();

        private void aktifCagrilar_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.tbl_cagrilar
                            select new
                            {
                                x.id,
                                Firma=x.tblFirmalar.ad,
                                x.tblFirmalar.telefon,
                                x.konu,
                                x.aciklama,
                                Personel=x.tbl_personeller.ad,
                                x.durum

                            }).Where(x => x.durum == true).ToList();
            gridControl1.DataSource = degerler;
        }

       
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            atama fr = new atama();
            fr.id=int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
            fr.Show();
        }
        
    }
}
