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
    public partial class KendiNaminaGorevForm : Form
    {
        public KendiNaminaGorevForm()
        {
            InitializeComponent();
        }
        private static ToolStripStatusLabel aciklamalbl;
        public static KendiNaminaGorevForm FormuGoster(ToolStripStatusLabel lbl)
        {
            if (formum==null)
            {
                formum = new KendiNaminaGorevForm();
            }
            aciklamalbl = lbl;
            return formum;
        }
        private static KendiNaminaGorevForm formum;
        private void KediNaminaGorevForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <Proje.kendiNaminaCalisanlarListesi.Count ; i++)
            {
                comboBox1.Items.Add(Proje.kendiNaminaCalisanlarListesi[i].adsoyad);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = comboBox1.SelectedIndex;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Proje.kendiNaminaCalisanlarListesi[selected].gorevvesorumluluklar.Count; i++)
            {
                dataGridView1.Rows.Add(Proje.kendiNaminaCalisanlarListesi[selected].gorevvesorumluluklar[i].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selected = comboBox1.SelectedIndex;
            Proje.kendiNaminaCalisanlarListesi[selected].gorevvesorumluluklar.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Proje.kendiNaminaCalisanlarListesi[selected].gorevvesorumluluklar.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }
            aciklamalbl.Text = Proje.kendiNaminaCalisanlarListesi[selected].adsoyad + " görev ve sorumlulukları güncellendi.";
        }
    }
}
