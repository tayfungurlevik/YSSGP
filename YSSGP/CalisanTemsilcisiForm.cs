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
    public partial class CalisanTemsilcisiForm : Form
    {
        public CalisanTemsilcisiForm()
        {
            InitializeComponent();
        }
        public static CalisanTemsilcisiForm formum;
        private static ToolStripStatusLabel aciklamalbl;
        public static CalisanTemsilcisiForm FormuGoster(ToolStripStatusLabel lbl)
        {
            if (formum == null)
            {
                formum = new CalisanTemsilcisiForm();

            }
            aciklamalbl = lbl;
            return formum;
        }
        private List<CalisanTemsilcisi> calisantemsilciler = new List<CalisanTemsilcisi>();
        private CalisanTemsilcisi yenitemsilci;
        private void button1_Click(object sender, EventArgs e)
        {
            object[] vals = new object[4];
            vals[0] = txtAd.Text;
            vals[1] = "";
            vals[2] = txtGorev.Text;
            vals[3] = txtIletisim.Text;
            dataGridView1.Rows.Add(vals);
            CalisanTemsilcisi ct = new CalisanTemsilcisi();
            ct.ad = txtAd.Text;
            ct.tc = "";
            ct.gorevi = txtGorev.Text;
            ct.iletişim = txtIletisim.Text;
            ct.gorevvesorumluluklar.Clear();
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                ct.gorevvesorumluluklar.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
            }
            calisantemsilciler.Add(ct);
            aciklamalbl.Text = ct.ad + " isimli çalışan temsilcisi eklendi.";
        }

        private void CalisanTemsilcisiForm_Load(object sender, EventArgs e)
        {
            if (Proje.calisantemsilciler.Count > 0)
            {
                yenitemsilci = new CalisanTemsilcisi();
                for (int j = 0; j < yenitemsilci.gorevvesorumluluklar.Count; j++)
                {
                    dataGridView2.Rows.Add(yenitemsilci.gorevvesorumluluklar[j]);
                }
                calisantemsilciler = Proje.calisantemsilciler;
            }
            else
            {
                
                yenitemsilci = new CalisanTemsilcisi();
                for (int j = 0; j < yenitemsilci.gorevvesorumluluklar.Count; j++)
                {
                    dataGridView2.Rows.Add(yenitemsilci.gorevvesorumluluklar[j]);
                }
            }


            for (int i = 0; i < calisantemsilciler.Count; i++)
            {
                object[] vals = new object[4];
                vals[0] = calisantemsilciler[i].ad;
                vals[1] = calisantemsilciler[i].tc;
                vals[2] = calisantemsilciler[i].gorevi;
                vals[3] = calisantemsilciler[i].iletişim;
                dataGridView1.Rows.Add(vals);
                //for (int j = 0; j < calisantemsilciler[i].gorevvesorumluluklar.Count; j++)
                //{
                //    dataGridView2.Rows.Add(calisantemsilciler[i].gorevvesorumluluklar[j]);
                //}
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.Rows.Count > 0)
            //{
            //    calisantemsilciler[dataGridView1.SelectedRows[0].Index].ad = txtAd.Text;
            //    calisantemsilciler[dataGridView1.SelectedRows[0].Index].iletişim = txtIletisim.Text;
            //    calisantemsilciler[dataGridView1.SelectedRows[0].Index].gorevi = txtGorev.Text;
            //    calisantemsilciler[dataGridView1.SelectedRows[0].Index].tc = txtTc.Text;
            //    calisantemsilciler[dataGridView1.SelectedRows[0].Index].gorevvesorumluluklar.Clear();
            //    for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            //    {
            //        calisantemsilciler[dataGridView1.SelectedRows[0].Index].gorevvesorumluluklar.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
            //    }
            //}
            Proje.calisantemsilciler = calisantemsilciler;
            aciklamalbl.Text = "Çalışan temsilcileri listesi kaydedildi";
        }
        int index = -1;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            index = dataGridView1.SelectedRows[0].Index;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtAd.Text = calisantemsilciler[dataGridView1.SelectedRows[0].Index].ad;
                txtIletisim.Text = calisantemsilciler[dataGridView1.SelectedRows[0].Index].iletişim;
                txtGorev.Text = calisantemsilciler[dataGridView1.SelectedRows[0].Index].gorevi;
                //txtTc.Text = calisantemsilciler[dataGridView1.SelectedRows[0].Index].tc;
                dataGridView2.Rows.Clear();
                for (int i = 0; i < calisantemsilciler[dataGridView1.SelectedRows[0].Index].gorevvesorumluluklar.Count; i++)
                {
                    dataGridView2.Rows.Add(calisantemsilciler[dataGridView1.SelectedRows[0].Index].gorevvesorumluluklar[i]);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedRows[0].Cells[0].Value = txtAd.Text;
            dataGridView1.SelectedRows[0].Cells[1].Value = "";
            dataGridView1.SelectedRows[0].Cells[2].Value = txtGorev.Text;
            dataGridView1.SelectedRows[0].Cells[3].Value = txtIletisim.Text;

            CalisanTemsilcisi yeni = new CalisanTemsilcisi();
            yeni.ad = txtAd.Text;
            yeni.tc = "";
            yeni.gorevi = txtGorev.Text;
            yeni.iletişim = txtIletisim.Text;
            yeni.gorevvesorumluluklar.Clear();
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                yeni.gorevvesorumluluklar.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
            }
            calisantemsilciler[index] = yeni;
            aciklamalbl.Text = yeni.ad + " isimli çalışan temsilcisinin bilgileri güncellendi.";
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aciklamalbl.Text = calisantemsilciler[dataGridView1.SelectedRows[0].Index].ad+" isimli çalışan temsilcisi silindi.";
            calisantemsilciler.RemoveAt(dataGridView1.SelectedRows[0].Index);
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }
    }
}
