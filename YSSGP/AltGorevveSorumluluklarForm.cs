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
    public partial class AltGorevveSorumluluklarForm : Form
    {
        public AltGorevveSorumluluklarForm()
        {
            InitializeComponent();
        }
        private static AltGorevveSorumluluklarForm formum;
        private static ToolStripStatusLabel aciklamalbl;
        private void AltGorevveSorumluluklarForm_Load(object sender, EventArgs e)
        {
            
                for (int i = 0; i < Proje.altisverenListesi.Count; i++)
                {
                    comboBox1.Items.Add(Proje.altisverenListesi[i].altisveren);
                }
            

            
        }
        public static AltGorevveSorumluluklarForm FormuGoster(ToolStripStatusLabel lbl)
        {
            if (formum==null)
            {
                formum = new AltGorevveSorumluluklarForm();
                
            }
            aciklamalbl = lbl;
            return formum;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = comboBox1.SelectedIndex;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Proje.altisverenListesi[selected].gorevvesorumluluklar.Count; i++)
            {
                dataGridView1.Rows.Add(Proje.altisverenListesi[selected].gorevvesorumluluklar[i].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selected = comboBox1.SelectedIndex;
            Proje.altisverenListesi[selected].gorevvesorumluluklar.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                Proje.altisverenListesi[selected].gorevvesorumluluklar.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }
            //Form1.toolStripStatusLabel1.Text = "Alt işveren görev ve sorumlukları başarıyla kaydedildi.";
            aciklamalbl.Text= "Alt işveren görev ve sorumlukları başarıyla kaydedildi.";


        }
    }
}
