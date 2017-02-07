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
    public partial class UcuncuTarafForm : Form
    {
        public UcuncuTarafForm()
        {
            InitializeComponent();
        }
        private static ToolStripStatusLabel aciklamalbl;
        private static UcuncuTarafForm formum;
        public static UcuncuTarafForm FormuGoster(ToolStripStatusLabel lbl)
        {
            if (formum == null)
            {
                formum = new UcuncuTarafForm();
            }
            aciklamalbl = lbl;
            return formum;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            object[] degerler = new object[3];
            degerler[0] = comboBox1.SelectedItem;
            degerler[1] = txtEtki.Text;
            degerler[2] = txtKontrol.Text;
            dataGridView1.Rows.Add(degerler);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proje.ucuncutaraflar.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                UcuncuTarafEtki yenietki = new UcuncuTarafEtki();
                yenietki.risk = dataGridView1.Rows[i].Cells[0].Value.ToString();
                yenietki.etki = dataGridView1.Rows[i].Cells[1].Value.ToString();
                yenietki.kontrol = dataGridView1.Rows[i].Cells[2].Value.ToString();
                Proje.ucuncutaraflar.Add(yenietki);
            }
            
            aciklamalbl.Text = "Üçüncü taraflara etkiler kaydedildi.";
        }

        private void UcuncuTarafForm_Load(object sender, EventArgs e)
        {
            if (Proje.ucuncutaraflar.Count>0)
            {
                for (int i = 0; i < Proje.ucuncutaraflar.Count; i++)
                {
                    object[] vals = new object[3];
                    vals[0] = Proje.ucuncutaraflar[i].risk;
                    vals[1] = Proje.ucuncutaraflar[i].etki;
                    vals[2] = Proje.ucuncutaraflar[i].kontrol;
                    dataGridView1.Rows.Add(vals);
                }
            }
        }
    }
}
