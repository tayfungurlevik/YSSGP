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
    public partial class IsAkisPlaniForm : Form
    {
        IsPlani planım;
        public IsAkisPlaniForm()
        {
            InitializeComponent();
        }
        private static IsAkisPlaniForm formum;
        private static ToolStripStatusLabel aciklamalbl;
        public static IsAkisPlaniForm FormuGoster(ToolStripStatusLabel lbl)
        {
            if (formum == null)
            {
                formum = new IsAkisPlaniForm();
            }
            aciklamalbl = lbl;
            return formum;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            object[] vals = new object[3];
            vals[0] = txtYapilacakIs.Text;
            
            vals[1] = dtBaslangic.Value.ToShortDateString();
            vals[2] = dtBitis.Value.ToShortDateString();
            dataGridView1.Rows.Add(vals);
            Is yeniis = new Is();
            yeniis.isinadi = txtYapilacakIs.Text;
            yeniis.baslangic = dtBaslangic.Value;
            yeniis.bitis = dtBitis.Value;
            planım.yapilacakisler.Add(yeniis);
            aciklamalbl.Text = yeniis.isinadi + " iş planına eklendi.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //buraya kod gelecek
            Proje.plan = planım;
            aciklamalbl.Text = "İş Akış Planı kaydedildi.";
        }

        
        private void IsAkisPlaniForm_Load(object sender, EventArgs e)
        {
            planım = Proje.plan;
            for (int i = 0; i < planım.yapilacakisler.Count; i++)
            {
                object[] vals = new object[3];
                vals[0] = planım.yapilacakisler[i].isinadi;

                vals[1] = planım.yapilacakisler[i].baslangic.ToShortDateString();
                vals[2] = planım.yapilacakisler[i].bitis.ToShortDateString();
                dataGridView1.Rows.Add(vals);
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            
            for (int i = 0; i < planım.yapilacakisler.Count; i++)
            {
                if (i==e.Row.Index)
                {
                    continue;
                }
                else
                {
                    planım.yapilacakisler[i].cakistigiIs.Remove(planım.yapilacakisler[e.Row.Index]);
                }
            }
            planım.yapilacakisler.RemoveAt(e.Row.Index);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedRows[0].Cells[0].Value = txtYapilacakIs.Text;
            dataGridView1.SelectedRows[0].Cells[1].Value = dtBaslangic.Value.ToShortDateString();
            dataGridView1.SelectedRows[0].Cells[2].Value = dtBitis.Value.ToShortDateString();
            Is yeniis = new Is();
            yeniis.isinadi = txtYapilacakIs.Text;
            yeniis.baslangic = dtBaslangic.Value;
            yeniis.bitis = dtBitis.Value;
            planım.yapilacakisler[dataGridView1.SelectedRows[0].Index] = yeniis;
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count==1)
            {
                txtYapilacakIs.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                dtBaslangic.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                dtBitis.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            }
        }
    }
}
