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
    public partial class Form1 : Form
    {
        public int yetki;
        public Form1()
        {
            InitializeComponent();
        }
        private void dOKTORToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDoktor form = new FormDoktor();
            form.MdiParent = this;
            form.Show();
        }

        private void hASTAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormHasta form = new FormHasta();
            form.MdiParent = this;
            form.Show();
        }

        private void bOLUMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBolum form = new FormBolum();
            form.MdiParent = this;
            form.Show();
        }

        private void hEMSIREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHemsire form = new FormHemsire();
            form.MdiParent = this;
            form.Show();
        }

        private void iŞLEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIslem form = new FormIslem();
            form.MdiParent = this;
            form.Show();
        }

        private void aYARLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKullanıcıIslem form = new FormKullanıcıIslem();
            if (yetki >= 5)
            {
                form.MdiParent = this;
                form.Show();
            }
            else if (yetki < 5)
            {
                MessageBox.Show("Bu Alana Ulaşamazsınız! Ulaşmak için yetki Düzeyiniz 5 veya Üzeri olmalı!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void pictureBoxFacebook_Click(object sender, EventArgs e)
        {
            DialogResult mesaj = MessageBox.Show("Geliştiricinin Facebook Sayfasına Yönlendiriliyorsunuz!", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (mesaj == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/");
            }
        }

        private void pictureBoxGithub_Click(object sender, EventArgs e)
        {
            DialogResult mesaj = MessageBox.Show("Geliştiricinin Github Sayfasına Yönlendiriliyorsunuz!", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (mesaj == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://github.com/ygkts");
            }   
        }

        private void pictureBoxLinkedin_Click(object sender, EventArgs e)
        {
            DialogResult mesaj = MessageBox.Show("Geliştiricinin Linkedin Sayfasına Yönlendiriliyorsunuz!", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (mesaj == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://www.linkedin.com/in/yasemin-g%C3%B6kta%C5%9F-07b892127/");
            }
        }
    }
}
