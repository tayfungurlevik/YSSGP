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
    public partial class CalismaYontemleriForm : Form
    {
        public CalismaYontemleriForm()
        {
            InitializeComponent();
        }
        private static CalismaYontemleriForm formum;
        private static ToolStripStatusLabel aciklamalbl;
        public static CalismaYontemleriForm FormuGoster(ToolStripStatusLabel lbl)
        {
            if (formum == null)
            {
                formum = new CalismaYontemleriForm();
            }
            aciklamalbl = lbl;
            return formum;
        }
        private void CalismaYontemleriForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Proje.plan.yapilacakisler.Count; i++)
            {
                comboBox1.Items.Add(Proje.plan.yapilacakisler[i].isinadi);
                //listBox1.Items.Add(Proje.plan.yapilacakisler[i].isinadi);
                checkedListBox1.Items.Add(Proje.plan.yapilacakisler[i].isinadi);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();dataGridView2.Rows.Clear();dataGridView3.Rows.Clear();dataGridView4.Rows.Clear();dataGridView5.Rows.Clear(); dataGridView6.Rows.Clear();
            dataGridView8.Rows.Clear();
            dataGridView7.Rows.Clear();
            for (int i = 0; i < Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.yapımtekniği.Count; i++)
            {
                
                dataGridView1.Rows.Add(Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.yapımtekniği[i].ToString());
            }
            for (int i = 0; i < Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.işekipmanikullanimi.Count; i++)
            {
                
                dataGridView2.Rows.Add(Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.işekipmanikullanimi[i].ToString());
            }
            for (int i = 0; i < Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.kimyasalmaddekullanimi.Count; i++)
            {
                
                dataGridView3.Rows.Add(Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.kimyasalmaddekullanimi[i].ToString());
            }
            for (int i = 0; i < Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.calismaalaninaerisim.Count; i++)
            {
                
                dataGridView4.Rows.Add(Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.calismaalaninaerisim[i].ToString());
            }
            for (int i = 0; i < Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.malzemelerintasinmasi.Count; i++)
            {
                

                dataGridView5.Rows.Add(Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.malzemelerintasinmasi[i].ToString());
            }
            for (int i = 0; i < Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.isekipmani.Count; i++)
            {
                

                dataGridView6.Rows.Add(Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.isekipmani[i].ToString());
            }
            for (int i = 0; i < Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.kullanilacakkimyasallar.Count; i++)
            {
                
                dataGridView7.Rows.Add(Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.kullanilacakkimyasallar[i].ToString());
            }
            for (int i = 0; i < Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.egitimlipersonelihtiyaci.Count; i++)
            {
                
                dataGridView8.Rows.Add(Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.egitimlipersonelihtiyaci[i].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (ListViewItem item in listBox1.SelectedItems)
            //{
            //    MessageBox.Show(item.Index.ToString());
            //}
            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    MessageBox.Show(((ListViewItem)(listBox1.Items[i])).Text);
            //}
            //for (int i = 0; i < checkedListBox1.Items.Count; i++)
            //{
            //    MessageBox.Show(checkedListBox1.CheckedItems[0].)
            //}
            Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.yapımtekniği.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.yapımtekniği.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }
            Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.işekipmanikullanimi.Clear();
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.işekipmanikullanimi.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
            }
            Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.kimyasalmaddekullanimi.Clear();
            for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
            {
                Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.kimyasalmaddekullanimi.Add(dataGridView3.Rows[i].Cells[0].Value.ToString());
            }
            Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.calismaalaninaerisim.Clear();
            for (int i = 0; i < dataGridView4.Rows.Count - 1; i++)
            {
                Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.calismaalaninaerisim.Add(dataGridView4.Rows[i].Cells[0].Value.ToString());
            }
            Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.malzemelerintasinmasi.Clear();
            for (int i = 0; i < dataGridView5.Rows.Count - 1; i++)
            {
                Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.malzemelerintasinmasi.Add(dataGridView5.Rows[i].Cells[0].Value.ToString());
            }
            Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.isekipmani.Clear();
            for (int i = 0; i < dataGridView6.Rows.Count - 1; i++)
            {
                Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.isekipmani.Add(dataGridView6.Rows[i].Cells[0].Value.ToString());
            }
            Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.kullanilacakkimyasallar.Clear();
            for (int i = 0; i < dataGridView7.Rows.Count - 1; i++)
            {
                Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.kullanilacakkimyasallar.Add(dataGridView7.Rows[i].Cells[0].Value.ToString());
            }
            Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.egitimlipersonelihtiyaci.Clear();
            for (int i = 0; i < dataGridView8.Rows.Count - 1; i++)
            {
                Proje.plan.yapilacakisler[comboBox1.SelectedIndex].yontem.egitimlipersonelihtiyaci.Add(dataGridView8.Rows[i].Cells[0].Value.ToString());
            }
            aciklamalbl.Text = "Çalışma yöntemleri, ekipman ve eğtimli personel ihtiyacının belirlenmesi"+ Proje.plan.yapilacakisler[comboBox1.SelectedIndex].isinadi+ " işi için kaydedildi";
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count<=0)
            {
                MessageBox.Show("Listeden bir iş seçin.");
                return;
            }
            for (int j = 0; j < checkedListBox1.CheckedIndices.Count; j++)
            {
                //MessageBox.Show( Proje.plan.yapilacakisler[checkedListBox1.CheckedIndices[i]].isinadi);
                Proje.plan.yapilacakisler[checkedListBox1.CheckedIndices[j]].yontem.yapımtekniği.Clear();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    Proje.plan.yapilacakisler[checkedListBox1.CheckedIndices[j]].yontem.yapımtekniği.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                }
                Proje.plan.yapilacakisler[checkedListBox1.CheckedIndices[j]].yontem.işekipmanikullanimi.Clear();
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    Proje.plan.yapilacakisler[checkedListBox1.CheckedIndices[j]].yontem.işekipmanikullanimi.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
                }
                Proje.plan.yapilacakisler[checkedListBox1.CheckedIndices[j]].yontem.kimyasalmaddekullanimi.Clear();
                for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                {
                    Proje.plan.yapilacakisler[checkedListBox1.CheckedIndices[j]].yontem.kimyasalmaddekullanimi.Add(dataGridView3.Rows[i].Cells[0].Value.ToString());
                }
                Proje.plan.yapilacakisler[checkedListBox1.CheckedIndices[j]].yontem.calismaalaninaerisim.Clear();
                for (int i = 0; i < dataGridView4.Rows.Count - 1; i++)
                {
                    Proje.plan.yapilacakisler[checkedListBox1.CheckedIndices[j]].yontem.calismaalaninaerisim.Add(dataGridView4.Rows[i].Cells[0].Value.ToString());
                }
                Proje.plan.yapilacakisler[checkedListBox1.CheckedIndices[j]].yontem.malzemelerintasinmasi.Clear();
                for (int i = 0; i < dataGridView5.Rows.Count - 1; i++)
                {
                    Proje.plan.yapilacakisler[checkedListBox1.CheckedIndices[j]].yontem.malzemelerintasinmasi.Add(dataGridView5.Rows[i].Cells[0].Value.ToString());
                }
                Proje.plan.yapilacakisler[checkedListBox1.CheckedIndices[j]].yontem.isekipmani.Clear();
                for (int i = 0; i < dataGridView6.Rows.Count - 1; i++)
                {
                    Proje.plan.yapilacakisler[checkedListBox1.CheckedIndices[j]].yontem.isekipmani.Add(dataGridView6.Rows[i].Cells[0].Value.ToString());
                }
                Proje.plan.yapilacakisler[checkedListBox1.CheckedIndices[j]].yontem.kullanilacakkimyasallar.Clear();
                for (int i = 0; i < dataGridView7.Rows.Count - 1; i++)
                {
                    Proje.plan.yapilacakisler[checkedListBox1.CheckedIndices[j]].yontem.kullanilacakkimyasallar.Add(dataGridView7.Rows[i].Cells[0].Value.ToString());
                }
                Proje.plan.yapilacakisler[checkedListBox1.CheckedIndices[j]].yontem.egitimlipersonelihtiyaci.Clear();
                for (int i = 0; i < dataGridView8.Rows.Count - 1; i++)
                {
                    Proje.plan.yapilacakisler[ checkedListBox1.CheckedIndices[j]].yontem.egitimlipersonelihtiyaci.Add(dataGridView8.Rows[i].Cells[0].Value.ToString());
                }
            }
            aciklamalbl.Text = "Çalışma yöntemleri, ekipman ve eğtimli personel ihtiyacının belirlenmesi seçili işler için kaydedildi";
        }
    }
}
