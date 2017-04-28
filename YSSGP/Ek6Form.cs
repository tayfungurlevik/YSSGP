using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YSSGP.Sınıflar;

namespace YSSGP
{
    public partial class Ek6Form : Form
    {
        public static Ek6Form formum;
        private static ToolStripStatusLabel aciklamalbl;
        public static Ek6Form FormuGoster(ToolStripStatusLabel lbl)
        {
            if (formum == null)
            {
                formum = new Ek6Form();

            }
            aciklamalbl = lbl;
            return formum;
        }
        public Ek6Form()
        {
            InitializeComponent();
            ekalti = new List<Ek_6>();
            
        }
        List<Ek_6> ekalti;
        private void Ek6Form_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Proje.ekaltimaddeleri.Count; i++)
                {
                    DataGridViewRow yenisatır = new DataGridViewRow();
                    yenisatır.CreateCells(dataGridView1);
                    yenisatır.Cells[0].Value = Proje.ekaltimaddeleri[i].EğitimeKatılacaklar;
                    yenisatır.Cells[1].Value = Proje.ekaltimaddeleri[i].EğitiminKonusu;
                    yenisatır.Cells[2].Value = Proje.ekaltimaddeleri[i].HedefveAmaç;
                    yenisatır.Cells[3].Value = Proje.ekaltimaddeleri[i].EğitiminSüresi;
                    yenisatır.Cells[4].Value = Proje.ekaltimaddeleri[i].eğitimBaslangic;
                    yenisatır.Cells[5].Value = Proje.ekaltimaddeleri[i].eğitimBitis;
                    dataGridView1.Rows.Add(yenisatır);

                }

            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DataGridViewRow yenisatır = new DataGridViewRow();
            yenisatır.CreateCells(dataGridView1);
            yenisatır.Cells[0].Value =  textBox1.Text;
            yenisatır.Cells[1].Value = textBox2.Text;
            yenisatır.Cells[2].Value = textBox3.Text;
            yenisatır.Cells[3].Value = textBox4.Text;
            yenisatır.Cells[4].Value = dateTimePicker1.Text;
            yenisatır.Cells[5].Value = dateTimePicker2.Text;
            dataGridView1.Rows.Add(yenisatır);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = textBox1.Text;
                dataGridView1.SelectedRows[0].Cells[1].Value = textBox2.Text;
                dataGridView1.SelectedRows[0].Cells[2].Value = textBox3.Text;
                dataGridView1.SelectedRows[0].Cells[3].Value = textBox4.Text;
                dataGridView1.SelectedRows[0].Cells[4].Value = dateTimePicker1.Text;
                dataGridView1.SelectedRows[0].Cells[5].Value = dateTimePicker2.Text;

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    continue;
                }
                Ek_6 yeniek = new Ek_6();
                yeniek.EğitimeKatılacaklar = row.Cells[0].Value.ToString();
                yeniek.EğitiminKonusu = row.Cells[1].Value.ToString();
                yeniek.HedefveAmaç = row.Cells[2].Value.ToString();
                yeniek.EğitiminSüresi = row.Cells[3].Value.ToString();
                yeniek.eğitimBaslangic = Convert.ToDateTime(row.Cells[4].Value.ToString());
                yeniek.eğitimBitis = Convert.ToDateTime(row.Cells[5].Value.ToString());

                ekalti.Add(yeniek);
            }
            Proje.ekaltimaddeleri = ekalti;
            aciklamalbl.Text = "YILLIK EĞİTİM PROGRAMI kaydedildi.";
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                dateTimePicker2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

            }
        }
    }
}
