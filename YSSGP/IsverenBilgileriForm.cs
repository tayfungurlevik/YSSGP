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
    public partial class IsverenBilgileriForm : Form
    {
        private static IsverenBilgileriForm form;
        private static ToolStripStatusLabel aciklamalbl;
        public IsverenBilgileriForm()
        {
            InitializeComponent();
        }
        public static IsverenBilgileriForm FormuGoster(ToolStripStatusLabel lbl)
        {
            if (form == null)
            {
                form = new IsverenBilgileriForm();
            }
            aciklamalbl = lbl;
            return form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proje.isveren.isveren = txtIsveren.Text;
            Proje.isveren.adres = txtAdres.Text;
            Proje.isveren.sgksicilno = txtSGK.Text;
            Proje.isveren.sorumlufirmalar = txtSorumluYDFirması.Text;
            Proje.isveren.telfaks = txtTelFaks.Text;
            Proje.isveren.unvan = txtUnvan.Text;
            Proje.isveren.web = txtWeb.Text;
            aciklamalbl.Text = "İşveren bilgileri kaydedildi.";

        }

        private void IsverenBilgileriForm_Load(object sender, EventArgs e)
        {
            txtIsveren.Text = Proje.isveren.isveren;
            txtAdres.Text = Proje.isveren.adres;
            txtSGK.Text = Proje.isveren.sgksicilno;
            txtSorumluYDFirması.Text = Proje.isveren.sorumlufirmalar;
            txtTelFaks.Text = Proje.isveren.telfaks;
            txtUnvan.Text = Proje.isveren.unvan;
            txtWeb.Text = Proje.isveren.web;
        }
    }
}
