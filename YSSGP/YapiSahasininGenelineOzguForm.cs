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
    public partial class YapiSahasininGenelineOzguForm : Form
    {
        public YapiSahasininGenelineOzguForm()
        {
            InitializeComponent();
        }
        private static ToolStripStatusLabel aciklamalbl;
        private static YapiSahasininGenelineOzguForm formum;
        public static YapiSahasininGenelineOzguForm FormuGoster(ToolStripStatusLabel lbl)
        {
            if (formum == null)
            {
                formum = new YapiSahasininGenelineOzguForm();
            }
            aciklamalbl = lbl;
            return formum;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            object[] degerler = new object[3];
            degerler[0] = comboBox1.SelectedItem;
            degerler[1] = txtrisk1.Text;
            degerler[2] = txtonlem1.Text;
            dataGridView1.Rows.Add(degerler);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object[] degerler = new object[3];
            degerler[0] = comboBox2.SelectedItem;
            degerler[1] = txtrisk2.Text;
            degerler[2] = txtonlem2.Text;
            dataGridView2.Rows.Add(degerler);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Proje.yapisahasiningenelozgutehlikeler.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Tehlike yeniteh = new Tehlike();
                yeniteh.tehlikekayangi = dataGridView1.Rows[i].Cells[0].Value.ToString();
                yeniteh.risk = dataGridView1.Rows[i].Cells[1].Value.ToString();
                yeniteh.onlem = dataGridView1.Rows[i].Cells[2].Value.ToString();
                Proje.yapisahasiningenelozgutehlikeler.Add(yeniteh);
            }
            aciklamalbl.Text = "Yapı sahasının geneline özgü tehlikeler ve riskler kaydedildi.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Proje.biyolojiktehlikeler.Clear();
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                Tehlike yeniteh = new Tehlike();
                yeniteh.tehlikekayangi = dataGridView2.Rows[i].Cells[0].Value.ToString();
                yeniteh.risk = dataGridView2.Rows[i].Cells[1].Value.ToString();
                yeniteh.onlem = dataGridView2.Rows[i].Cells[2].Value.ToString();
                Proje.biyolojiktehlikeler.Add(yeniteh);
            }
            aciklamalbl.Text = "Biyolojik tehlikeler ve riskler kaydedildi.";
        }

        private void YapiSahasininGenelineOzguForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Proje.yapisahasiningenelozgutehlikeler.Count; i++)
            {
                object[] degerler = new object[3];
                degerler[0] = Proje.yapisahasiningenelozgutehlikeler[i].tehlikekayangi;
                degerler[1] = Proje.yapisahasiningenelozgutehlikeler[i].risk;
                degerler[2] = Proje.yapisahasiningenelozgutehlikeler[i].onlem;
                dataGridView1.Rows.Add(degerler);
            }
            for (int i = 0; i < Proje.biyolojiktehlikeler.Count; i++)
            {
                object[] degerler = new object[3];
                degerler[0] = Proje.biyolojiktehlikeler[i].tehlikekayangi;
                degerler[1] = Proje.biyolojiktehlikeler[i].risk;
                degerler[2] = Proje.biyolojiktehlikeler[i].onlem;
                dataGridView2.Rows.Add(degerler);
            }

        }
    }
}
