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
    public partial class Ek5Form : Form
    {
        public static Ek5Form formum;
        private static ToolStripStatusLabel aciklamalbl;
        public Ek5Form()
        {
            InitializeComponent();
            ekbes = new List<Ek_5>();
        }
        public static Ek5Form FormuGoster(ToolStripStatusLabel lbl)
        {
            if (formum == null)
            {
                formum = new Ek5Form();

            }
            aciklamalbl = lbl;
            return formum;
        }
        List<Ek_5> ekbes;

        private void btnEKle_Click(object sender, EventArgs e)
        {
            DataGridViewRow yenisatır = new DataGridViewRow();
            yenisatır.CreateCells(dataGridView1);
            yenisatır.Cells[0].Value = textBox1.Text;
            yenisatır.Cells[1].Value = textBox2.Text;
            yenisatır.Cells[2].Value = textBox3.Text;
            yenisatır.Cells[3].Value = textBox4.Text;
            
            dataGridView1.Rows.Add(yenisatır);
        }

        private void Ek5Form_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            for (int i = 0; i < Proje.ekbesmaddeleri.Count; i++)
                {
                    DataGridViewRow yenisatır = new DataGridViewRow();
                    yenisatır.CreateCells(dataGridView1);
                    yenisatır.Cells[0].Value = Proje.ekbesmaddeleri[i].YerinTarifi;
                    yenisatır.Cells[1].Value = Proje.ekbesmaddeleri[i].SınırlıGeçişSebebi;
                    yenisatır.Cells[2].Value = Proje.ekbesmaddeleri[i].GirişeİzinliKişi;
                    yenisatır.Cells[3].Value = Proje.ekbesmaddeleri[i].Prosedür;

                    dataGridView1.Rows.Add(yenisatır);

                }

           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = textBox1.Text;
                dataGridView1.SelectedRows[0].Cells[1].Value = textBox2.Text;
                dataGridView1.SelectedRows[0].Cells[2].Value = textBox3.Text;
                dataGridView1.SelectedRows[0].Cells[3].Value = textBox4.Text;

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
                Ek_5 yeniek = new Ek_5();
                yeniek.YerinTarifi = row.Cells[0].Value.ToString();
                yeniek.SınırlıGeçişSebebi = row.Cells[1].Value.ToString();
                yeniek.GirişeİzinliKişi = row.Cells[2].Value.ToString();
                yeniek.Prosedür = row.Cells[3].Value.ToString();
                

                ekbes.Add(yeniek);
            }
            Proje.ekbesmaddeleri = ekbes;
            aciklamalbl.Text = "SINIRLI GİRİŞ SAĞLANACAK YERLERİN LİSTESİ kaydedildi.";
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                

            }
        }
    }
}
