﻿namespace HastaneRandevuTakipOtomasyon
{
    partial class FormHasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHasta));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDogumTrh = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.comboBoxSosyelGuvenlik = new System.Windows.Forms.ComboBox();
            this.textBoxDogumYer = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxTC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxAra);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(39, 450);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(811, 338);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Araçlar";
            // 
            // textBoxAra
            // 
            this.textBoxAra.Location = new System.Drawing.Point(224, 31);
            this.textBoxAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(253, 22);
            this.textBoxAra.TabIndex = 15;
            this.textBoxAra.TextChanged += new System.EventHandler(this.textBoxAra_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(115, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Ada Göre Ara :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(767, 246);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxAdres);
            this.groupBox2.Controls.Add(this.textBoxTelefon);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.buttonSil);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.buttonGuncelle);
            this.groupBox2.Controls.Add(this.buttonKaydet);
            this.groupBox2.Location = new System.Drawing.Point(517, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(333, 406);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İleitşim Bilgileri";
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(99, 80);
            this.textBoxAdres.Multiline = true;
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(215, 131);
            this.textBoxAdres.TabIndex = 3;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(98, 37);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(215, 22);
            this.textBoxTelefon.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Telefon :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Adres :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Sosyal Güvenlik :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerDogumTrh);
            this.groupBox1.Controls.Add(this.comboBoxCinsiyet);
            this.groupBox1.Controls.Add(this.comboBoxSosyelGuvenlik);
            this.groupBox1.Controls.Add(this.textBoxDogumYer);
            this.groupBox1.Controls.Add(this.textBoxSoyad);
            this.groupBox1.Controls.Add(this.textBoxAd);
            this.groupBox1.Controls.Add(this.textBoxTC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(434, 406);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // dateTimePickerDogumTrh
            // 
            this.dateTimePickerDogumTrh.Location = new System.Drawing.Point(181, 189);
            this.dateTimePickerDogumTrh.Name = "dateTimePickerDogumTrh";
            this.dateTimePickerDogumTrh.Size = new System.Drawing.Size(215, 22);
            this.dateTimePickerDogumTrh.TabIndex = 5;
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "KIZ",
            "ERKEK"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(181, 296);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(215, 24);
            this.comboBoxCinsiyet.TabIndex = 4;
            // 
            // comboBoxSosyelGuvenlik
            // 
            this.comboBoxSosyelGuvenlik.FormattingEnabled = true;
            this.comboBoxSosyelGuvenlik.Items.AddRange(new object[] {
            "SSK",
            "BAĞKUR",
            "EMEKLİ SANDIĞI"});
            this.comboBoxSosyelGuvenlik.Location = new System.Drawing.Point(181, 342);
            this.comboBoxSosyelGuvenlik.Name = "comboBoxSosyelGuvenlik";
            this.comboBoxSosyelGuvenlik.Size = new System.Drawing.Size(215, 24);
            this.comboBoxSosyelGuvenlik.TabIndex = 4;
            // 
            // textBoxDogumYer
            // 
            this.textBoxDogumYer.Location = new System.Drawing.Point(181, 242);
            this.textBoxDogumYer.Name = "textBoxDogumYer";
            this.textBoxDogumYer.Size = new System.Drawing.Size(215, 22);
            this.textBoxDogumYer.TabIndex = 3;
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(181, 132);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(215, 22);
            this.textBoxSoyad.TabIndex = 3;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(181, 80);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(215, 22);
            this.textBoxAd.TabIndex = 3;
            // 
            // textBoxTC
            // 
            this.textBoxTC.Location = new System.Drawing.Point(181, 37);
            this.textBoxTC.Name = "textBoxTC";
            this.textBoxTC.Size = new System.Drawing.Size(215, 22);
            this.textBoxTC.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Doğum Tarih :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cinsiyet :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Doğum Yer :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "TC :";
            // 
            // buttonSil
            // 
            this.buttonSil.Image = global::HastaneRandevuTakipOtomasyon.Properties.Resources.iconfinder_free_27_616650;
            this.buttonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSil.Location = new System.Drawing.Point(197, 231);
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
            this.buttonGuncelle.Location = new System.Drawing.Point(42, 321);
            this.buttonGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(241, 65);
            this.buttonGuncelle.TabIndex = 6;
            this.buttonGuncelle.Text = "GÜNCELLE";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Image = global::HastaneRandevuTakipOtomasyon.Properties.Resources.Martz90_Circle_Addon1_Text_plus;
            this.buttonKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKaydet.Location = new System.Drawing.Point(42, 231);
            this.buttonKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(124, 76);
            this.buttonKaydet.TabIndex = 1;
            this.buttonKaydet.Text = " KAYDET";
            this.buttonKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // FormHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(885, 816);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHasta";
            this.Text = "Hasta";
            this.Load += new System.EventHandler(this.FormHasta_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.DateTimePicker dateTimePickerDogumTrh;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.ComboBox comboBoxSosyelGuvenlik;
        private System.Windows.Forms.TextBox textBoxDogumYer;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxTC;
        private System.Windows.Forms.TextBox textBoxAra;
        private System.Windows.Forms.Label label10;
    }
}