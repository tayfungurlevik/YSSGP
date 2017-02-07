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
    public partial class ProjeBilgileriForm : Form
    {
        private static ProjeBilgileriForm form;
        private static ToolStripStatusLabel aciklamalbl;
        public ProjeBilgileriForm()
        {
            InitializeComponent();
        }
        public static ProjeBilgileriForm FormuGöster(ToolStripStatusLabel lbl)
        {
            if (form == null)
            {
                form = new ProjeBilgileriForm();
            }
            aciklamalbl = lbl;
            return form;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Proje.projeBilgileri.adres = txtAdres.Text;
            Proje.projeBilgileri.baslangicTarih = dtProjeBaslangic.Value;
            Proje.projeBilgileri.bitisTarih = dtProjeBitis.Value;
            Proje.projeBilgileri.isinSahibi = txtIsinSahibi.Text;
            Proje.projeBilgileri.projeAdi = txtProjeAdi.Text;
            Proje.projeBilgileri.tanim = txtProjeTanim.Text;
            aciklamalbl.Text = Proje.projeBilgileri.projeAdi + " proje bilgileri kaydedildi.";
            
        }

        private void ProjeBilgileriForm_Load(object sender, EventArgs e)
        {
            txtAdres.Text = Proje.projeBilgileri.adres;
            txtIsinSahibi.Text = Proje.projeBilgileri.isinSahibi;
            txtProjeAdi.Text = Proje.projeBilgileri.projeAdi;
            txtProjeTanim.Text = Proje.projeBilgileri.tanim;
            dtProjeBaslangic.Value = Proje.projeBilgileri.baslangicTarih;
            dtProjeBitis.Value = Proje.projeBilgileri.bitisTarih;

        }
    }
}
