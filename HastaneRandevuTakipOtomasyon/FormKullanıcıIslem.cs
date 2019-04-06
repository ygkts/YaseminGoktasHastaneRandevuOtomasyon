using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuTakipOtomasyon
{
    public partial class FormKullanıcıIslem : Form
    {
        HastaneTakipYGEntities db;
        ImageConverter converter = new ImageConverter();
        Image img;
        MemoryStream ms;
        Memur m;
        private int secilenID;
        public FormKullanıcıIslem()
        {
            InitializeComponent();
        }

        private void Doldur()
        {
            db = new HastaneTakipYGEntities();
            var memurList = db.Memurs.Select(x => new
            {
                x.ID,
                x.TC,
                x.Ad,
                x.Soyad,
                x.DTarih,
                x.DYeri,
                x.Cinsiyet,
                x.Adres,
                x.Telefon,
                x.Resim,
                x.EMail,
                x.Sifre,
                x.YetkiDuzeyi
            }).OrderBy(x => x.Ad).ToList();
            dataGridView1.DataSource = memurList;
            dataGridView1.Columns[0].Visible = false;
        }

        private void FormKullanıcıIslem_Load(object sender, EventArgs e)
        {
            Doldur();

            img = pictureBoxSecilenResim.Image;
            ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            m = db.Memurs.Find(secilenID);
            textBoxTCNo.Text = m.TC;
            txtAd.Text = m.Ad;
            txtSoyad.Text = m.Soyad;
            dateTimePickerDogumTrh.Value = (DateTime)m.DTarih;
            textBoxDogumYer.Text = m.DYeri;
            comboBoxCinsiyet.Text = m.Cinsiyet;
            textBoxAdres.Text = m.Adres;
            txtTel.Text = m.Telefon;
            if (m.Resim != null)
            {
                pictureBoxSecilenResim.Image = (Image)converter.ConvertFrom(m.Resim);
                img = pictureBoxSecilenResim.Image;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
            txtEposta.Text = m.EMail;
            txtSifre.Text = m.Sifre;
            if (m.YetkiDuzeyi != null)
            {
                comboBoxYetkiDuzeyi.Text = m.YetkiDuzeyi.ToString();
            }   
        }

        private void btnResimSeç_Click(object sender, EventArgs e)
        {
                OpenFileDialog fdl = new OpenFileDialog();
                if (fdl.ShowDialog() == DialogResult.OK)
                {
                    img = Image.FromFile(fdl.FileName);
                    ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);

                    pictureBoxSecilenResim.Image = (Image)converter.ConvertFrom(ms.ToArray());
                }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            db = new HastaneTakipYGEntities(); 
            m = new Memur();
            m.TC = textBoxTCNo.Text;
            m.Ad = txtAd.Text;
            m.Soyad = txtSoyad.Text;
            m.DTarih = dateTimePickerDogumTrh.Value;
            m.DYeri = textBoxDogumYer.Text;
            m.Cinsiyet = comboBoxCinsiyet.Text;
            m.Adres = textBoxAdres.Text;
            m.Telefon = txtTel.Text;
            m.Resim = ms.ToArray();
            m.EMail = txtEposta.Text;
            m.Sifre = txtSifre.Text;
            m.YetkiDuzeyi = Convert.ToInt32(comboBoxYetkiDuzeyi.Text);
            db.Memurs.Add(m);
            db.SaveChanges();
            MessageBox.Show("Ekleme Başarıyla Gerçekleşti.");
            Doldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            db = new HastaneTakipYGEntities();
            m = db.Memurs.Find(secilenID);
            m.TC = textBoxTCNo.Text;
            m.Ad = txtAd.Text;
            m.Soyad = txtSoyad.Text;
            m.DTarih = dateTimePickerDogumTrh.Value;
            m.DYeri = textBoxDogumYer.Text;
            m.Cinsiyet = comboBoxCinsiyet.Text;
            m.Adres = textBoxAdres.Text;
            m.Telefon = txtTel.Text;
            m.Resim = ms.ToArray();
            m.EMail = txtEposta.Text;
            m.Sifre = txtSifre.Text;
            m.YetkiDuzeyi = Convert.ToInt32(comboBoxYetkiDuzeyi.Text);
            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarıyla Gerçekleşti.");
            Doldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            db = new HastaneTakipYGEntities();
            m = db.Memurs.Find(secilenID);
            db.Memurs.Remove(m);
            db.SaveChanges();
            MessageBox.Show("Silme Başarıyla Gerçekleşti.");
            Doldur();
        }

        private void textBoxAra_TextChanged(object sender, EventArgs e)
        {
            var list = db.Memurs.Select(x => new
            {
                x.ID,
                x.TC,
                x.Ad,
                x.Soyad,
                x.DTarih,
                x.DYeri,
                x.Cinsiyet,
                x.Adres,
                x.Telefon,
                x.Resim,
                x.EMail,
                x.Sifre,
                x.YetkiDuzeyi
            }).Where(ara => ara.Ad.Contains(textBoxAra.Text)).ToList();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
        }
    }
}
