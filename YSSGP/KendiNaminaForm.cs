using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YSSGP.Sınıflar;

namespace YSSGP
{
    public partial class KendiNaminaForm : Form
    {
        private static KendiNaminaForm form;
        int kendinaminacalisancount;
        private static ToolStripStatusLabel aciklamalbl;
        private List<KendiNaminaCalisan> kendinaminacalisanlar;
        public KendiNaminaForm()
        {
            InitializeComponent();
        }
        public static KendiNaminaForm FormuGoster(ToolStripStatusLabel lbl)
        {
            if (form==null)
            {
                form = new KendiNaminaForm();
            }
            aciklamalbl = lbl;
            return form;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string sonuc = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                int index = Convert.ToInt32(sonuc) - 1;
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                aciklamalbl.Text = kendinaminacalisanlar[index].adsoyad + " silindi";
                kendinaminacalisanlar.RemoveAt(index);
                kendinaminacalisancount--;
                int no = 1;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = no;
                    no++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KendiNaminaCalisan yeni = new KendiNaminaCalisan();
            yeni.adres = txtAdres.Text;
            yeni.adsoyad = txtAdSoyad.Text;
            yeni.baslangictarih = dtBaslangic.Value;
            yeni.bitistarih = dtBitis.Value;
            
            yeni.isler = txtISler.Text;
            yeni.tckimlikno = "";
            kendinaminacalisanlar.Add(yeni);
            object[] values = new object[7];
            kendinaminacalisancount++;
            values[0] = kendinaminacalisancount;
            values[1] = yeni.adsoyad;
            values[2] = yeni.tckimlikno;
            values[3] = yeni.adres;
            values[4] = yeni.isler;
            values[5] = yeni.baslangictarih.ToShortDateString();
            values[6] = yeni.bitistarih.ToShortDateString();

            dataGridView1.Rows.Add(values);
            aciklamalbl.Text = yeni.adsoyad + " eklendi.";
        }

        private void KendiNaminaForm_Load(object sender, EventArgs e)
        {
            kendinaminacalisanlar = Proje.kendiNaminaCalisanlarListesi;
            int i = 0;
            if (kendinaminacalisanlar.Count > 0)
            {
                foreach (KendiNaminaCalisan alt in kendinaminacalisanlar)
                {
                    object[] values = new object[7];
                    i++;
                    values[0] = i;
                    values[1] = alt.adsoyad;
                    values[2] = alt.tckimlikno;
                    values[3] = alt.adres;
                    values[4] = alt.isler;
                    values[5] = alt.baslangictarih.ToShortDateString();
                    values[6] = alt.bitistarih.ToShortDateString();

                    dataGridView1.Rows.Add(values);
                }


            }
            kendinaminacalisancount = kendinaminacalisanlar.Count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proje.kendiNaminaCalisanlarListesi = kendinaminacalisanlar;
            aciklamalbl.Text = "Kendi namına çalışanlar listesi güncellendi.";
        }
        int index = -1;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string sonuc = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                index = Convert.ToInt32(sonuc) - 1;
                txtAdres.Text = kendinaminacalisanlar[index].adres;
                txtAdSoyad.Text = kendinaminacalisanlar[index].adsoyad;
               
                txtISler.Text = kendinaminacalisanlar[index].isler;
               
                dtBaslangic.Value = kendinaminacalisanlar[index].baslangictarih;
                dtBitis.Value = kendinaminacalisanlar[index].bitistarih;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedRows[0].Cells["Column2"].Value = txtAdSoyad.Text;
            dataGridView1.SelectedRows[0].Cells["Column3"].Value = "";
            dataGridView1.SelectedRows[0].Cells["Column4"].Value = txtAdres.Text;
            dataGridView1.SelectedRows[0].Cells["Column5"].Value = txtISler.Text;
            dataGridView1.SelectedRows[0].Cells["Column6"].Value = dtBaslangic.Value.ToShortDateString();
            dataGridView1.SelectedRows[0].Cells["Column7"].Value = dtBitis.Value.ToShortDateString();
            KendiNaminaCalisan yeni = new KendiNaminaCalisan();
            yeni.adres = txtAdres.Text;
            yeni.adsoyad = txtAdSoyad.Text;
            yeni.baslangictarih = dtBaslangic.Value;
            yeni.bitistarih = dtBitis.Value;

            yeni.isler = txtISler.Text;
            yeni.tckimlikno = "";
            kendinaminacalisanlar[index]=yeni;
            aciklamalbl.Text = yeni.adsoyad + " bilgileri güncellendi.";
        }
    }
}
