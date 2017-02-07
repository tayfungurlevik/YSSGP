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
    public partial class IsverenGorevveSorumluluklarForm : Form
    {
        private static IsverenGorevveSorumluluklarForm formum;
        private static ToolStripStatusLabel aciklamalbl;
        public IsverenGorevveSorumluluklarForm()
        {
            InitializeComponent();

        }
        public static IsverenGorevveSorumluluklarForm FormuGoster(ToolStripStatusLabel lbl)
        {
            if (formum==null)
            {
                formum = new IsverenGorevveSorumluluklarForm();
                
            }
            aciklamalbl = lbl;
            return formum;

        }

        private void IsverenGorevveSorumluluklarForm_Load(object sender, EventArgs e)
        {
            label2.Text = Proje.isveren.isveren;
            
                
            
            
            for (int i = 0; i < Proje.isveren.gorevveSorumluluklar.Count; i++)
            {
                dataGridView1.Rows.Add(Proje.isveren.gorevveSorumluluklar[i]);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proje.isveren.gorevveSorumluluklar.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
               
                
                    Proje.isveren.gorevveSorumluluklar.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
               
            }
            aciklamalbl.Text = Proje.isveren.isveren + " görev ve sorumlulukları kaydedildi.";
           
        }
    }
}
