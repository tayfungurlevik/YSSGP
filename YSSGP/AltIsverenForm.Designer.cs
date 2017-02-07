namespace YSSGP
{
    partial class AltIsverenForm
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
            formum = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltIsverenForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHekimSert = new System.Windows.Forms.TextBox();
            this.txtHekimAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtisguzmSert = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtisguzmAd = new System.Windows.Forms.TextBox();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.txtISler = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtSgkSicilNo = new System.Windows.Forms.TextBox();
            this.txtAltIsveren = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altisveren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SgkSicilno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Isler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslamaTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitisTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SilMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.btnGuncelle);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.dtBitis);
            this.splitContainer1.Panel1.Controls.Add(this.dtBaslangic);
            this.splitContainer1.Panel1.Controls.Add(this.txtISler);
            this.splitContainer1.Panel1.Controls.Add(this.txtAdres);
            this.splitContainer1.Panel1.Controls.Add(this.txtSgkSicilNo);
            this.splitContainer1.Panel1.Controls.Add(this.txtAltIsveren);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(715, 502);
            this.splitContainer1.SplitterDistance = 366;
            this.splitContainer1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(420, 26);
            this.label11.TabIndex = 8;
            this.label11.Text = "* Alt işverenin gerçek kişi olması halinde Adı, Soyadı ve TC. Kimlik Numarası yaz" +
    "ılacaktır.\r\nNot: Sözleşme yapılan her alt işveren için bu tablo oluşturulacaktır" +
    ".";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(499, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Kaydet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(499, 273);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(204, 23);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(499, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHekimSert);
            this.groupBox2.Controls.Add(this.txtHekimAd);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(503, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşyeri Hekimi";
            // 
            // txtHekimSert
            // 
            this.txtHekimSert.Location = new System.Drawing.Point(94, 50);
            this.txtHekimSert.Name = "txtHekimSert";
            this.txtHekimSert.Size = new System.Drawing.Size(100, 20);
            this.txtHekimSert.TabIndex = 12;
            // 
            // txtHekimAd
            // 
            this.txtHekimAd.Location = new System.Drawing.Point(94, 23);
            this.txtHekimAd.Name = "txtHekimAd";
            this.txtHekimAd.Size = new System.Drawing.Size(100, 20);
            this.txtHekimAd.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-3, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Sertifika Sınıfı/No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ad Soyad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtisguzmSert);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtisguzmAd);
            this.groupBox1.Location = new System.Drawing.Point(499, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 105);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İş Güvenliği Uzmanı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Sertifika Sınıfı/No:";
            // 
            // txtisguzmSert
            // 
            this.txtisguzmSert.Location = new System.Drawing.Point(99, 55);
            this.txtisguzmSert.Name = "txtisguzmSert";
            this.txtisguzmSert.Size = new System.Drawing.Size(100, 20);
            this.txtisguzmSert.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ad Soyad:";
            // 
            // txtisguzmAd
            // 
            this.txtisguzmAd.Location = new System.Drawing.Point(99, 28);
            this.txtisguzmAd.Name = "txtisguzmAd";
            this.txtisguzmAd.Size = new System.Drawing.Size(100, 20);
            this.txtisguzmAd.TabIndex = 8;
            // 
            // dtBitis
            // 
            this.dtBitis.Location = new System.Drawing.Point(166, 215);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(200, 20);
            this.dtBitis.TabIndex = 6;
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.Checked = false;
            this.dtBaslangic.Location = new System.Drawing.Point(166, 187);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dtBaslangic.TabIndex = 5;
            // 
            // txtISler
            // 
            this.txtISler.Location = new System.Drawing.Point(166, 135);
            this.txtISler.Multiline = true;
            this.txtISler.Name = "txtISler";
            this.txtISler.Size = new System.Drawing.Size(272, 46);
            this.txtISler.TabIndex = 4;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(166, 80);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(272, 47);
            this.txtAdres.TabIndex = 3;
            // 
            // txtSgkSicilNo
            // 
            this.txtSgkSicilNo.Location = new System.Drawing.Point(166, 50);
            this.txtSgkSicilNo.Name = "txtSgkSicilNo";
            this.txtSgkSicilNo.Size = new System.Drawing.Size(272, 20);
            this.txtSgkSicilNo.TabIndex = 2;
            // 
            // txtAltIsveren
            // 
            this.txtAltIsveren.Location = new System.Drawing.Point(166, 22);
            this.txtAltIsveren.Name = "txtAltIsveren";
            this.txtAltIsveren.Size = new System.Drawing.Size(272, 20);
            this.txtAltIsveren.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sözleşme Bitiş Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sözleşme Başlangıç Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sözleşme Konusu İşler:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tebligat Adresi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "İşyeri SGK Sicil No. :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Alt İşveren:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Altisveren,
            this.SgkSicilno,
            this.adres,
            this.Isler,
            this.baslamaTarih,
            this.bitisTarih});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(715, 132);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // Altisveren
            // 
            this.Altisveren.HeaderText = "Alt İşveren";
            this.Altisveren.Name = "Altisveren";
            this.Altisveren.ReadOnly = true;
            // 
            // SgkSicilno
            // 
            this.SgkSicilno.HeaderText = "İşyeri SGK Sicil No. ";
            this.SgkSicilno.Name = "SgkSicilno";
            this.SgkSicilno.ReadOnly = true;
            // 
            // adres
            // 
            this.adres.HeaderText = "Tebligat Adresi";
            this.adres.Name = "adres";
            this.adres.ReadOnly = true;
            // 
            // Isler
            // 
            this.Isler.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Isler.HeaderText = "Sözleşme Konusu İşler";
            this.Isler.Name = "Isler";
            this.Isler.ReadOnly = true;
            // 
            // baslamaTarih
            // 
            this.baslamaTarih.HeaderText = "Sözleşmenin Başlama  Tarihi";
            this.baslamaTarih.Name = "baslamaTarih";
            this.baslamaTarih.ReadOnly = true;
            // 
            // bitisTarih
            // 
            this.bitisTarih.HeaderText = "Sözleşmenin Bitiş Tarihi";
            this.bitisTarih.Name = "bitisTarih";
            this.bitisTarih.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SilMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // SilMenuItem
            // 
            this.SilMenuItem.Name = "SilMenuItem";
            this.SilMenuItem.Size = new System.Drawing.Size(86, 22);
            this.SilMenuItem.Text = "Sil";
            this.SilMenuItem.Click += new System.EventHandler(this.SilMenuItem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 283);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(487, 52);
            this.label12.TabIndex = 16;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // AltIsverenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(715, 502);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltIsverenForm";
            this.ShowIcon = false;
            this.Text = "Alt işveren bilgileri";
            this.Load += new System.EventHandler(this.AltIsverenForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.TextBox txtISler;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtSgkSicilNo;
        private System.Windows.Forms.TextBox txtAltIsveren;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHekimSert;
        private System.Windows.Forms.TextBox txtHekimAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtisguzmSert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtisguzmAd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SilMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altisveren;
        private System.Windows.Forms.DataGridViewTextBoxColumn SgkSicilno;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Isler;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslamaTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitisTarih;
        private System.Windows.Forms.Label label12;
    }
}