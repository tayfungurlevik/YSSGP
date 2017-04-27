namespace YSSGP
{
    partial class Ek3Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSahip = new System.Windows.Forms.TextBox();
            this.txtGereklilik = new System.Windows.Forms.TextBox();
            this.txtYetkinlik = new System.Windows.Forms.TextBox();
            this.txtEkipman = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.İşEkipmanı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sahib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yetkinlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gereklilik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnKaydet);
            this.splitContainer1.Panel1.Controls.Add(this.btnGüncelle);
            this.splitContainer1.Panel1.Controls.Add(this.btnEkle);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtSahip);
            this.splitContainer1.Panel1.Controls.Add(this.txtGereklilik);
            this.splitContainer1.Panel1.Controls.Add(this.txtYetkinlik);
            this.splitContainer1.Panel1.Controls.Add(this.txtEkipman);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(813, 416);
            this.splitContainer1.SplitterDistance = 140;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(718, 92);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(637, 92);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGüncelle.TabIndex = 2;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(556, 93);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "İSG Yönünden Uygunluk Gerekliliği";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "İş Ekipmanını Kuracak/ Kullanacak Kişilerin Yetkinliği";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İş Ekipmanının Sahibi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İş Ekipmanı (Model/Seri No/Plaka No)";
            // 
            // txtSahip
            // 
            this.txtSahip.Location = new System.Drawing.Point(337, 41);
            this.txtSahip.Name = "txtSahip";
            this.txtSahip.Size = new System.Drawing.Size(213, 20);
            this.txtSahip.TabIndex = 0;
            // 
            // txtGereklilik
            // 
            this.txtGereklilik.Location = new System.Drawing.Point(337, 93);
            this.txtGereklilik.Name = "txtGereklilik";
            this.txtGereklilik.Size = new System.Drawing.Size(213, 20);
            this.txtGereklilik.TabIndex = 0;
            // 
            // txtYetkinlik
            // 
            this.txtYetkinlik.Location = new System.Drawing.Point(337, 67);
            this.txtYetkinlik.Name = "txtYetkinlik";
            this.txtYetkinlik.Size = new System.Drawing.Size(213, 20);
            this.txtYetkinlik.TabIndex = 0;
            // 
            // txtEkipman
            // 
            this.txtEkipman.Location = new System.Drawing.Point(337, 15);
            this.txtEkipman.Name = "txtEkipman";
            this.txtEkipman.Size = new System.Drawing.Size(213, 20);
            this.txtEkipman.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.İşEkipmanı,
            this.sahib,
            this.Yetkinlik,
            this.Gereklilik});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(813, 272);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // İşEkipmanı
            // 
            this.İşEkipmanı.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.İşEkipmanı.DefaultCellStyle = dataGridViewCellStyle9;
            this.İşEkipmanı.HeaderText = "İş Ekipmanı";
            this.İşEkipmanı.Name = "İşEkipmanı";
            // 
            // sahib
            // 
            this.sahib.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sahib.DefaultCellStyle = dataGridViewCellStyle10;
            this.sahib.HeaderText = "İş Ekipmanının Sahibi";
            this.sahib.Name = "sahib";
            // 
            // Yetkinlik
            // 
            this.Yetkinlik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Yetkinlik.DefaultCellStyle = dataGridViewCellStyle11;
            this.Yetkinlik.HeaderText = "İş Ekipmanını Kuracak/ Kullanacak Kişilerin Yetkinliği";
            this.Yetkinlik.Name = "Yetkinlik";
            // 
            // Gereklilik
            // 
            this.Gereklilik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gereklilik.DefaultCellStyle = dataGridViewCellStyle12;
            this.Gereklilik.HeaderText = "İSG Yönünden Uygunluk Gerekliliği";
            this.Gereklilik.Name = "Gereklilik";
            // 
            // Ek3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 416);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Ek3Form";
            this.Text = "Ek3Form";
            this.Load += new System.EventHandler(this.Ek3Form_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSahip;
        private System.Windows.Forms.TextBox txtGereklilik;
        private System.Windows.Forms.TextBox txtYetkinlik;
        private System.Windows.Forms.TextBox txtEkipman;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn İşEkipmanı;
        private System.Windows.Forms.DataGridViewTextBoxColumn sahib;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yetkinlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gereklilik;
    }
}