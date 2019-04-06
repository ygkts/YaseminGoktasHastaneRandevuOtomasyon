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
    public partial class FormIslem : Form
    {
        public FormIslem()
        {
            InitializeComponent();
        }
        HastaneTakipYGEntities db;
        Randevu r;
        RandevuSaat rs;
        Doktor dr;
        private int secilenID;
        private void FormIslem_Load(object sender, EventArgs e)
        {
            Doldur();
            ComboSaatDoldur();
            ComboHASTATCDoldur();
            ComboDRADDoldur();
        }
        private void Doldur()
        {
            db = new HastaneTakipYGEntities();
            var randevuList = db.Randevus.Select(x => new
            {
                x.ID,
                x.IslemTarih,
                x.HastaID,
                x.HastaTC,
                x.HastaAd,
                x.HastaSoyad,
                x.DoktorID,
                x.DoktorAd,
                x.DoktorSoyad,
                x.BolumID,
                x.BolumAd,
                x.SaatID,
                x.RandevuSaat
            }).OrderBy(x => x.IslemTarih).ToList();
            dataGridView1.DataSource = randevuList;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[11].Visible = false;
        }
        private void ComboSaatDoldur()
        {
            db = new HastaneTakipYGEntities();
            var saatList = db.RandevuSaats.Select(x => new
            {
                x.ID,
                x.RandevuSaat1,
                x.Durum
            }).OrderBy(x => x.RandevuSaat1).Where(d=>d.Durum == 0).ToList(); // Yalnızca müsait olan saatler comboya dolar
            comboBoxSaat.DataSource = saatList;
            comboBoxSaat.DisplayMember = "RandevuSaat1";
            comboBoxSaat.ValueMember = "ID";
        }
        private void ComboDRADDoldur()
        {
            db = new HastaneTakipYGEntities();
            var drList = db.Doktors.Select(x => new
            {
                x.ID,
                x.BolumAd,
                x.Ad,
            }).OrderBy(x => x.Ad).ToList();
            comboBoxDoktorAd.DataSource = drList;
            comboBoxDoktorAd.DisplayMember = "Ad";
            comboBoxDoktorAd.ValueMember = "ID";
        }
        private void ComboDRSOYADDoldur()
        {
            db = new HastaneTakipYGEntities();
            var drList = db.Doktors.Select(x => new
            {
                x.ID,
                x.Ad,
                x.Soyad,
            }).OrderBy(x => x.Soyad).Where(x => x.Ad == comboBoxDoktorAd.Text).ToList();
            comboBoxSoyad.DataSource = drList;
            comboBoxSoyad.DisplayMember = "Soyad";
            comboBoxSoyad.ValueMember = "ID";
        }
        private void ComboHASTATCDoldur()
        {
            db = new HastaneTakipYGEntities();
            var drList = db.Hastas.Select(x => new
            {
                x.ID,
                x.TC,
            }).OrderBy(x => x.TC).ToList();
            comboBoxHastaTC.DataSource = drList;
            comboBoxHastaTC.DisplayMember = "TC";
            comboBoxHastaTC.ValueMember = "ID";
        }
        private void ComboHASTAADDoldur()
        {
            db = new HastaneTakipYGEntities();
            var drList = db.Hastas.Select(x => new
            {
                x.ID,
                x.TC,
                x.Ad,
            }).OrderBy(x => x.Ad).Where(x=>x.TC == comboBoxHastaTC.Text).ToList();
            comboBoxHastaAd.DataSource = drList;
            comboBoxHastaAd.DisplayMember = "Ad";
            comboBoxHastaAd.ValueMember = "ID";
        }
        private void ComboHASTASOYADDoldur()
        {
            db = new HastaneTakipYGEntities();
            var drList = db.Hastas.Select(x => new
            {
                x.ID,
                x.TC,
                x.Soyad
            }).OrderBy(x => x.Soyad).Where(x=>x.TC == comboBoxHastaTC.Text).ToList();
            comboBoxHastaSoyad.DataSource = drList;
            comboBoxHastaSoyad.DisplayMember = "Soyad";
            comboBoxHastaSoyad.ValueMember = "ID";
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            r = db.Randevus.Find(secilenID);
            dateTimePickerIslemTarih.Value = (DateTime)r.IslemTarih;
            comboBoxHastaTC.Text = r.HastaTC;
            comboBoxHastaAd.Text = r.HastaAd;
            comboBoxHastaSoyad.Text = r.HastaSoyad;
            comboBoxDoktorAd.Text = r.DoktorAd;
            comboBoxSoyad.Text = r.DoktorSoyad;
        }
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            db = new HastaneTakipYGEntities();
            r = new Randevu();
            dr = new Doktor();
            r.IslemTarih = dateTimePickerIslemTarih.Value;
            r.HastaTC = comboBoxHastaTC.Text;
            r.HastaAd = comboBoxHastaAd.Text;
            r.HastaSoyad = comboBoxHastaSoyad.Text;
            r.HastaID = db.Hastas.Where(x => x.TC == comboBoxHastaTC.Text).Select(x => x.ID).FirstOrDefault();
            r.DoktorAd = comboBoxDoktorAd.Text;
            r.DoktorSoyad = comboBoxSoyad.Text;
            r.DoktorID = db.Doktors.Where(x => x.Ad == comboBoxDoktorAd.Text && x.Soyad == comboBoxSoyad.Text).Select(x => x.ID).FirstOrDefault();
            // combo dan seçilen doktora ait bölüm adı tablodaki bölümAd alanına eklenir:
            dr.BolumAd = db.Doktors.Where(x=>x.Ad == comboBoxDoktorAd.Text && x.Soyad == comboBoxSoyad.Text ).Select(x=>x.BolumAd).FirstOrDefault();
            r.BolumAd = dr.BolumAd;
            r.BolumID= db.Bolums.Where(x => x.BolumAd == dr.BolumAd).Select(x => x.ID).FirstOrDefault();
            r.RandevuSaat =  TimeSpan.Parse(comboBoxSaat.Text);
            db.Randevus.Add(r);
            // comboboxSaat'teki değere eşit lan randevu saatini first ile al ve onu durumunu 1 yap.
            rs = db.RandevuSaats.First(x => x.RandevuSaat1 == r.RandevuSaat);
            rs.Durum = 1;
            r.SaatID = db.RandevuSaats.Where(x => x.RandevuSaat1 == r.RandevuSaat).Select(x => x.ID).FirstOrDefault();
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı. ☻");
            Doldur();
            ComboSaatDoldur();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            r = db.Randevus.Find(secilenID);
            rs = db.RandevuSaats.First(x => x.RandevuSaat1 == r.RandevuSaat);
            rs.Durum = 0;   // randevu saat durumunu müsaite çevirdim.
            db.Randevus.Remove(r);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı. ☻");
            Doldur();
            ComboSaatDoldur();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            dr = new Doktor();
            r = db.Randevus.Find(secilenID);
            r.IslemTarih = dateTimePickerIslemTarih.Value;
            r.HastaTC = comboBoxHastaTC.Text;
            r.HastaAd = comboBoxHastaAd.Text;
            r.HastaSoyad = comboBoxHastaSoyad.Text;
            r.HastaID = db.Hastas.Where(x => x.TC == comboBoxHastaTC.Text).Select(x => x.ID).FirstOrDefault();
            r.DoktorAd = comboBoxDoktorAd.Text;
            r.DoktorSoyad = comboBoxSoyad.Text;
            r.DoktorID = db.Doktors.Where(x => x.Ad == comboBoxDoktorAd.Text && x.Soyad == comboBoxSoyad.Text).Select(x => x.ID).FirstOrDefault();
            // combo dan seçilen doktora ait bölüm adı tablodaki bölümAd alanına eklenir:
            dr.BolumAd = db.Doktors.Where(x => x.Ad == comboBoxDoktorAd.Text && x.Soyad == comboBoxSoyad.Text).Select(x => x.BolumAd).FirstOrDefault();
            r.BolumAd = dr.BolumAd;
            r.BolumID = db.Bolums.Where(x => x.BolumAd == dr.BolumAd).Select(x => x.ID).FirstOrDefault();
            //saat güncellenmeden  önce, güncellenmiş gibi durumu 1 yapılır:
            rs = db.RandevuSaats.First(x => x.RandevuSaat1 == r.RandevuSaat);
            rs.Durum = 0;
            r.RandevuSaat = TimeSpan.Parse(comboBoxSaat.Text);
            // güncelleme işleminden sonra ise yeni saat değeri için durum 0 yapılır:
            rs = db.RandevuSaats.First(x => x.RandevuSaat1 == r.RandevuSaat);
            rs.Durum = 1;
            r.SaatID = db.RandevuSaats.Where(x => x.RandevuSaat1 == r.RandevuSaat).Select(x => x.ID).FirstOrDefault();
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı. ☻");
            Doldur();
            ComboSaatDoldur();
        }

        private void comboBoxDoktorAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            // her doktor adı seçildiğinde tekrar tekrar bu combobox değişsin diye bu kodu yazmalıyız:
            ComboDRSOYADDoldur();
        }

        private void comboBoxHastaTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            // her tc seçildiğinde tc ye ail ad ve soyad bilgileri bu hasta ad ve soyad combolarında seçili gelmektedir.
            ComboHASTAADDoldur();
            ComboHASTASOYADDoldur();
        }
        private void textBoxAra_TextChanged(object sender, EventArgs e)
        {
            var list = db.Randevus.Select(x => new
            {
                x.IslemTarih,
                x.ID,
                x.HastaID,
                x.HastaTC,
                x.HastaAd,
                x.HastaSoyad,
                x.DoktorID,
                x.DoktorAd,
                x.DoktorSoyad,
                x.BolumID,
                x.BolumAd
            }).Where(ara => ara.HastaAd.Contains(textBoxAra.Text)).ToList();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }
        
        
    }
}
