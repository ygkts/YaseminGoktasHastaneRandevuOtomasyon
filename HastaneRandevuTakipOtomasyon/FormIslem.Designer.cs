namespace HastaneRandevuTakipOtomasyon
{
    partial class FormIslem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIslem));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxSaat = new System.Windows.Forms.ComboBox();
            this.dateTimePickerIslemTarih = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSoyad = new System.Windows.Forms.ComboBox();
            this.comboBoxDoktorAd = new System.Windows.Forms.ComboBox();
            this.comboBoxHastaSoyad = new System.Windows.Forms.ComboBox();
            this.comboBoxHastaAd = new System.Windows.Forms.ComboBox();
            this.comboBoxHastaTC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxAra);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(26, 395);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(994, 338);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevular";
            // 
            // textBoxAra
            // 
            this.textBoxAra.Location = new System.Drawing.Point(221, 21);
            this.textBoxAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(253, 22);
            this.textBoxAra.TabIndex = 13;
            this.textBoxAra.TextChanged += new System.EventHandler(this.textBoxAra_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(88, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ada Göre Ara :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(949, 251);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxSaat);
            this.groupBox1.Controls.Add(this.dateTimePickerIslemTarih);
            this.groupBox1.Controls.Add(this.comboBoxSoyad);
            this.groupBox1.Controls.Add(this.comboBoxDoktorAd);
            this.groupBox1.Controls.Add(this.comboBoxHastaSoyad);
            this.groupBox1.Controls.Add(this.comboBoxHastaAd);
            this.groupBox1.Controls.Add(this.comboBoxHastaTC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(994, 226);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgi Girişleri";
            // 
            // comboBoxSaat
            // 
            this.comboBoxSaat.FormattingEnabled = true;
            this.comboBoxSaat.Location = new System.Drawing.Point(175, 178);
            this.comboBoxSaat.Name = "comboBoxSaat";
            this.comboBoxSaat.Size = new System.Drawing.Size(258, 24);
            this.comboBoxSaat.TabIndex = 11;
            // 
            // dateTimePickerIslemTarih
            // 
            this.dateTimePickerIslemTarih.Location = new System.Drawing.Point(175, 137);
            this.dateTimePickerIslemTarih.Name = "dateTimePickerIslemTarih";
            this.dateTimePickerIslemTarih.Size = new System.Drawing.Size(258, 22);
            this.dateTimePickerIslemTarih.TabIndex = 8;
            // 
            // comboBoxSoyad
            // 
            this.comboBoxSoyad.FormattingEnabled = true;
            this.comboBoxSoyad.Location = new System.Drawing.Point(175, 92);
            this.comboBoxSoyad.Name = "comboBoxSoyad";
            this.comboBoxSoyad.Size = new System.Drawing.Size(258, 24);
            this.comboBoxSoyad.TabIndex = 7;
            // 
            // comboBoxDoktorAd
            // 
            this.comboBoxDoktorAd.FormattingEnabled = true;
            this.comboBoxDoktorAd.Location = new System.Drawing.Point(175, 38);
            this.comboBoxDoktorAd.Name = "comboBoxDoktorAd";
            this.comboBoxDoktorAd.Size = new System.Drawing.Size(258, 24);
            this.comboBoxDoktorAd.TabIndex = 7;
            this.comboBoxDoktorAd.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoktorAd_SelectedIndexChanged);
            // 
            // comboBoxHastaSoyad
            // 
            this.comboBoxHastaSoyad.FormattingEnabled = true;
            this.comboBoxHastaSoyad.Location = new System.Drawing.Point(697, 146);
            this.comboBoxHastaSoyad.Name = "comboBoxHastaSoyad";
            this.comboBoxHastaSoyad.Size = new System.Drawing.Size(276, 24);
            this.comboBoxHastaSoyad.TabIndex = 7;
            // 
            // comboBoxHastaAd
            // 
            this.comboBoxHastaAd.FormattingEnabled = true;
            this.comboBoxHastaAd.Location = new System.Drawing.Point(697, 93);
            this.comboBoxHastaAd.Name = "comboBoxHastaAd";
            this.comboBoxHastaAd.Size = new System.Drawing.Size(276, 24);
            this.comboBoxHastaAd.TabIndex = 7;
            // 
            // comboBoxHastaTC
            // 
            this.comboBoxHastaTC.FormattingEnabled = true;
            this.comboBoxHastaTC.Location = new System.Drawing.Point(697, 35);
            this.comboBoxHastaTC.Name = "comboBoxHastaTC";
            this.comboBoxHastaTC.Size = new System.Drawing.Size(276, 24);
            this.comboBoxHastaTC.TabIndex = 7;
            this.comboBoxHastaTC.SelectedIndexChanged += new System.EventHandler(this.comboBoxHastaTC_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Doktor Ad :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Saat :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "İşlem Tarih :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta Ad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Doktor Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hasta TC :";
            // 
            // buttonSil
            // 
            this.buttonSil.Image = global::HastaneRandevuTakipOtomasyon.Properties.Resources.iconfinder_free_27_616650;
            this.buttonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSil.Location = new System.Drawing.Point(441, 21);
            this.buttonSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(87, 75);
            this.buttonSil.TabIndex = 6;
            this.buttonSil.Text = "SİL";
            this.buttonSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Image = global::HastaneRandevuTakipOtomasyon.Properties.Resources.iconfinder_refresh_reload_update_2_2571204;
            this.buttonGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuncelle.Location = new System.Drawing.Point(697, 20);
            this.buttonGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(162, 76);
            this.buttonGuncelle.TabIndex = 6;
            this.buttonGuncelle.Text = "GÜNCELLE";
            this.buttonGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Image = global::HastaneRandevuTakipOtomasyon.Properties.Resources.Martz90_Circle_Addon1_Text_plus;
            this.buttonKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKaydet.Location = new System.Drawing.Point(146, 21);
            this.buttonKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(124, 76);
            this.buttonKaydet.TabIndex = 1;
            this.buttonKaydet.Text = " KAYDET";
            this.buttonKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSil);
            this.groupBox2.Controls.Add(this.buttonKaydet);
            this.groupBox2.Controls.Add(this.buttonGuncelle);
            this.groupBox2.Location = new System.Drawing.Point(26, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(994, 115);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // FormIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1055, 748);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIslem";
            this.Text = "Randevu";
            this.Load += new System.EventHandler(this.FormIslem_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerIslemTarih;
        private System.Windows.Forms.ComboBox comboBoxSoyad;
        private System.Windows.Forms.ComboBox comboBoxDoktorAd;
        private System.Windows.Forms.ComboBox comboBoxHastaSoyad;
        private System.Windows.Forms.ComboBox comboBoxHastaAd;
        private System.Windows.Forms.ComboBox comboBoxHastaTC;
        private System.Windows.Forms.TextBox textBoxAra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxSaat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}