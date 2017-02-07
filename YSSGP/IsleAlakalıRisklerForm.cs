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
    public partial class IsleAlakalıRisklerForm : Form
    {
        public IsleAlakalıRisklerForm()
        {
            InitializeComponent();
        }

        private static IsleAlakalıRisklerForm formum;
        private static ToolStripStatusLabel aciklamalbl;
        public static IsleAlakalıRisklerForm FormuGoster(ToolStripStatusLabel lbl)
        {
            if (formum == null)
            {
                formum = new IsleAlakalıRisklerForm();
            }
            aciklamalbl = lbl;
            return formum;
        }
        private void IsleAlakalıRisklerForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Proje.plan.yapilacakisler.Count; i++)
            {
                comboBox1.Items.Add(Proje.plan.yapilacakisler[i].isinadi);
                checkedListBox1.Items.Add(Proje.plan.yapilacakisler[i].isinadi);
                checkedListBox2.Items.Add(Proje.plan.yapilacakisler[i].isinadi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[] degerler = new object[3];
            degerler[0] = comboBox2.SelectedItem;
            degerler[1] = txtRisk1.Text;
            degerler[2] = txtOnlem1.Text;
            dataGridView1.Rows.Add(degerler);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            object[] degerler = new object[3];
            degerler[0] = comboBox3.SelectedItem;
            degerler[1] = txtrisk2.Text;
            degerler[2] = txtOnlem2.Text;
            dataGridView2.Rows.Add(degerler);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proje.plan.yapilacakisler[comboBox1.SelectedIndex].fizikseltehlikeler.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Tehlike fiziksel = new Tehlike();
                fiziksel.tehlikekayangi = dataGridView1.Rows[i].Cells[0].Value.ToString();
                fiziksel.risk = dataGridView1.Rows[i].Cells[1].Value.ToString();
                fiziksel.onlem = dataGridView1.Rows[i].Cells[2].Value.ToString();
                Proje.plan.yapilacakisler[comboBox1.SelectedIndex].fizikseltehlikeler.Add(fiziksel);
            }
            aciklamalbl.Text = Proje.plan.yapilacakisler[comboBox1.SelectedIndex].isinadi + " fiziksel tehlikeleri kaydedildi.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Proje.plan.yapilacakisler[comboBox1.SelectedIndex].kimyasaltehlikeler.Clear();
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                Tehlike fiziksel = new Tehlike();
                fiziksel.tehlikekayangi = dataGridView2.Rows[i].Cells[0].Value.ToString();
                fiziksel.risk = dataGridView2.Rows[i].Cells[1].Value.ToString();
                fiziksel.onlem = dataGridView2.Rows[i].Cells[2].Value.ToString();
                Proje.plan.yapilacakisler[comboBox1.SelectedIndex].kimyasaltehlikeler.Add(fiziksel);
                aciklamalbl.Text = Proje.plan.yapilacakisler[comboBox1.SelectedIndex].isinadi + " kimyasal tehlikeleri kaydedildi.";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Proje.plan.yapilacakisler[comboBox1.SelectedIndex].fizikseltehlikeler.Count; i++)
            {
                object[] degerler = new object[3];
                degerler[0] = Proje.plan.yapilacakisler[comboBox1.SelectedIndex].fizikseltehlikeler[i].tehlikekayangi;
                degerler[1] = Proje.plan.yapilacakisler[comboBox1.SelectedIndex].fizikseltehlikeler[i].risk;
                degerler[2] = Proje.plan.yapilacakisler[comboBox1.SelectedIndex].fizikseltehlikeler[i].onlem;
                dataGridView1.Rows.Add(degerler);
            }
            dataGridView2.Rows.Clear();
            for (int i = 0; i < Proje.plan.yapilacakisler[comboBox1.SelectedIndex].kimyasaltehlikeler.Count; i++)
            {
                object[] degerler = new object[3];
                degerler[0] = Proje.plan.yapilacakisler[comboBox1.SelectedIndex].kimyasaltehlikeler[i].tehlikekayangi;
                degerler[1] = Proje.plan.yapilacakisler[comboBox1.SelectedIndex].kimyasaltehlikeler[i].risk;
                degerler[2] = Proje.plan.yapilacakisler[comboBox1.SelectedIndex].kimyasaltehlikeler[i].onlem;
                dataGridView2.Rows.Add(degerler);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedIndices.Count<=0)
            {
                MessageBox.Show("Listeden bir iş seçin.");
                return;
            }
            for (int j = 0; j < checkedListBox1.CheckedIndices.Count; j++)
            {
                Proje.plan.yapilacakisler[checkedListBox1.CheckedIndices[j]].fizikseltehlikeler.Clear();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    Tehlike fiziksel = new Tehlike();
                    fiziksel.tehlikekayangi = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    fiziksel.risk = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    fiziksel.onlem = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    Proje.plan.yapilacakisler[checkedListBox1.CheckedIndices[j]].fizikseltehlikeler.Add(fiziksel);
                }
                
            }
            aciklamalbl.Text = "Seçilen işler için fiziksel tehlikeler kaydedildi.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkedListBox2.CheckedIndices.Count <= 0)
            {
                MessageBox.Show("Listeden bir iş seçin.");
                return;
            }
            for (int j = 0; j < checkedListBox2.CheckedIndices.Count; j++)
            {
                Proje.plan.yapilacakisler[checkedListBox2.CheckedIndices[j]].kimyasaltehlikeler.Clear();
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    Tehlike kimyasal = new Tehlike();
                    kimyasal.tehlikekayangi = dataGridView2.Rows[i].Cells[0].Value.ToString();
                    kimyasal.risk = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    kimyasal.onlem = dataGridView2.Rows[i].Cells[2].Value.ToString();
                    Proje.plan.yapilacakisler[checkedListBox2.CheckedIndices[j]].kimyasaltehlikeler.Add(kimyasal);
                }

            }
            aciklamalbl.Text = "Seçilen işler için kimyasal tehlikeler kaydedildi.";
        }
    }
}
