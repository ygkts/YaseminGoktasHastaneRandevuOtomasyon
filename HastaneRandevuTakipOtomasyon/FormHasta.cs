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
    public partial class FormHasta : Form
    {
        public FormHasta()
        {
            InitializeComponent();
        }
        HastaneTakipYGEntities db;
        Hasta h;
        private int secilenID;
        private void FormHasta_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        private void Doldur()
        {
            db = new HastaneTakipYGEntities();
            var hastaList = db.Hastas.Select(x => new
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
                x.SosyalGuvenlik
            }).OrderBy(x => x.Ad).ToList();
            dataGridView1.DataSource = hastaList;
            dataGridView1.Columns[0].Visible = false;
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            h = db.Hastas.Find(secilenID);
            textBoxTC.Text = h.TC;
            textBoxAd.Text = h.Ad;
            textBoxSoyad.Text =  h.Soyad;
            dateTimePickerDogumTrh.Value =  (DateTime)h.DTarih;
            textBoxDogumYer.Text =  h.DYeri;
            comboBoxCinsiyet.Text = h.Cinsiyet;
            textBoxAdres.Text = h.Adres;
            textBoxTelefon.Text = h.Telefon;
            comboBoxSosyelGuvenlik.Text =  h.SosyalGuvenlik;
        }
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            db = new HastaneTakipYGEntities();
            h = new Hasta();
            h.TC = textBoxTC.Text;
            h.Ad = textBoxAd.Text;
            h.Soyad = textBoxSoyad.Text;
            h.DTarih = dateTimePickerDogumTrh.Value;
            h.DYeri = textBoxDogumYer.Text;
            h.Cinsiyet = comboBoxCinsiyet.Text;
            h.Adres = textBoxAdres.Text;
            h.Telefon = textBoxTelefon.Text;
            h.SosyalGuvenlik = comboBoxSosyelGuvenlik.Text;
            db.Hastas.Add(h);
            db.SaveChanges();
            MessageBox.Show("Ekleme Başarıyla Gerçekleşti. ☻");
            Doldur();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            db = new HastaneTakipYGEntities();
            h = db.Hastas.Find(secilenID);
            h.TC = textBoxTC.Text;
            h.Ad = textBoxAd.Text;
            h.Soyad = textBoxSoyad.Text;
            h.DTarih = dateTimePickerDogumTrh.Value;
            h.DYeri = textBoxDogumYer.Text;
            h.Cinsiyet = comboBoxCinsiyet.Text;
            h.Adres = textBoxAdres.Text;
            h.Telefon = textBoxTelefon.Text;
            h.SosyalGuvenlik = comboBoxSosyelGuvenlik.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarıyla Gerçekleşti. ☻");
            Doldur();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            db = new HastaneTakipYGEntities();
            h = db.Hastas.Find(secilenID);
            db.Hastas.Remove(h);
            db.SaveChanges();
            MessageBox.Show("Silme Başarıyla Gerçekleşti. ☻");
            Doldur();
        }

        private void textBoxAra_TextChanged(object sender, EventArgs e)
        {
            var list = db.Hastas.Select(x => new
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
                x.SosyalGuvenlik
            }).Where(ara => ara.Ad.Contains(textBoxAra.Text)).ToList();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
        }
    }
}
