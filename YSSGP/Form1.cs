using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YSSGP.Sınıflar;

namespace YSSGP
{
    public partial class Form1 : Form
    {
        // TODO: çıktı alma ekranı için 3.bölüm komple alınacak şekilde düzenleme yapılacak.
        private string dosya;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void altİşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltIsverenForm form= AltIsverenForm.FormuGoster(lblAçıklama);
            form.MdiParent = this;
            form.Show();

        }

        private void projeyeAitBilgilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjeBilgileriForm form = ProjeBilgileriForm.FormuGöster(lblAçıklama);
            form.MdiParent = this;
            form.Show();
        }

        private void işverenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsverenBilgileriForm form = IsverenBilgileriForm.FormuGoster(lblAçıklama);
            form.MdiParent = this;
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            YeniProje();

        }

        private static void YeniProje()
        {
            Proje.isveren = new IsverenBilgileri();
            Proje.yonTaahud = new YonetiminTaahudu();
            Proje.projeBilgileri = new ProjeBilgileri();
            Proje.altisverenListesi = new List<AltIsverenBilgileri>();
            Proje.kendiNaminaCalisanlarListesi = new List<KendiNaminaCalisan>();
            Proje.projeSorumlusu = new ProjeSorumlusu();
            Proje.SGKoordianator_sorumlu_hazirlik = new SGKoordinator_Hazirlik();
            Proje.SGKoordianator_sorumlu_uygulama = new SGKUygulama();
            Proje.asilisverenisguzmanlari = new List<ISGUzmani>();
            Proje.asilisverenisyerihekimleri = new List<IsyeriHekimi>();
            Proje.calisantemsilciler = new List<CalisanTemsilcisi>();
            Proje.plan = new IsPlani();

            Proje.biyolojiktehlikeler = new List<Tehlike>();
            Proje.yapisahasiningenelozgutehlikeler = new List<Tehlike>();

            Proje.cakisanisler = new List<CakisanIsler>();
            Proje.ucuncutaraflar = new List<UcuncuTarafEtki>();
            Proje.kurallar = new ŞantiyeKuralları();
            //Form1.toolStripStatusLabel1.Text = "Yeni proje oluşturuldu.";
        }

        private void kendiNamVeHesabınaÇalışanlaraAitBilgilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KendiNaminaForm form = KendiNaminaForm.FormuGoster(lblAçıklama);
            form.MdiParent = this;

            form.Show();
        }

        private void raporGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PDFReport rapor = new PDFReport();
            //rapor.Show();
            ExampleFull raporform = new ExampleFull();
            raporform.MdiParent = this;
            raporform.Show();
        }

        private void işvereninGörevVeSorumluluklarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsverenGorevveSorumluluklarForm form = IsverenGorevveSorumluluklarForm.FormuGoster(lblAçıklama);
            form.MdiParent = this;

            form.Show();
        }

        private void altİşvereninGörevVeSorumluluklarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltGorevveSorumluluklarForm form = AltGorevveSorumluluklarForm.FormuGoster(lblAçıklama);
            form.MdiParent = this;
            form.Show();
        }

        private void kendiNamVeHesabınaÇalışanlarınGörevVeSorumluluklarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KendiNaminaGorevForm form = KendiNaminaGorevForm.FormuGoster(lblAçıklama);
            form.MdiParent = this;
            form.Show();
        }

        private void projeSorumlusuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjeSorumlusuForm form = ProjeSorumlusuForm.FormuGoster(ProjeSorumlusuForm.Gorev.ProjeSorumlusu,lblAçıklama);
            form.MdiParent = this;
            form.Show();

        }

        private void sağlıkVeGüvenlikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjeSorumlusuForm form = ProjeSorumlusuForm.FormuGoster(ProjeSorumlusuForm.Gorev.SGKoordinatör_Hazırlık,lblAçıklama);
            form.MdiParent = this;
            form.Show();
        }

        private void sağlıkVeGüvenlikKoordinatörüUygulamaAşamasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjeSorumlusuForm form = ProjeSorumlusuForm.FormuGoster(ProjeSorumlusuForm.Gorev.SGKoordinatör_Uygulama,lblAçıklama);
            form.MdiParent = this;
            form.Show();
        }

        private void asılİşverenAnaYükleniciİşGüvenliğiUzmanıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsilIsverenISGPersonelForm form = AsilIsverenISGPersonelForm.FormuGoster(AsilIsverenISGPersonelForm.Gorev.İSGUzmanı,lblAçıklama);
            form.MdiParent = this;
            form.Show();

        }

       

        private void asılİşverenAnaYükleniciİşyeriHekimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsilIsverenISGPersonelForm form = AsilIsverenISGPersonelForm.FormuGoster(AsilIsverenISGPersonelForm.Gorev.İşyeriHekimi,lblAçıklama);
            form.MdiParent = this;
            form.Show();
        }

        private void çalışanTemsilcisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalisanTemsilcisiForm form = CalisanTemsilcisiForm.FormuGoster(lblAçıklama);
            form.MdiParent = this;
            form.Show();
        }

        private void işAkışPlanıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsAkisPlaniForm form = IsAkisPlaniForm.FormuGoster(lblAçıklama);
            form.MdiParent = this;
            form.Show();
        }

        private void çalışmaYöntemleriEkipmanVeEğitimliPersonelİhtiyacınınBelirlenmesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalismaYontemleriForm form =  CalismaYontemleriForm.FormuGoster(lblAçıklama);
            form.MdiParent = this;
            form.Show();
        }

        private void yapıSahasınınGenelineEtkiEdenRisklerVeKontrolTedbirlerininBelirlenmesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YapiSahasininGenelineOzguForm form = YapiSahasininGenelineOzguForm.FormuGoster(lblAçıklama);
            form.MdiParent = this;
            form.Show();
        }

        private void işleAlakalıMuhtemelRisklerVeKontrolTedbirlerininBelirlenmesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsleAlakalıRisklerForm form = IsleAlakalıRisklerForm.FormuGoster(lblAçıklama);
            form.MdiParent = this;
            form.Show();

        }

        private void zamanVeMekânAçısındanÇakışanİşlerdenKaynaklananRisklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZamanMekanForm form = ZamanMekanForm.FormuGoster(lblAçıklama);
            form.MdiParent = this;
            form.Show();
        }

        private void üçüncüTaraflaraOlanEtkisininDeğerlendirilmesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UcuncuTarafForm form = UcuncuTarafForm.FormuGoster(lblAçıklama);
            form.MdiParent = this;
            form.Show();
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SantiyeForm form = SantiyeForm.FormuGoster(lblAçıklama);
            form.MdiParent = this;
            form.Show();
        }

        private void ziyaretçilerİleİlgiliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ziyaretciForm form = ziyaretciForm.FormuGoster(lblAçıklama);
            form.MdiParent = this;
            form.Show();
        }

        private void yeniProjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dosya != null)
            {
                switch (MessageBox.Show("Değişiklikler kaydedilsin mi?", "Uyarı!!!", MessageBoxButtons.YesNoCancel))
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        Proje.DosyayaYaz(dosya);
                        YeniProje();
                        lblAçıklama.Text = "Yeni proje oluşturuldu.";
                        break;
                    case System.Windows.Forms.DialogResult.No:
                        YeniProje();
                        lblAçıklama.Text = "Yeni proje oluşturuldu.";
                        break;
                    case System.Windows.Forms.DialogResult.Cancel:

                        break;

                }

            }
            else
                YeniProje();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
            //bURAYADOSYAYI YAZDIRMA İŞLEMİ GELCEK
             
             Proje.DosyayaYaz(saveFileDialog1.FileName);
                dosya = saveFileDialog1.FileName;
                lblAçıklama.Text = "Kaydetme işlemi başarılı. " + dosya ;
                this.Text = dosya;
             }
            //if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            //{
            //    Proje.Serialize(folderBrowserDialog1.SelectedPath);
            //}
            

            
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                 if (openFileDialog1.ShowDialog()==DialogResult.OK)
                    {
                                dosya = openFileDialog1.FileName;
                                Proje.DosyadanOku(openFileDialog1.FileName);
                                this.Text = dosya;
                                lblAçıklama.Text = "Açılan dosya: " + dosya;
                    }
            }
            catch (System.IO.InvalidDataException ex)
            {
                lblAçıklama.Text = "Dosya açılırken bir hata oluştu. Hata: " + ex.Message;
                
            }
            catch(Exception ex)
            {
                lblAçıklama.Text = "Dosya açılırken bir hata oluştu. Hata: " + ex.Message;
            }
           
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dosya != null )
            {
                try
                {
                    Proje.DosyayaYaz(dosya);
                    // MessageBox.Show(dosya + " başarı ile kaydedildi.", "Kaydet", MessageBoxButtons.OK);
                    lblAçıklama.Text = dosya + " başarı ile kaydedildi.";
                }
                catch (Exception ex)
                {

                    lblAçıklama.Text = "Dosya kaydedilirken bir hata oluştu. Hata: "+ex.Message;
                    switch (ex.Message)
                    {
                        case "Proje iş planında en az bir yapılacak iş olmalıdır.":
                          IsAkisPlaniForm f=  IsAkisPlaniForm.FormuGoster(lblAçıklama);
                            f.MdiParent = this;
                            f.Show();
                            break;
                        default:
                            break;
                    }
                }
                
            }
            else
            {
                try
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //bURAYADOSYAYI YAZDIRMA İŞLEMİ GELCEK

                        Proje.DosyayaYaz(saveFileDialog1.FileName);
                        dosya = saveFileDialog1.FileName;
                        lblAçıklama.Text = dosya + " başarı ile kaydedildi.";
                    }
                }
                catch (Exception ex)
                {

                    lblAçıklama.Text = "Dosya kaydedilirken bir hata oluştu. Hata: " + ex.Message;
                    switch (ex.Message)
                    {
                        case "Proje iş planında en az bir yapılacak iş olmalıdır.":
                            IsAkisPlaniForm f = IsAkisPlaniForm.FormuGoster(lblAçıklama);
                            f.MdiParent = this;
                            f.Show();
                            break;
                        default:
                            break;
                    }
                }
                
            }
            
        }

        private void yönetimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //YazdırForm form = YazdırForm.FormuGoster(YazdırForm.YazdırmaIslemi.YönetiminTaahhüdü);
            //form.MdiParent = this;
            //form.Show();
            if (saveFileDialog2.ShowDialog()==DialogResult.OK)
            {
                Proje.yonTaahud.proje = Proje.projeBilgileri.projeAdi;
                Proje.yonTaahud.firma = Proje.isveren.unvan;
                RaporHelper.YonetiminTaahuduYazdır(Proje.yonTaahud, saveFileDialog2.FileName);
                Process.Start(saveFileDialog2.FileName);
            }
        }

        private void projeBilgileriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog()==DialogResult.OK)
            {
                RaporHelper.ProjeBilgileriYazdir(saveFileDialog2.FileName,Proje.projeBilgileri,Proje.isveren,Proje.altisverenListesi,Proje.kendiNaminaCalisanlarListesi);
                Process.Start(saveFileDialog2.FileName);
            }
        }

        

        private void yönetiminTaahütüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YonetiminTaahhuduForm form = YonetiminTaahhuduForm.FormuGoster(lblAçıklama);
            form.MdiParent = this;
            form.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkında hk = new Hakkında();
            hk.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            YardimForm f = new YardimForm();
            f.Show();
        }

        

        private void yataySığdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void düşeySığdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void pencereleriSıralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr =MessageBox.Show("Kaydetmek istermisiniz?", "Çıkış", MessageBoxButtons.YesNoCancel);
            switch (dr)
            {
                
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                
                case DialogResult.Yes:
                    kaydetToolStripMenuItem_Click(null, null);
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + @"\Raporlar\SGP-2 31 08 2015.doc";
            System.Diagnostics.Process.Start(path);
        }

        

        private void sağlıkVeGüvenlikOrganizasyonuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog()==DialogResult.OK)
            {
                RaporHelper.Bolum3Yazdir(saveFileDialog2.FileName,Proje.isveren,Proje.altisverenListesi,Proje.kendiNaminaCalisanlarListesi,Proje.projeSorumlusu,Proje.SGKoordianator_sorumlu_hazirlik,Proje.SGKoordianator_sorumlu_uygulama,Proje.asilisverenisguzmanlari,Proje.asilisverenisyerihekimleri,Proje.calisantemsilciler);
                Process.Start(saveFileDialog2.FileName);
            }
        }

        private void işOrganizasyonuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Organizasyon oform = new Organizasyon();
            //oform.Show();
            if (openFileDialog2.ShowDialog()==DialogResult.OK)
            {
                Proje.isgorganizasyonsemasi = openFileDialog2.FileName;
            }
        }

        private void işlerinYönetimiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog()==DialogResult.OK)
            {
                RaporHelper.Bolum4Yazdir(saveFileDialog2.FileName);

                Process.Start(saveFileDialog2.FileName);
            }
        }

        private void risklerinVeKontrolTedbirlerininBelirlenmesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                RaporHelper.Bolum5Yazdir(saveFileDialog2.FileName);

                Process.Start(saveFileDialog2.FileName);
            }

        }

        private void şantiyeKurallarıToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                RaporHelper.Bolum6Yazdir(saveFileDialog2.FileName);

                Process.Start(saveFileDialog2.FileName);
            }
        }
    }
}
