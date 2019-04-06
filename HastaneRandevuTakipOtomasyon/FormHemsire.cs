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
    public partial class FormHemsire : Form
    {
        public FormHemsire()
        {
            InitializeComponent();
        }
        HastaneTakipYGEntities db;
        ImageConverter converter = new ImageConverter();
        Image img;
        MemoryStream ms;
        Hemsire h;
        private int secilenID;
        private void FormHemsire_Load(object sender, EventArgs e)
        {
            Doldur();
            ComboBolumDoldur();
        }
        private void Doldur()
        {
            db = new HastaneTakipYGEntities();
            var hemList = db.Hemsires.Select(x => new
            {
                x.ID,
                x.Ad,
                x.Soyad,
                x.DTarih,
                x.DYer,
                x.Cinsiyet,
                x.Adres,
                x.Telefon,
                x.BolumID,
                x.BolumAd,
                x.Resim,
            }).OrderBy(x => x.Ad).ToList();
            dataGridView1.DataSource = hemList;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }
        private void ComboBolumDoldur()
        {
            db = new HastaneTakipYGEntities();
            var drList = db.Bolums.Select(x => new
            {
                x.ID,
                x.BolumAd,
            }).OrderBy(x => x.BolumAd).ToList();
            comboBoxBolumAd.DataSource = drList;
            comboBoxBolumAd.DisplayMember = "BolumAd";
            comboBoxBolumAd.ValueMember = "ID";
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            h = db.Hemsires.Find(secilenID);

            textBoxAd.Text = h.Ad;
            textBoxSoyad.Text = h.Soyad;
            dateTimePickerDogumTrh.Value = (DateTime)h.DTarih;
            textBoxDogumYer.Text = h.DYer;
            comboBoxCinsiyet.Text = h.Cinsiyet;
            textBoxADres.Text = h.Adres;
            textBoxTelefon.Text = h.Telefon;
            comboBoxBolumAd.Text = h.BolumAd;
            if (h.Resim != null)
            {
                pictureBoxSecilenResim.Image = (Image)converter.ConvertFrom(h.Resim);
                img = pictureBoxSecilenResim.Image;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            db = new HastaneTakipYGEntities();
            h = new Hemsire();

            h.Ad = textBoxAd.Text;
            h.Soyad = textBoxSoyad.Text;
            h.DTarih = dateTimePickerDogumTrh.Value;
            h.DYer = textBoxDogumYer.Text;
            h.Cinsiyet = comboBoxCinsiyet.Text;
            h.Adres = textBoxADres.Text;
            h.Telefon = textBoxTelefon.Text;
            h.BolumAd = comboBoxBolumAd.Text;
            h.Resim = ms.ToArray();
            db.Hemsires.Add(h);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarıyla Gerçekleşti. ☻");
            Doldur();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            db = new HastaneTakipYGEntities();
            h = db.Hemsires.Find(secilenID);

            h.Ad = textBoxAd.Text;
            h.Soyad = textBoxSoyad.Text;
            h.DTarih = dateTimePickerDogumTrh.Value;
            h.DYer = textBoxDogumYer.Text;
            h.Cinsiyet = comboBoxCinsiyet.Text;
            h.Adres = textBoxADres.Text;
            h.Telefon = textBoxTelefon.Text;
            h.BolumAd = comboBoxBolumAd.Text;
            h.Resim = ms.ToArray();
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti. ☻");
            Doldur();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            db = new HastaneTakipYGEntities();
            h = db.Hemsires.Find(secilenID);
            
            db.Hemsires.Remove(h);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti. ☻");
            Doldur();
        }

        private void textBoxAra_TextChanged(object sender, EventArgs e)
        {
            var list = db.Hemsires.Select(x => new
            {
                x.ID,
                x.Ad,
                x.Soyad,
                x.DTarih,
                x.DYer,
                x.Cinsiyet,
                x.Adres,
                x.Telefon,
                x.BolumID,
                x.BolumAd,
                x.Resim,
            }).Where(ara => ara.Ad.Contains(textBoxAra.Text)).ToList();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }
        
    }
}
