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
    public partial class Ek3Form : Form
    {
        public static Ek3Form formum;
        private static ToolStripStatusLabel aciklamalbl;
        public static Ek3Form FormuGoster(ToolStripStatusLabel lbl)
        {
            if (formum == null)
            {
                formum = new Ek3Form();

            }
            aciklamalbl = lbl;
            return formum;
        }
        public Ek3Form()
        {
            InitializeComponent();
            ekuc = new List<Ek_3>();
        }
        List<Ek_3> ekuc;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            DataGridViewRow yenisatır = new DataGridViewRow();
            yenisatır.CreateCells(dataGridView1);
            yenisatır.Cells[0].Value = txtEkipman.Text;
            yenisatır.Cells[1].Value = txtSahip.Text;
            yenisatır.Cells[2].Value = txtYetkinlik.Text;
            yenisatır.Cells[3].Value = txtGereklilik.Text;
            dataGridView1.Rows.Add(yenisatır);
        }

        private void Ek3Form_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
                for (int i = 0; i < Proje.ekucmaddeleri.Count; i++)
                {
                    DataGridViewRow yenisatır = new DataGridViewRow();
                    yenisatır.CreateCells(dataGridView1);
                    yenisatır.Cells[0].Value = Proje.ekucmaddeleri[i].İşEkipmanı;
                    yenisatır.Cells[1].Value = Proje.ekucmaddeleri[i].İşEkipmanıSahibi;
                    yenisatır.Cells[2].Value = Proje.ekucmaddeleri[i].KişilerinYetkinliği;
                    yenisatır.Cells[3].Value = Proje.ekucmaddeleri[i].Gereklilik;
                    dataGridView1.Rows.Add(yenisatır);

                }
                
            
               
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = txtEkipman.Text;
                dataGridView1.SelectedRows[0].Cells[1].Value = txtSahip.Text;
                dataGridView1.SelectedRows[0].Cells[2].Value = txtYetkinlik.Text;
                dataGridView1.SelectedRows[0].Cells[3].Value = txtGereklilik.Text;

            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count==1)
            {
                txtEkipman.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtSahip.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtYetkinlik.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtGereklilik.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value==null)
                {
                    continue;
                }
                Ek_3 yeniek3 = new Ek_3();
                yeniek3.İşEkipmanı = row.Cells[0].Value.ToString();
                yeniek3.İşEkipmanıSahibi = row.Cells[1].Value.ToString();
                yeniek3.KişilerinYetkinliği = row.Cells[2].Value.ToString();
                yeniek3.Gereklilik = row.Cells[3].Value.ToString();
                ekuc.Add(yeniek3);
            }
            Proje.ekucmaddeleri = ekuc;
            aciklamalbl.Text = "İş ekipmaları listesi kaydedildi.";
        }
    }
}
