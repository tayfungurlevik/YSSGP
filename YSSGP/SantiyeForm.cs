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
    public partial class SantiyeForm : Form
    {
        public SantiyeForm()
        {
            InitializeComponent();
        }
        private static SantiyeForm formum;
        private static ToolStripStatusLabel aciklamalbl;
        public static SantiyeForm FormuGoster(ToolStripStatusLabel lbl)
        {
            if (formum == null)
            {
                formum = new SantiyeForm();
            }
            aciklamalbl = lbl;
            return formum;
        }
        private void SantiyeForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Proje.kurallar.kurallar.Count; i++)
            {
                dataGridView1.Rows.Add(Proje.kurallar.kurallar[i]);
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            Proje.kurallar.kurallar.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Proje.kurallar.kurallar.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }
            aciklamalbl.Text = "Şantiye kuralları kaydedildi.";
        }
    }
}
