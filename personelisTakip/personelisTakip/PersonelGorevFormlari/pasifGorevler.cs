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
    public partial class pasifGorevler : Form
    {
        public pasifGorevler()
        {
            InitializeComponent();
        }

        isTakipEntities db = new isTakipEntities();

        public string mail2;

        private void pasifGorevler_Load(object sender, EventArgs e)
        {
            var personelid = db.tbl_personeller.Where(x => x.mail == mail2).Select(y => y.id).FirstOrDefault();


            //sisteme giriş yapan persoenldir 

            var degerler = (from x in db.tblGorevler
                            select new
                            {
                                x.id,
                                x.aciklama,
                                x.tarih,
                                x.gorevAlan,
                                x.durum
                            }).Where(x => x.gorevAlan == personelid && x.durum == false).ToList();

            gridControl1.DataSource = degerler;
            gridView1.Columns["gorevAlan"].Visible = false;
            gridView1.Columns["durum"].Visible = false;
        }
    }
}
