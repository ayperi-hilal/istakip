using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using personelisTakip.Entity;



namespace personelisTakip
{
    public partial class gorevDetayGoruntule : Form
    {
        public gorevDetayGoruntule()
        {
            InitializeComponent();
        }

        isTakipEntities db = new isTakipEntities();
        private void gorevDetayGoruntule_Load(object sender, EventArgs e)
        {
            db.tblGorevDetaylari.Load();
            bindingSource1.DataSource = db.tblGorevDetaylari.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }

        private void görevDetayıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();

        }

        
    }
}
