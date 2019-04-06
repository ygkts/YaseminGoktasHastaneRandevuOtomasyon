using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuTakipOtomasyon
{
    public partial class FormKullaniciGiris : Form
    {
        public FormKullaniciGiris()
        {
            InitializeComponent();
        }
        HastaneTakipYGEntities context = new HastaneTakipYGEntities();
        public string kulMailAdres, kulSifre, hata;
        public bool hataDurumu;
        public string kulAd, kulSoyad;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            GirisIslemleri();
        }

        public int ID;
        Form1 form1 = new Form1();
        private void FormKullaniciGiris_Load(object sender, EventArgs e)
        {
            txtEmail.Text = "ak@gmail.com";
            txtSifre.Text = "123";
        }
        private void GirisIslemleri()
        {
            kulMailAdres = txtEmail.Text;
            kulSifre = txtSifre.Text;

            bool giris = Login(kulMailAdres, kulSifre);
            if (string.IsNullOrEmpty(kulMailAdres))
            {
                hata += "Mail adresi alanı hatalı girildi!...\n";
                hataDurumu = true;
            }
            if (string.IsNullOrEmpty(kulSifre))
            {
                hata += "Şifre alanı hatalı girildi!...";
                hataDurumu = true;
            }
            if (hataDurumu)
            {
                MessageBox.Show(hata, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            if (giris == false)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else if (giris == true)
            {
                this.Hide();
                form1.Show();
            }

        }
        private bool Login(string kMail, string kSifre)
        {
            var user = (from k in context.Memurs where (k.EMail == kMail  && k.Sifre == kSifre ) select k).FirstOrDefault();
            if (user != null)
            {
                form1.yetki = Convert.ToInt32((from y in context.Memurs where (y.EMail == kMail && y.Sifre == kSifre) select y.YetkiDuzeyi).FirstOrDefault());
                return true;
            }
            else
            {
                MessageBox.Show("Girilen bilgiler geçerli değil!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
