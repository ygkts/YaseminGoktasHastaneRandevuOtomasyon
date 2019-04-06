namespace HastaneRandevuTakipOtomasyon
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eKLEGUNCELLESILISLEMLERIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dOKTORToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hASTAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bOLUMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hEMSIREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iŞLEMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aYARLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLinkedin = new System.Windows.Forms.PictureBox();
            this.pictureBoxGithub = new System.Windows.Forms.PictureBox();
            this.pictureBoxFacebook = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLinkedin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGithub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Hastane Randevu Sistemi";
            this.notifyIcon1.Visible = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(65, 65);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eKLEGUNCELLESILISLEMLERIToolStripMenuItem,
            this.iŞLEMToolStripMenuItem,
            this.aYARLARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1281, 73);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eKLEGUNCELLESILISLEMLERIToolStripMenuItem
            // 
            this.eKLEGUNCELLESILISLEMLERIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dOKTORToolStripMenuItem1,
            this.hASTAToolStripMenuItem1,
            this.bOLUMToolStripMenuItem,
            this.hEMSIREToolStripMenuItem});
            this.eKLEGUNCELLESILISLEMLERIToolStripMenuItem.Image = global::HastaneRandevuTakipOtomasyon.Properties.Resources.Ekle;
            this.eKLEGUNCELLESILISLEMLERIToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eKLEGUNCELLESILISLEMLERIToolStripMenuItem.Name = "eKLEGUNCELLESILISLEMLERIToolStripMenuItem";
            this.eKLEGUNCELLESILISLEMLERIToolStripMenuItem.Size = new System.Drawing.Size(286, 69);
            this.eKLEGUNCELLESILISLEMLERIToolStripMenuItem.Text = "EKLE/ GUNCELLE/ SIL ISLEMLERI";
            // 
            // dOKTORToolStripMenuItem1
            // 
            this.dOKTORToolStripMenuItem1.Image = global::HastaneRandevuTakipOtomasyon.Properties.Resources.Doctor;
            this.dOKTORToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dOKTORToolStripMenuItem1.Name = "dOKTORToolStripMenuItem1";
            this.dOKTORToolStripMenuItem1.Size = new System.Drawing.Size(185, 72);
            this.dOKTORToolStripMenuItem1.Text = "DOKTOR";
            this.dOKTORToolStripMenuItem1.Click += new System.EventHandler(this.dOKTORToolStripMenuItem1_Click);
            // 
            // hASTAToolStripMenuItem1
            // 
            this.hASTAToolStripMenuItem1.Image = global::HastaneRandevuTakipOtomasyon.Properties.Resources.sick;
            this.hASTAToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hASTAToolStripMenuItem1.Name = "hASTAToolStripMenuItem1";
            this.hASTAToolStripMenuItem1.Size = new System.Drawing.Size(185, 72);
            this.hASTAToolStripMenuItem1.Text = "HASTA";
            this.hASTAToolStripMenuItem1.Click += new System.EventHandler(this.hASTAToolStripMenuItem1_Click);
            // 
            // bOLUMToolStripMenuItem
            // 
            this.bOLUMToolStripMenuItem.Image = global::HastaneRandevuTakipOtomasyon.Properties.Resources.departmen;
            this.bOLUMToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bOLUMToolStripMenuItem.Name = "bOLUMToolStripMenuItem";
            this.bOLUMToolStripMenuItem.Size = new System.Drawing.Size(185, 72);
            this.bOLUMToolStripMenuItem.Text = "BOLUM";
            this.bOLUMToolStripMenuItem.Click += new System.EventHandler(this.bOLUMToolStripMenuItem_Click);
            // 
            // hEMSIREToolStripMenuItem
            // 
            this.hEMSIREToolStripMenuItem.Image = global::HastaneRandevuTakipOtomasyon.Properties.Resources.Nurse;
            this.hEMSIREToolStripMenuItem.Name = "hEMSIREToolStripMenuItem";
            this.hEMSIREToolStripMenuItem.Size = new System.Drawing.Size(185, 72);
            this.hEMSIREToolStripMenuItem.Text = "HEMSIRE";
            this.hEMSIREToolStripMenuItem.Click += new System.EventHandler(this.hEMSIREToolStripMenuItem_Click);
            // 
            // iŞLEMToolStripMenuItem
            // 
            this.iŞLEMToolStripMenuItem.Image = global::HastaneRandevuTakipOtomasyon.Properties.Resources.time_is_money;
            this.iŞLEMToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iŞLEMToolStripMenuItem.Name = "iŞLEMToolStripMenuItem";
            this.iŞLEMToolStripMenuItem.Size = new System.Drawing.Size(149, 69);
            this.iŞLEMToolStripMenuItem.Text = "RANDEVU";
            this.iŞLEMToolStripMenuItem.Click += new System.EventHandler(this.iŞLEMToolStripMenuItem_Click);
            // 
            // aYARLARToolStripMenuItem
            // 
            this.aYARLARToolStripMenuItem.Image = global::HastaneRandevuTakipOtomasyon.Properties.Resources.settings;
            this.aYARLARToolStripMenuItem.Name = "aYARLARToolStripMenuItem";
            this.aYARLARToolStripMenuItem.Size = new System.Drawing.Size(142, 69);
            this.aYARLARToolStripMenuItem.Text = "AYARLAR";
            this.aYARLARToolStripMenuItem.Click += new System.EventHandler(this.aYARLARToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(876, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "HOŞGELDİNİZ";
            // 
            // pictureBoxLinkedin
            // 
            this.pictureBoxLinkedin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLinkedin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxLinkedin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxLinkedin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLinkedin.Image = global::HastaneRandevuTakipOtomasyon.Properties.Resources.iconfinder_social_media_applications_14_linkedin_4102586;
            this.pictureBoxLinkedin.Location = new System.Drawing.Point(1136, 98);
            this.pictureBoxLinkedin.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLinkedin.Name = "pictureBoxLinkedin";
            this.pictureBoxLinkedin.Size = new System.Drawing.Size(88, 66);
            this.pictureBoxLinkedin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLinkedin.TabIndex = 4;
            this.pictureBoxLinkedin.TabStop = false;
            this.pictureBoxLinkedin.Click += new System.EventHandler(this.pictureBoxLinkedin_Click);
            // 
            // pictureBoxGithub
            // 
            this.pictureBoxGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGithub.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxGithub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxGithub.Image = global::HastaneRandevuTakipOtomasyon.Properties.Resources.iconfinder_github_2308116;
            this.pictureBoxGithub.Location = new System.Drawing.Point(972, 98);
            this.pictureBoxGithub.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxGithub.Name = "pictureBoxGithub";
            this.pictureBoxGithub.Size = new System.Drawing.Size(88, 66);
            this.pictureBoxGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGithub.TabIndex = 5;
            this.pictureBoxGithub.TabStop = false;
            this.pictureBoxGithub.Click += new System.EventHandler(this.pictureBoxGithub_Click);
            // 
            // pictureBoxFacebook
            // 
            this.pictureBoxFacebook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFacebook.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFacebook.Image = global::HastaneRandevuTakipOtomasyon.Properties.Resources.iconfinder_facebook_287801;
            this.pictureBoxFacebook.Location = new System.Drawing.Point(802, 98);
            this.pictureBoxFacebook.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFacebook.Name = "pictureBoxFacebook";
            this.pictureBoxFacebook.Size = new System.Drawing.Size(88, 66);
            this.pictureBoxFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFacebook.TabIndex = 6;
            this.pictureBoxFacebook.TabStop = false;
            this.pictureBoxFacebook.Click += new System.EventHandler(this.pictureBoxFacebook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HastaneRandevuTakipOtomasyon.Properties.Resources.hospital_CARTOON_BUİLD;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1281, 878);
            this.Controls.Add(this.pictureBoxLinkedin);
            this.Controls.Add(this.pictureBoxGithub);
            this.Controls.Add(this.pictureBoxFacebook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "HASTANE RANDEVU SİSTEMİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLinkedin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGithub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iŞLEMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eKLEGUNCELLESILISLEMLERIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dOKTORToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hASTAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bOLUMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hEMSIREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aYARLARToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLinkedin;
        private System.Windows.Forms.PictureBox pictureBoxGithub;
        private System.Windows.Forms.PictureBox pictureBoxFacebook;
    }
}

