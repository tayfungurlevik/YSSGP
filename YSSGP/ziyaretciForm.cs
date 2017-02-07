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
using YSSGP;

namespace YSSGP
{
    public partial class ziyaretciForm : Form
    {
        public ziyaretciForm()
        {
            InitializeComponent();
        }
        private static ziyaretciForm formum;
        private static ToolStripStatusLabel aciklamalbl;
        public static ziyaretciForm FormuGoster(ToolStripStatusLabel lbl)
        {
            if (formum == null)
            {
                formum = new ziyaretciForm();
            }
            aciklamalbl = lbl;
            return formum;
        }
        private void ziyaretciForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Proje.kurallar.ziyaretciprosedur.Count; i++)
            {
                dataGridView1.Rows.Add(Proje.kurallar.ziyaretciprosedur[i]);
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Proje.kurallar.ziyaretciprosedur.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Proje.kurallar.ziyaretciprosedur.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }
            //Form1.toolStripStatusLabel1.Text = "Ziyarçi prosedürleri kaydedildi.";
            aciklamalbl.Text = "Ziyaretçi prosedürleri kaydedildi.";
        }
    }
}
