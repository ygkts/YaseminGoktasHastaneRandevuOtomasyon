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
    public partial class FormBolum : Form
    {
        HastaneTakipYGEntities db;
        Bolum b;
        private int secilenID;
        public FormBolum()
        {
            InitializeComponent();
        }
        private void Doldur()
        {
            db = new HastaneTakipYGEntities();
            var bolumList = db.Bolums.Select(x => new
            {
                x.ID,
                x.BolumAd
            }).OrderBy(x => x.BolumAd).ToList();
            dataGridView1.DataSource = bolumList;
            dataGridView1.Columns[0].Visible = false;
        }

        private void FormBolum_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            b = db.Bolums.Find(secilenID);
            textBoxAd.Text = b.BolumAd;
        }
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            db = new HastaneTakipYGEntities();
            b = new Bolum();
            b.BolumAd = textBoxAd.Text;
            db.Bolums.Add(b);
            db.SaveChanges();
            MessageBox.Show("Ekleme Başarıyla Gerçekleşti. ☻");
            Doldur();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            db = new HastaneTakipYGEntities();
            b = db.Bolums.Find(secilenID);
            b.BolumAd = textBoxAd.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarıyla Gerçekleşti. ☻");
            Doldur();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            db = new HastaneTakipYGEntities();
            b = db.Bolums.Find(secilenID);
            db.Bolums.Remove(b);
            db.SaveChanges();
            MessageBox.Show("Silme Başarıyla Gerçekleşti. ☻");
            Doldur();
        }

    }
}
