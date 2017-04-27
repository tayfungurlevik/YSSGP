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
    public partial class Ek4Form : Form
    {
        public static Ek4Form formum;
        private static ToolStripStatusLabel aciklamalbl;
        public static Ek4Form FormuGoster(ToolStripStatusLabel lbl)
        {
            if (formum == null)
            {
                formum = new Ek4Form();

            }
            aciklamalbl = lbl;
            return formum;
        }
        public Ek4Form()
        {
            InitializeComponent();
            ekdort = new List<Ek_4>();
        }
        List<Ek_4> ekdort;

        private void Ek4Form_Load(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0)
            {
                for (int i = 0; i < Proje.ekdortmaddeleri.Count; i++)
                {
                    DataGridViewRow yenisatır = new DataGridViewRow();
                    yenisatır.CreateCells(dataGridView1);
                    yenisatır.Cells[0].Value = Proje.ekdortmaddeleri[i].KKD;
                    yenisatır.Cells[1].Value = Proje.ekdortmaddeleri[i].Kategori;
                    yenisatır.Cells[2].Value = Proje.ekdortmaddeleri[i].BakımSüresi;
                    yenisatır.Cells[3].Value = Proje.ekdortmaddeleri[i].MakSüre;
                    yenisatır.Cells[4].Value = Proje.ekdortmaddeleri[i].Standart;
                    dataGridView1.Rows.Add(yenisatır);

                }

            }
            else
            {
                //eğer gridde veri varsa yenileri eklemeye gerek yok
                return;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DataGridViewRow yenisatır = new DataGridViewRow();
            yenisatır.CreateCells(dataGridView1);
            yenisatır.Cells[0].Value = txtKKD.Text;
            yenisatır.Cells[1].Value = cmb_Kat.SelectedValue.ToString();
            yenisatır.Cells[2].Value = txtBakım.Text;
            yenisatır.Cells[3].Value = txtSure.Text;
            yenisatır.Cells[4].Value = txtStandart.Text;
            dataGridView1.Rows.Add(yenisatır);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = txtKKD.Text;
                dataGridView1.SelectedRows[0].Cells[1].Value = cmb_Kat.SelectedValue.ToString();
                dataGridView1.SelectedRows[0].Cells[2].Value = txtBakım.Text;
                dataGridView1.SelectedRows[0].Cells[3].Value = txtSure.Text;
                dataGridView1.SelectedRows[0].Cells[4].Value = txtStandart.Text;

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Ek_4 yeniek = new Ek_4();
                yeniek.KKD = row.Cells[0].Value.ToString();
                yeniek.Kategori = row.Cells[1].Value.ToString();
                yeniek.BakımSüresi = row.Cells[2].Value.ToString();
                yeniek.MakSüre = row.Cells[3].Value.ToString();
                yeniek.Standart = row.Cells[4].Value.ToString();
                
                ekdort.Add(yeniek);
            }
            Proje.ekdortmaddeleri = ekdort;
            aciklamalbl.Text = "İş ekipmaları listesi kaydedildi.";
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                txtKKD.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                cmb_Kat.SelectedValue = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtBakım.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtSure.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtStandart.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            }
        }
    }
}
