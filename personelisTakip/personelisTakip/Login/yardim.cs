using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personelisTakip.Login
{
    public partial class yardim : Form
    {
        public yardim()
        {
            InitializeComponent();
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            login frm1 = new login();
            frm1.Show();
            this.Hide();
        }

        private void hlk_sifremiUnuttum_Click(object sender, EventArgs e)
        {
            sifremiUnuttum f2 = new sifremiUnuttum();
            f2.Show();
            this.Hide();
        }

        private void hyperlinkLabelControl3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hlk_webPanel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Henüz Test Aşamasındadır");
        }
    }
}
