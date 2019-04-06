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
    public partial class FormDoktor : Form
    {
        public FormDoktor()
        {
            InitializeComponent();
        }
        HastaneTakipYGEntities db;
        ImageConverter converter = new ImageConverter();
        Image img;
        MemoryStream ms;
        Doktor d;
        private int secilenID;
        private void Doldur()
        {
            db = new HastaneTakipYGEntities();
            var drList = db.Doktors.Select(x => new
            {
                x.ID,
                x.Ad,
                x.Soyad,
                x.DTarih,
                x.DYer,
                x.Cinsiyet,
                x.Adres,
                x.Telefon,
                x.Resim,
                x.BolumID,
                x.BolumAd,
            }).OrderBy(x => x.Ad).ToList();
            dataGridView1.DataSource = drList;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }
        private void ComboBolumDoldur()
        {
            db = new HastaneTakipYGEntities();
            var drList = db.Bolums.Select(x => new
            {
                x.ID,
                x.BolumAd,
            }).OrderBy(x => x.BolumAd).ToList();
            comboBoxBolum.DataSource = drList;
            comboBoxBolum.DisplayMember = "BolumAd";
            comboBoxBolum.ValueMember = "ID";
        }
        private void FormDoktor_Load(object sender, EventArgs e)
        {
            Doldur();
            ComboBolumDoldur();
            img = pictureBoxSecilenResim.Image;
            ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            d = db.Doktors.Find(secilenID);

            textBoxAD.Text = d.Ad;
            textBoxSoyad.Text = d.Soyad;
            dateTimePickerDogumTrh.Value = (DateTime)d.DTarih;
            textBoxDYer.Text = d.DYer;
            comboBoxCinsiyet.Text = d.Cinsiyet;
            textBoxAdres.Text = d.Adres;
            textBoxTelefon.Text = d.Telefon;
            if (d.Resim != null)
            {
                pictureBoxSecilenResim.Image = (Image)converter.ConvertFrom(d.Resim);
                img = pictureBoxSecilenResim.Image;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
            comboBoxBolum.Text = d.BolumAd;
        }
        private void buttonresimSec_Click(object sender, EventArgs e)
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

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            db = new HastaneTakipYGEntities();
            d = new Doktor();
            d.Ad = textBoxAD.Text;
            d.Soyad = textBoxSoyad.Text;
            d.DTarih = dateTimePickerDogumTrh.Value;
            d.DYer = textBoxDYer.Text;
            d.Cinsiyet = comboBoxCinsiyet.Text;
            d.Adres = textBoxAdres.Text;
            d.Telefon = textBoxTelefon.Text;
            d.Resim = ms.ToArray();
            d.BolumAd = comboBoxBolum.Text;
            db.Doktors.Add(d);
            db.SaveChanges();
            MessageBox.Show("Ekleme Başarıyla Gerçekleşti.");
            Doldur();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            db = new HastaneTakipYGEntities();
            d = db.Doktors.Find(secilenID);
            d.Ad = textBoxAD.Text;
            d.Soyad = textBoxSoyad.Text;
            d.DTarih = dateTimePickerDogumTrh.Value;
            d.DYer = textBoxDYer.Text;
            d.Cinsiyet = comboBoxCinsiyet.Text;
            d.Adres = textBoxAdres.Text;
            d.Telefon = textBoxTelefon.Text;
            d.Resim = ms.ToArray();
            d.BolumAd = comboBoxBolum.Text;

            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarıyla Gerçekleşti.");
            Doldur();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            db = new HastaneTakipYGEntities();
            d = db.Doktors.Find(secilenID);
            db.Doktors.Remove(d);
            db.SaveChanges();
            MessageBox.Show("Silme Başarıyla Gerçekleşti.");
            Doldur();
        }

        private void textBoxAra_TextChanged(object sender, EventArgs e)
        {
            var list = db.Doktors.Select(x => new
            {
                x.ID,
                x.Ad,
                x.Soyad,
                x.DTarih,
                x.DYer,
                x.Cinsiyet,
                x.Adres,
                x.Telefon,
                x.Resim,
                x.BolumID,
                x.BolumAd,
            }).Where(ara => ara.Ad.Contains(textBoxAra.Text)).ToList();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }
    }
}
