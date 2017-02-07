namespace YSSGP
{
    partial class ProjeBilgileriForm
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
            form = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjeBilgileriForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtProjeAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsinSahibi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProjeTanim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtProjeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtProjeBitis = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proje Adı:";
            // 
            // txtProjeAdi
            // 
            this.txtProjeAdi.Location = new System.Drawing.Point(215, 12);
            this.txtProjeAdi.Multiline = true;
            this.txtProjeAdi.Name = "txtProjeAdi";
            this.txtProjeAdi.Size = new System.Drawing.Size(322, 59);
            this.txtProjeAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "İşin Sahibi / İhale Makamı:";
            // 
            // txtIsinSahibi
            // 
            this.txtIsinSahibi.Location = new System.Drawing.Point(215, 89);
            this.txtIsinSahibi.Name = "txtIsinSahibi";
            this.txtIsinSahibi.Size = new System.Drawing.Size(322, 20);
            this.txtIsinSahibi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yapı Sahasının Açık Adresi \r\n(Cadde/Sokak/Ada/Parsel dahil)";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(215, 132);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(322, 46);
            this.txtAdres.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Projenin Tanımı ve Kapsamı ";
            // 
            // txtProjeTanim
            // 
            this.txtProjeTanim.Location = new System.Drawing.Point(215, 214);
            this.txtProjeTanim.Multiline = true;
            this.txtProjeTanim.Name = "txtProjeTanim";
            this.txtProjeTanim.Size = new System.Drawing.Size(322, 58);
            this.txtProjeTanim.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Projenin Başlangıç Tarihi ";
            // 
            // dtProjeBaslangic
            // 
            this.dtProjeBaslangic.Location = new System.Drawing.Point(215, 304);
            this.dtProjeBaslangic.Name = "dtProjeBaslangic";
            this.dtProjeBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dtProjeBaslangic.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Projenin Planlanan Bitiş Tarihi ";
            // 
            // dtProjeBitis
            // 
            this.dtProjeBitis.Location = new System.Drawing.Point(215, 330);
            this.dtProjeBitis.Name = "dtProjeBitis";
            this.dtProjeBitis.Size = new System.Drawing.Size(200, 20);
            this.dtProjeBitis.TabIndex = 6;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(422, 304);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(115, 46);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // ProjeBilgileriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(565, 375);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dtProjeBitis);
            this.Controls.Add(this.dtProjeBaslangic);
            this.Controls.Add(this.txtProjeTanim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIsinSahibi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProjeAdi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProjeBilgileriForm";
            this.Text = "Proje Bilgileri";
            this.Load += new System.EventHandler(this.ProjeBilgileriForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProjeAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIsinSahibi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProjeTanim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtProjeBaslangic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtProjeBitis;
        private System.Windows.Forms.Button btnKaydet;
    }
}