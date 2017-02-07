using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YSSGP.Sınıflar;

namespace YSSGP
{
    public partial class YonetiminTaahhuduForm : Form
    {
        public YonetiminTaahhuduForm()
        {
            InitializeComponent();
        }
        private static YonetiminTaahhuduForm formum;
        private static ToolStripStatusLabel aciklamalbl;
        public static YonetiminTaahhuduForm FormuGoster(ToolStripStatusLabel lbl)
        {
            if (formum==null)
            {
                formum = new YonetiminTaahhuduForm();
            }
            aciklamalbl = lbl;
            return formum;
        }
        private void YonetiminTaahhudu_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Proje.yonTaahud.taahudler.Count; i++)
            {
                dataGridView1.Rows.Add(Proje.yonTaahud.taahudler[i]);
            }
            txtAdSoyad.Text = Proje.yonTaahud.adSoyad;
           

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Proje.yonTaahud.taahudler.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Proje.yonTaahud.taahudler.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }
            Proje.yonTaahud.adSoyad = txtAdSoyad.Text;
            
            aciklamalbl.Text = "Yönetimin Taahhüdü kaydedildi.";
        }

        
    }
}
