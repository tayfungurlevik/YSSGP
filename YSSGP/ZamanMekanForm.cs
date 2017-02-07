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
    public partial class ZamanMekanForm : Form
    {
        public ZamanMekanForm()
        {
            InitializeComponent();
        }
        List<Is> cakisanlar;
        bool ilkcalisma = true;
        private static ZamanMekanForm formum;
        private static ToolStripStatusLabel aciklamalbl;
        public static ZamanMekanForm FormuGoster(ToolStripStatusLabel lbl)
        {
            if (formum == null)
            {
                formum = new ZamanMekanForm();
            }
            aciklamalbl = lbl;
            return formum;
        }
        private void ZamanMekanForm_Load(object sender, EventArgs e)
        {
            cakisanlar = Proje.plan.CakisanIsler();

            for (int i = 0; i < cakisanlar.Count; i++)
            {
                comboBox1.Items.Add(cakisanlar[i].isinadi);
            }
            for (int i = 0; i < Proje.cakisanisler.Count; i++)
            {
                object[] degerler = new object[7];
                degerler[0] = Proje.cakisanisler[i].iş1.isinadi;
                degerler[1] = Proje.cakisanisler[i].iş2.isinadi;
                degerler[2] = Proje.cakisanisler[i].çakışmabaşlangıç.ToShortDateString();
                degerler[3] = Proje.cakisanisler[i].çakışmabitiş.ToShortDateString();
                degerler[4] = Proje.cakisanisler[i].risk;
                degerler[5] = Proje.cakisanisler[i].Etkilenenler;
                degerler[6] = Proje.cakisanisler[i].kontrol;
                dataGridView1.Rows.Add(degerler);
            }
            ilkcalisma = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < cakisanlar[comboBox1.SelectedIndex].cakistigiIs.Count; i++)
            {
                listBox1.Items.Add(cakisanlar[comboBox1.SelectedIndex].cakistigiIs[i].isinadi);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Is combodaseciliis = cakisanlar[comboBox1.SelectedIndex];
            Is listedesecilen = combodaseciliis.cakistigiIs[listBox1.SelectedIndex];
            DateTime cakisanbaslangıç = DateTime.Now, çakişanbitiş = DateTime.Now;
            if (combodaseciliis.baslangic <= listedesecilen.baslangic && combodaseciliis.bitis <= listedesecilen.bitis)
            {
                cakisanbaslangıç = listedesecilen.baslangic;
                çakişanbitiş = combodaseciliis.bitis;
            }
            if (listedesecilen.baslangic <= combodaseciliis.baslangic && combodaseciliis.bitis >= listedesecilen.bitis)
            {
                cakisanbaslangıç = combodaseciliis.baslangic;
                çakişanbitiş = listedesecilen.bitis;
            }
            if (combodaseciliis.baslangic >= listedesecilen.baslangic && combodaseciliis.bitis <= listedesecilen.bitis)
            {
                cakisanbaslangıç = combodaseciliis.baslangic;
                çakişanbitiş = combodaseciliis.bitis;
            }
            if (combodaseciliis.baslangic <= listedesecilen.baslangic && combodaseciliis.bitis >= listedesecilen.bitis)
            {
                cakisanbaslangıç = listedesecilen.baslangic;
                çakişanbitiş = listedesecilen.bitis;
            }
            lblBaslangic.Text = cakisanbaslangıç.ToShortDateString();
            lblBitis.Text = çakişanbitiş.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex==-1)
            {
                MessageBox.Show("Listeden çakışan işi seçmeniz gerekli.");
                return;

            }
            CakisanIsler yenicakisma = new CakisanIsler();
            yenicakisma.iş1 = cakisanlar[comboBox1.SelectedIndex];
            yenicakisma.iş2 = cakisanlar[comboBox1.SelectedIndex].cakistigiIs[listBox1.SelectedIndex];
            yenicakisma.çakışmabaşlangıç = Convert.ToDateTime(lblBaslangic.Text);
            yenicakisma.çakışmabitiş = Convert.ToDateTime(lblBitis.Text);
            yenicakisma.risk = txtRisk.Text;
            yenicakisma.kontrol = txtKontrol.Text;
            yenicakisma.Etkilenenler = txtEtkilenen.Text;
            if (!Proje.cakisanisler.Contains(yenicakisma))
            {
                Proje.cakisanisler.Add(yenicakisma);
                object[] degerler = new object[7];
                degerler[0] = yenicakisma.iş1.isinadi;
                degerler[1] = yenicakisma.iş2.isinadi;
                degerler[2] = lblBaslangic.Text;
                degerler[3] = lblBitis.Text;
                degerler[4] = yenicakisma.risk;
                degerler[5] = yenicakisma.Etkilenenler;
                degerler[6] = yenicakisma.kontrol;
                dataGridView1.Rows.Add(degerler);
                aciklamalbl.Text = yenicakisma.iş1.isinadi + " ve " + yenicakisma.iş2.isinadi + " işlerinin çakışmasından kaynaklanan tehlike ve riskler kaydedildi.";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            aciklamalbl.Text = "Çakışan işler kaydedildi.";
           // this.Close();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            aciklamalbl.Text = Proje.cakisanisler[e.Row.Index].iş1.isinadi + " ve " + Proje.cakisanisler[e.Row.Index].iş2.isinadi + " çakışmasının tehlike ve risk bilgileri silindi.";
            Proje.cakisanisler.RemoveAt(e.Row.Index);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!ilkcalisma)
            {
                CakisanIsler updatecakisan = Proje.cakisanisler[e.RowIndex];
                updatecakisan.risk = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                updatecakisan.Etkilenenler = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                updatecakisan.kontrol = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                Proje.cakisanisler[e.RowIndex] = updatecakisan;
                aciklamalbl.Text = updatecakisan.iş1.isinadi + " ve " + updatecakisan.iş2.isinadi + " çakışma bilgileri güncellendi.";
            }
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
