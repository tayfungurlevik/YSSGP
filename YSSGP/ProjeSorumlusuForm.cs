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
    public partial class ProjeSorumlusuForm : Form
    {

        public enum Gorev { ProjeSorumlusu,SGKoordinatör_Hazırlık, SGKoordinatör_Uygulama  }
        private static ProjeSorumlusuForm formum;
        private static Gorev _gorev;
        private static ToolStripStatusLabel aciklamalbl;
        public ProjeSorumlusuForm()
        {
            InitializeComponent();
        }
        public static ProjeSorumlusuForm FormuGoster(Gorev gorevi, ToolStripStatusLabel lbl)
        {
            if (formum==null)
            {
                formum = new ProjeSorumlusuForm();
            }
            _gorev = gorevi;
            aciklamalbl = lbl;
            formum.dataGridView1.Rows.Clear();
            switch (_gorev)
            {
                case Gorev.ProjeSorumlusu:
                    formum.Text = "Proje Sorumlusu";
                    formum.groupBox1.Text = "Proje Sorumlusu";
                    formum.txtAd.Text = Proje.projeSorumlusu.adsoyad;
                   
                    formum.txtMeslek.Text = Proje.projeSorumlusu.Meslek;
                    formum.txtIletisim.Text = Proje.projeSorumlusu.iletisim;
                    for (int i = 0; i < Proje.projeSorumlusu.gorevvesorumluluklar.Count; i++)
                    {
                        formum.dataGridView1.Rows.Add(Proje.projeSorumlusu.gorevvesorumluluklar[i]);
                    }
                    break;
                case Gorev.SGKoordinatör_Hazırlık:
                    formum.Text = "Sağlık ve Güvenlik Koordinatörü (Hazırlık Aşaması)";
                    formum.groupBox1.Text = "Sağlık ve Güvenlik Koordinatörü (Hazırlık Aşaması)";
                    formum.txtAd.Text = Proje.SGKoordianator_sorumlu_hazirlik.adsoyad;
                    
                    formum.txtMeslek.Text = Proje.SGKoordianator_sorumlu_hazirlik.Meslek;
                    formum.txtIletisim.Text = Proje.SGKoordianator_sorumlu_hazirlik.iletisim;
                    for (int i = 0; i < Proje.SGKoordianator_sorumlu_hazirlik.gorevvesorumluluklar.Count; i++)
                    {
                        formum.dataGridView1.Rows.Add(Proje.SGKoordianator_sorumlu_hazirlik.gorevvesorumluluklar[i]);
                    }
                    break;
                case Gorev.SGKoordinatör_Uygulama:
                    formum.Text = "Sağlık ve Güvenlik Koordinatörü (Uygulama Aşaması)";
                    formum.groupBox1.Text = "Sağlık ve Güvenlik Koordinatörü (Uygulama Aşaması)";
                    formum.txtAd.Text = Proje.SGKoordianator_sorumlu_uygulama.adsoyad;
                    
                    formum.txtMeslek.Text = Proje.SGKoordianator_sorumlu_uygulama.Meslek;
                    formum.txtIletisim.Text = Proje.SGKoordianator_sorumlu_uygulama.iletisim;
                    for (int i = 0; i < Proje.SGKoordianator_sorumlu_uygulama.gorevvesorumluluklar.Count; i++)
                    {
                        formum.dataGridView1.Rows.Add(Proje.SGKoordianator_sorumlu_uygulama.gorevvesorumluluklar[i]);
                    }
                    break;

                default:
                    break;
            }
            return formum;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (_gorev)
            {
                case Gorev.ProjeSorumlusu:
                    Proje.projeSorumlusu.adsoyad = txtAd.Text;
                    Proje.projeSorumlusu.iletisim = txtIletisim.Text;
                    Proje.projeSorumlusu.Meslek = txtMeslek.Text;
                    Proje.projeSorumlusu.TCKimlikNo = "";
                    Proje.projeSorumlusu.gorevvesorumluluklar.Clear();
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        Proje.projeSorumlusu.gorevvesorumluluklar.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    }
                    aciklamalbl.Text = "Proje sorumlusu bilgileri kaydedildi";
                    break;
                case Gorev.SGKoordinatör_Hazırlık:
                    Proje.SGKoordianator_sorumlu_hazirlik.adsoyad = txtAd.Text;
                    Proje.SGKoordianator_sorumlu_hazirlik.iletisim = txtIletisim.Text;
                    Proje.SGKoordianator_sorumlu_hazirlik.Meslek = txtMeslek.Text;
                    Proje.SGKoordianator_sorumlu_hazirlik.TCKimlikNo = "";
                    Proje.SGKoordianator_sorumlu_hazirlik.gorevvesorumluluklar.Clear();
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        Proje.SGKoordianator_sorumlu_hazirlik.gorevvesorumluluklar.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    }
                    aciklamalbl.Text = "PHazırlık aşaması koordinatör bilgileri kaydedildi";
                    break;
                case Gorev.SGKoordinatör_Uygulama:
                    Proje.SGKoordianator_sorumlu_uygulama.adsoyad = txtAd.Text;
                    Proje.SGKoordianator_sorumlu_uygulama.iletisim = txtIletisim.Text;
                    Proje.SGKoordianator_sorumlu_uygulama.Meslek = txtMeslek.Text;
                    Proje.SGKoordianator_sorumlu_uygulama.TCKimlikNo = "";
                    Proje.SGKoordianator_sorumlu_uygulama.gorevvesorumluluklar.Clear();
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        Proje.SGKoordianator_sorumlu_uygulama.gorevvesorumluluklar.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    }
                    aciklamalbl.Text = "Uygulama aşaması koordinatör bilgileri kaydedildi";
                    break;
                
                default:
                    break;
            }
            
        }

        private void ProjeSorumlusuForm_Load(object sender, EventArgs e)
        {
            //switch (_gorev)
            //{
            //    case Gorev.ProjeSorumlusu:
            //        groupBox1.Text = "Proje Sorumlusu";
            //        txtAd.Text = Proje.projeSorumlusu.adsoyad;
            //        txtTc.Text = Proje.projeSorumlusu.TCKimlikNo;
            //        txtMeslek.Text = Proje.projeSorumlusu.Meslek;
            //        txtIletisim.Text = Proje.projeSorumlusu.iletisim;
            //        for (int i = 0; i < Proje.projeSorumlusu.gorevvesorumluluklar.Count; i++)
            //        {
            //            dataGridView1.Rows.Add(Proje.projeSorumlusu.gorevvesorumluluklar[i]);
            //        }
            //        break;
            //    case Gorev.SGKoordinatör_Hazırlık:
            //        groupBox1.Text = "Sağlık ve Güvenlik Koordinatörü (Hazırlık Aşaması)";
            //        txtAd.Text = Proje.SGKoordianator_sorumlu_hazirlik.adsoyad;
            //        txtTc.Text = Proje.SGKoordianator_sorumlu_hazirlik.TCKimlikNo;
            //        txtMeslek.Text = Proje.SGKoordianator_sorumlu_hazirlik.Meslek;
            //        txtIletisim.Text = Proje.SGKoordianator_sorumlu_hazirlik.iletisim;
            //        for (int i = 0; i < Proje.SGKoordianator_sorumlu_hazirlik.gorevvesorumluluklar.Count; i++)
            //        {
            //            dataGridView1.Rows.Add(Proje.SGKoordianator_sorumlu_hazirlik.gorevvesorumluluklar[i]);
            //        }
            //        break;
            //    case Gorev.SGKoordinatör_Uygulama:
            //        groupBox1.Text = "Sağlık ve Güvenlik Koordinatörü (Uygulama Aşaması)";
            //        txtAd.Text = Proje.SGKoordianator_sorumlu_uygulama.adsoyad;
            //        txtTc.Text = Proje.SGKoordianator_sorumlu_uygulama.TCKimlikNo;
            //        txtMeslek.Text = Proje.SGKoordianator_sorumlu_uygulama.Meslek;
            //        txtIletisim.Text = Proje.SGKoordianator_sorumlu_uygulama.iletisim;
            //        for (int i = 0; i < Proje.SGKoordianator_sorumlu_uygulama.gorevvesorumluluklar.Count; i++)
            //        {
            //            dataGridView1.Rows.Add(Proje.SGKoordianator_sorumlu_uygulama.gorevvesorumluluklar[i]);
            //        }
            //        break;
                
            //    default:
            //        break;
            //}
            
        }
    }
}
