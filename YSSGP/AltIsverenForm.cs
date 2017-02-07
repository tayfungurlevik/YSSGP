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
    public partial class AltIsverenForm : Form
    {
        private static AltIsverenForm formum;
        private List<AltIsverenBilgileri> altisverenler;
        private static ToolStripStatusLabel anaformlbl;
        int altisverencount;
        public AltIsverenForm()
        {
            InitializeComponent();
        }
        public static AltIsverenForm FormuGoster( ToolStripStatusLabel lbl)
        {
            if (formum==null)
            {
                formum = new AltIsverenForm();
            }
            anaformlbl = lbl;
            return formum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AltIsverenBilgileri yeni = new AltIsverenBilgileri();
            yeni.adres = txtAdres.Text;
            yeni.altisveren = txtAltIsveren.Text;
            yeni.baslangictarih = dtBaslangic.Value;
            yeni.bitistarih = dtBitis.Value;
            yeni.hekimad = txtHekimAd.Text;
            yeni.hekimsert = txtHekimSert.Text;
            yeni.isguzmanad = txtisguzmAd.Text;
            yeni.isguzmansert = txtisguzmSert.Text;
            yeni.isler = txtISler.Text;
            yeni.sgk = txtSgkSicilNo.Text;
            altisverenler.Add(yeni);
            object[] values = new object[7];
            altisverencount++;
            values[0] = altisverencount;
            values[1] = yeni.altisveren;
            values[2] = yeni.sgk;
            values[3] = yeni.adres;
            values[4] = yeni.isler;
            values[5] = yeni.baslangictarih.ToShortDateString();
            values[6] = yeni.bitistarih.ToShortDateString();
            

            dataGridView1.Rows.Add(values);
            //Form1..Controls.Find("toolStripStatusLabel2",true)[0].Text = "Alt işveren ("+yeni.altisveren+") eklendi";
            anaformlbl.Text = "Alt işveren (" + yeni.altisveren + ") eklendi";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Proje.altisverenListesi = altisverenler;
           // Form1.toolStripStatusLabel1.Text = "Alt işveren listesi kaydedildi.";
        }

        private void AltIsverenForm_Load(object sender, EventArgs e)
        {
            altisverenler = Proje.altisverenListesi;
            int i=0;
            if (altisverenler.Count>0)
            {
                foreach (AltIsverenBilgileri alt in altisverenler)
                {
                    object[] values = new object[7];
                    i++;
                    values[0] = i ;
                        values[1] = alt.altisveren;
                    values[2] = alt.sgk;
                    values[3] = alt.adres;
                    values[4] = alt.isler;
                    values[5] = alt.baslangictarih.ToShortDateString();
                    values[6] = alt.bitistarih.ToShortDateString();
                    
                    dataGridView1.Rows.Add(values);
                }
                
              
            }
            altisverencount = altisverenler.Count;
        }
        int index = -1;
        

        

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                string sonuc = dataGridView1.SelectedRows[0].Cells["No"].Value.ToString();
                index = Convert.ToInt32(sonuc) - 1;
                txtAdres.Text = altisverenler[index].adres;
                txtAltIsveren.Text = altisverenler[index].altisveren;
                txtHekimAd.Text = altisverenler[index].hekimad;
                txtHekimSert.Text = altisverenler[index].hekimsert;
                txtisguzmAd.Text = altisverenler[index].isguzmanad;
                txtisguzmSert.Text = altisverenler[index].isguzmansert;
                txtISler.Text = altisverenler[index].isler;
                txtSgkSicilNo.Text = altisverenler[index].sgk;
                dtBaslangic.Value = altisverenler[index].baslangictarih;
                dtBitis.Value = altisverenler[index].bitistarih;
            }

        }

        private void SilMenuItem_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string sonuc = dataGridView1.SelectedRows[0].Cells["No"].Value.ToString();
                int index = Convert.ToInt32(sonuc) - 1;
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                // Form1.toolStripStatusLabel1.Text = "Alt işveren("+altisverenler[index]+") silindi.";
                anaformlbl.Text = "Alt işveren(" + altisverenler[index].altisveren + ") silindi.";
                altisverenler.RemoveAt(index);
                altisverencount--;
                int no = 1;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = no;
                    no++;
                }
            }
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedRows[0].Cells["Altisveren"].Value = txtAltIsveren.Text;
            dataGridView1.SelectedRows[0].Cells["SgkSicilno"].Value = txtSgkSicilNo.Text;
            dataGridView1.SelectedRows[0].Cells["adres"].Value = txtAdres.Text;
            dataGridView1.SelectedRows[0].Cells["Isler"].Value = txtISler.Text;
            dataGridView1.SelectedRows[0].Cells["baslamaTarih"].Value = dtBaslangic.Value.ToShortDateString();
            dataGridView1.SelectedRows[0].Cells["bitisTarih"].Value = dtBitis.Value.ToShortDateString();
            AltIsverenBilgileri yeni = new AltIsverenBilgileri();
            yeni.adres = txtAdres.Text;
            yeni.altisveren = txtAltIsveren.Text;
            yeni.baslangictarih = dtBaslangic.Value;
            yeni.bitistarih = dtBitis.Value;
            yeni.hekimad = txtHekimAd.Text;
            yeni.hekimsert = txtHekimSert.Text;
            yeni.isguzmanad = txtisguzmAd.Text;
            yeni.isguzmansert = txtisguzmSert.Text;
            yeni.isler = txtISler.Text;
            yeni.sgk = txtSgkSicilNo.Text;
            altisverenler[index]=yeni;
            // Form1.toolStripStatusLabel1.Text = "Alt işveren (" + yeni.altisveren + ")" + " güncellendi.";
            anaformlbl.Text = "Alt işveren (" + yeni.altisveren + ")" + " güncellendi.";
        }

        
    }
}
