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
using DevExpress.XtraEditors;


namespace personelisTakip.Login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        isTakipEntities db = new isTakipEntities();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //anasayfam frm = new anasayfam();

            //frm.Show();
            //C:\Users\DOKÜMANTASYON\source\personelisTakip\personelisTakip\anasayfam.cs
            ekran frm = new ekran();
            frm.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            PersonelGorevFormlari.personelFormu frm2 = new PersonelGorevFormlari.personelFormu();
            frm2.Show();
        }

        private void txt_kullaniciAdi_Click(object sender, EventArgs e)
        {
            panel4.BackColor = SystemColors.Control;
            panel3.BackColor = Color.White;
        }

        private void txt_sifre_Click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {

            var adminvalue = db.tblAdmin.Where(x => x.kullanici == txt_kullaniciAdi.Text && x.sifre == txt_sifre.Text).FirstOrDefault();

            if(adminvalue!=null)
            {
                XtraMessageBox.Show("Giriş Başarılıdır");

                //if (checkBox1.Checked)
                //{
                //    Properties.Settings.Default["UserName"] = txt_kullaniciAdi.Text;
                //    Properties.Settings.Default["Password"] = txt_sifre.Text;
                //}
                //else
                //{
                //    Properties.Settings.Default[""] = txt_kullaniciAdi.Text;
                //    Properties.Settings.Default[""] = txt_sifre.Text;
                //}
                //Properties.Settings.Default.Save();


                ekran fs = new ekran();

                fs.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }
        }

        private void save_Data()//beni hatırla işaretli ise şifre ve kullanıcı adı hafızaya alınacaktır
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.UserName = txt_kullaniciAdi.Text;
                Properties.Settings.Default.Password = txt_sifre.Text;
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
                MessageBox.Show("Test");
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
        }

        private void Init_Data()
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                if (Properties.Settings.Default.Remember == true)
                {
                    txt_kullaniciAdi.Text = Properties.Settings.Default.UserName;
                    txt_sifre.Text = Properties.Settings.Default.Password;
                    checkBox1.Checked = true;
                }
                else
                {
                    txt_kullaniciAdi.Text = Properties.Settings.Default.UserName;
                }
            }
        }





        private void btn_personel_Click(object sender, EventArgs e)
        {
            var personel = db.tbl_personeller.Where(x => x.mail == txt_kullaniciAdi.Text && x.sifre == txt_sifre.Text).FirstOrDefault();
            if (personel != null)
            {
                XtraMessageBox.Show("Giriş Başarılıdır");
                //if (checkBox1.Checked)
                //{
                //    Properties.Settings.Default["UserName"] = txt_kullaniciAdi.Text;
                //    Properties.Settings.Default["Password"] = txt_sifre.Text;
                //}
                //else
                //{
                //    Properties.Settings.Default[""] = txt_kullaniciAdi.Text;
                //    Properties.Settings.Default[""] = txt_sifre.Text;
                //}
                //Properties.Settings.Default.Save();
                PersonelGorevFormlari.personelFormu fr = new PersonelGorevFormlari.personelFormu();
                fr.mail = txt_kullaniciAdi.Text;

                fr.Show();
                this.Hide();

            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }
        }



        private void hlk_sifremiUnuttum_Click(object sender, EventArgs e)
        {
            sifremiUnuttum f3 = new sifremiUnuttum();
            f3.Show();
            this.Hide();
        }

        private void hlk_uygulamayiKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hlk_yardim_Click(object sender, EventArgs e)
        {
            yardim f4 = new yardim();
            f4.Show();
            this.Hide();
        }

        private void hlk_webPanel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Henüz Test Aşamasındadır");
        }
    }
}
