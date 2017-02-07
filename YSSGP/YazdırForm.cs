using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using YSSGP.Sınıflar;
using iText.Kernel.Pdf;

namespace YSSGP
{
    public partial class YazdırForm : Form
    {
        public enum YazdırmaIslemi { YönetiminTaahhüdü, İşverenBilgileri, ProjeBilgileri, altisverenler, kendinamına, isv_gorev, alt_gorev, kendinamına_gorev, ProjeSorumlusu, saglık_hazirlik, saglık_uygulama, isguzmanlar, hekimler, CalisanTemsilcileri, İşakışPlanı, ÇalışmaYöntemleri, YapıSahasıRisk, İşleAlakalı, çakışanişler, UcuncuTaraf, ŞantiyeKuralları, Prosedür ,TümRapor}
        private static YazdırForm form;
        private static YazdırmaIslemi Islem;
        public YazdırForm()
        {
            InitializeComponent();

        }
        public static YazdırForm FormuGoster(YazdırmaIslemi islem)
        {

            if (form == null)
            {
                form = new YazdırForm();
            }

            Islem = islem;
            //form.YazdırForm_Load(null, EventArgs.Empty);
            
            return form;
        }
        
        private void YazdırForm_Load(object sender, EventArgs e)
        {
           
            HTMLYazdir(Islem);
        }

        
        //bu kisimlar sonra silinecek

        //private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        //{

        //    switch (Islem)
        //    {
        //        case YazdırmaIslemi.Prosedür:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Ziyaretçilerle ilgili prosedürler</h3>";
        //            for (int i = 0; i < Proje.kurallar.ziyaretciprosedur.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += (i + 1) + ". " + Proje.kurallar.ziyaretciprosedur[i] + "<br/>";
        //            }
                    
        //            break;
        //        case YazdırmaIslemi.ŞantiyeKuralları:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Şantiye Kuralları</h3>";
        //            for (int i = 0; i < Proje.kurallar.kurallar.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += (i + 1) + ". " + Proje.kurallar.kurallar[i] + "<br/>";
        //            }
        //            break;
        //        case YazdırmaIslemi.UcuncuTaraf:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Üçüncü Taraflara Etki</h3>";
        //            for (int i = 0; i < Proje.ucuncutaraflar.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Risk</h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.ucuncutaraflar[i].risk;
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Etki altındaki bölge/tesis</h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.ucuncutaraflar[i].etki;
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Kontrol Tedbirleri</h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.ucuncutaraflar[i].kontrol;
        //            }

        //            break;
        //        case YazdırmaIslemi.çakışanişler:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h2>Zaman ve Mekân Açısından Çakışan İşlerden Kaynaklanan Riskler </h2>";
        //            for (int i = 0; i < Proje.cakisanisler.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Çakışan İşler: ";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.cakisanisler[i].iş1.isinadi + " - " + Proje.cakisanisler[i].iş2.isinadi + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Çakışma Başlangıç Tarihi: " + Proje.cakisanisler[i].çakışmabaşlangıç.ToShortDateString() + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Çakışma Bitiş Tarihi: " + Proje.cakisanisler[i].çakışmabitiş.ToShortDateString() + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Risk: " + Proje.cakisanisler[i].risk + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Etkilenen çalışanlar/Etki altındaki bölge: " + Proje.cakisanisler[i].Etkilenenler + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Kontrol Önlemleri: " + Proje.cakisanisler[i].kontrol + "<br/><br/><br/>";
        //            }
        //            break;
        //        case YazdırmaIslemi.İşleAlakalı:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h2>İşle Alakalı Muhtemel Riskler ve Kontrol Tedbirleri</h2>";
        //            for (int i = 0; i < Proje.plan.yapilacakisler.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Yapılacak İş:" + Proje.plan.yapilacakisler[i].isinadi + "</h3>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Fiziksel Tehlikeler</h4>";
        //                for (int j = 0; j < Proje.plan.yapilacakisler[i].fizikseltehlikeler.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "<h5>Tehlike Kaynağı</h5>";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.plan.yapilacakisler[i].fizikseltehlikeler[j].tehlikekayangi + "<br/>";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "<h5>Riskler</h5>";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.plan.yapilacakisler[i].fizikseltehlikeler[j].risk + "<br/>";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "<h5>Kontrol Önlemi</h5>";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.plan.yapilacakisler[i].fizikseltehlikeler[j].onlem + "<br/>";
        //                }
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Kimyasal Tehlikeler</h4>";
        //                for (int j = 0; j < Proje.plan.yapilacakisler[i].fizikseltehlikeler.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "<h5>Tehlike Kaynağı</h5>";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.plan.yapilacakisler[i].kimyasaltehlikeler[j].tehlikekayangi + "<br/>";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "<h5>Riskler</h5>";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.plan.yapilacakisler[i].kimyasaltehlikeler[j].risk + "<br/>";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "<h5>Kontrol Önlemi</h5>";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.plan.yapilacakisler[i].kimyasaltehlikeler[j].onlem + "<br/>";
        //                }
        //            }
        //            break;
        //        case YazdırmaIslemi.YapıSahasıRisk:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h2>Yapı Sahasının Geneline Etki Eden Riskler ve Kontrol Tedbirleri</h2>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Yapı Sahasının Geneline Özgü</h3>";
        //            for (int i = 0; i < Proje.yapisahasiningenelozgutehlikeler.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Tehlike Kaynağı: </h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.yapisahasiningenelozgutehlikeler[i].tehlikekayangi + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Risk: </h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.yapisahasiningenelozgutehlikeler[i].risk + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Kontrol Önlemi: </h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.yapisahasiningenelozgutehlikeler[i].onlem + "<br/>";
        //            }
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Biyolojik</h3>";
        //            for (int i = 0; i < Proje.biyolojiktehlikeler.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Tehlike Kaynağı: </h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.biyolojiktehlikeler[i].tehlikekayangi + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Risk: </h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.biyolojiktehlikeler[i].risk + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Kontrol Önlemi: </h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.biyolojiktehlikeler[i].onlem + "<br/>";
        //            }
        //            break;
        //        case YazdırmaIslemi.ÇalışmaYöntemleri:
        //            for (int i = 0; i < Proje.plan.yapilacakisler.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h2>Yapılacak İş:" + Proje.plan.yapilacakisler[i].isinadi + "</h2>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Çalışma Yöntemi</h3>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Teknik Açıklama ve Gereklilikler</h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h5>Yapım Tekniği ve Teknolojisi  </h5>";
        //                for (int j = 0; j < Proje.plan.yapilacakisler[i].yontem.yapımtekniği.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.plan.yapilacakisler[i].yontem.yapımtekniği[j] + "<br/>";
        //                }
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h5>İş Ekipmanı Kullanımı</h5>";
        //                for (int j = 0; j < Proje.plan.yapilacakisler[i].yontem.işekipmanikullanimi.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.plan.yapilacakisler[i].yontem.işekipmanikullanimi[j] + "<br/>";
        //                }
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h5>Kimyasal Madde Kullanımı</h5>";
        //                for (int j = 0; j < Proje.plan.yapilacakisler[i].yontem.kimyasalmaddekullanimi.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.plan.yapilacakisler[i].yontem.kimyasalmaddekullanimi[j] + "<br/>";
        //                }
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Çalışma Alanına Erişim</h4>";
        //                for (int j = 0; j < Proje.plan.yapilacakisler[i].yontem.calismaalaninaerisim.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.plan.yapilacakisler[i].yontem.calismaalaninaerisim[j] + "<br/>";
        //                }
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Malzemelerin Taşınması</h4>";
        //                for (int j = 0; j < Proje.plan.yapilacakisler[i].yontem.malzemelerintasinmasi.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.plan.yapilacakisler[i].yontem.malzemelerintasinmasi[j] + "<br/>";
        //                }
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>İş Ekipmanı:</h4>";
        //                for (int j = 0; j < Proje.plan.yapilacakisler[i].yontem.isekipmani.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += (j + 1) + ". " + Proje.plan.yapilacakisler[i].yontem.isekipmani[j] + "<br/>";
        //                }
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Kullanılacak Kimyasallar:</h4>";
        //                for (int j = 0; j < Proje.plan.yapilacakisler[i].yontem.kullanilacakkimyasallar.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += (j + 1) + ". " + Proje.plan.yapilacakisler[i].yontem.kullanilacakkimyasallar[j] + "<br/>";
        //                }
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Eğitimli Personel İhtiyacı:</h4>";
        //                for (int j = 0; j < Proje.plan.yapilacakisler[i].yontem.egitimlipersonelihtiyaci.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += (j + 1) + ". " + Proje.plan.yapilacakisler[i].yontem.egitimlipersonelihtiyaci[j] + "<br/>";
        //                }
        //            }

        //            break;
        //        case YazdırmaIslemi.İşakışPlanı:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>İş Akış Planı</h3>";
        //            for (int i = 0; i < Proje.plan.yapilacakisler.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>" + (i + 1) + ". Yapılacak İş: " + Proje.plan.yapilacakisler[i].isinadi + "</h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Başlangıç Tarihi: " + Proje.plan.yapilacakisler[i].baslangic.ToShortDateString() + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Bitiş Tarihi: " + Proje.plan.yapilacakisler[i].bitis.ToShortDateString() + "<br/>";

        //            }
        //            break;
        //        case YazdırmaIslemi.CalisanTemsilcileri:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Çalışan Temsilcileri - Görev ve Sorumlulukları</h3>";
        //            for (int i = 0; i < Proje.calisantemsilciler.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>" + (i + 1) + ". Çalışan Temsilcisi:</h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Ad Soyad: " + Proje.calisantemsilciler[i].ad + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "TC Kimlik No: " + Proje.calisantemsilciler[i].tc + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Görevi: " + Proje.calisantemsilciler[i].gorevi + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "İletişim Bilgileri: " + Proje.calisantemsilciler[i].iletişim + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Görev ve Sorumlulukları</h4>";
        //                for (int j = 0; j < Proje.calisantemsilciler[i].gorevvesorumluluklar.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += (j + 1) + ". " + Proje.calisantemsilciler[i].gorevvesorumluluklar[j] + "<br/>";
        //                }
        //            }
        //            break;
        //        case YazdırmaIslemi.isguzmanlar:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Asıl İşveren/Ana Yüklenici İş Güvenliği Uzman(lar)ı, Görev ve Sorumlulukları</h3>";
        //            for (int i = 0; i < Proje.asilisverenisguzmanlari.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>" + (i + 1) + ". İş Güvenliği Uzmanı</h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Ad Soyad: " + Proje.asilisverenisguzmanlari[i].ad + "<br/>";
        //                //webBrowser1.Document.GetElementById("alt").InnerHtml += "TC Kimlik No: " + Proje.asilisverenisguzmanlari[i].tc + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Sertifika Sınıfı/No.: " + Proje.asilisverenisguzmanlari[i].sert + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "İletişim Bilgileri: " + Proje.asilisverenisguzmanlari[i].iletişim + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Görev ve Sorumlulukları</h4>";
        //                for (int j = 0; j < Proje.asilisverenisguzmanlari[i].gorevvesorumluluklar.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += (j + 1) + ". " + Proje.asilisverenisguzmanlari[i].gorevvesorumluluklar[j] + "<br/>";
        //                }

        //            }
        //            break;
        //        case YazdırmaIslemi.hekimler:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Asıl İşveren/Ana Yüklenici İşyeri Hekim(ler)i, Görev ve Sorumlulukları</h3>";
        //            for (int i = 0; i < Proje.asilisverenisyerihekimleri.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>" + (i + 1) + ". İşyeri Hekimi</h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Ad Soyad: " + Proje.asilisverenisyerihekimleri[i].ad + "<br/>";
        //                //webBrowser1.Document.GetElementById("alt").InnerHtml += "TC Kimlik No: " + Proje.asilisverenisyerihekimleri[i].tc + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Sertifika Sınıfı/No.: " + Proje.asilisverenisyerihekimleri[i].sert + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "İletişim Bilgileri: " + Proje.asilisverenisyerihekimleri[i].iletişim + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Görev ve Sorumlulukları</h4>";
        //                for (int j = 0; j < Proje.asilisverenisyerihekimleri[i].gorevvesorumluluklar.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += (j + 1) + ". " + Proje.asilisverenisyerihekimleri[i].gorevvesorumluluklar[j] + "<br/>";
        //                }

        //            }
        //            break;
        //        case YazdırmaIslemi.isv_gorev:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>İşveren Görev Ve Sorumlulukları</h3>";
        //            for (int i = 0; i < Proje.isveren.gorevveSorumluluklar.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += (i + 1) + ". " + Proje.isveren.gorevveSorumluluklar[i] + "<br/>";
        //            }
        //            break;
        //        case YazdırmaIslemi.saglık_uygulama:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Sağlık ve Güvenlik Koordinatörü (Uygulama Aşaması), Görev Ve Sorumlulukları</h3>";

        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Sağlık ve Güvenlik Koordinatörü (Uygulama Aşaması)</h4>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "Ad Soyad: " + Proje.SGKoordianator_sorumlu_uygulama.adsoyad + "<br/>";
        //            //webBrowser1.Document.GetElementById("alt").InnerHtml += "TC Kimlik No: " + Proje.SGKoordianator_sorumlu_uygulama.TCKimlikNo + "<br/>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "Mesleği: " + Proje.SGKoordianator_sorumlu_uygulama.Meslek + "<br/>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "İletişim Bilgileri: " + Proje.SGKoordianator_sorumlu_uygulama.iletisim + "<br/>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Görev ve Sorumlulukları</h4>";
        //            for (int i = 0; i < Proje.SGKoordianator_sorumlu_uygulama.gorevvesorumluluklar.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += (i + 1) + ". " + Proje.SGKoordianator_sorumlu_uygulama.gorevvesorumluluklar[i] + "<br/>";
        //            }
        //            break;
        //        case YazdırmaIslemi.saglık_hazirlik:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Sağlık ve Güvenlik Koordinatörü (Hazırlık Aşaması), Görev Ve Sorumlulukları</h3>";

        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Sağlık ve Güvenlik Koordinatörü (Hazırlık Aşaması)</h4>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "Ad Soyad: " + Proje.SGKoordianator_sorumlu_hazirlik.adsoyad + "<br/>";
        //            //webBrowser1.Document.GetElementById("alt").InnerHtml += "TC Kimlik No: " + Proje.SGKoordianator_sorumlu_hazirlik.TCKimlikNo + "<br/>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "Mesleği: " + Proje.SGKoordianator_sorumlu_hazirlik.Meslek + "<br/>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "İletişim Bilgileri: " + Proje.SGKoordianator_sorumlu_hazirlik.iletisim + "<br/>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Görev ve Sorumlulukları</h4>";
        //            for (int i = 0; i < Proje.SGKoordianator_sorumlu_hazirlik.gorevvesorumluluklar.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += (i + 1) + ". " + Proje.SGKoordianator_sorumlu_hazirlik.gorevvesorumluluklar[i] + "<br/>";
        //            }
        //            break;
        //        case YazdırmaIslemi.ProjeSorumlusu:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Proje Sorumlusu, Görev Ve Sorumlulukları</h3>";

        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Proje Sorumlusu</h4>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "Ad Soyad: " + Proje.projeSorumlusu.adsoyad + "<br/>";
        //            //webBrowser1.Document.GetElementById("alt").InnerHtml += "TC Kimlik No: " + Proje.projeSorumlusu.TCKimlikNo + "<br/>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "Mesleği: " + Proje.projeSorumlusu.Meslek + "<br/>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "İletişim Bilgileri: " + Proje.projeSorumlusu.iletisim + "<br/>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Görev ve Sorumlulukları</h4>";
        //            for (int i = 0; i < Proje.projeSorumlusu.gorevvesorumluluklar.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += (i + 1) + ". " + Proje.projeSorumlusu.gorevvesorumluluklar[i] + "<br/>";
        //            }
        //            break;
        //        case YazdırmaIslemi.alt_gorev:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Alt İşveren(ler) Görev Ve Sorumlulukları</h3>";
        //            for (int i = 0; i < Proje.altisverenListesi.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>" + (i + 1) + ". Alt İşveren:" + Proje.altisverenListesi[i].altisveren + " Görev ve Sorumlulukları</h4>";
        //                for (int j = 0; j < Proje.altisverenListesi[i].gorevvesorumluluklar.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += (j + 1) + ". " + Proje.altisverenListesi[i].gorevvesorumluluklar[j] + "<br/>";
        //                }

        //            }
        //            break;
        //        case YazdırmaIslemi.kendinamına_gorev:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Kendi Namına Çalışanların Görev Ve Sorumlulukları</h3>";
        //            for (int i = 0; i < Proje.kendiNaminaCalisanlarListesi.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>" + (i + 1) + ". Kendi Namına Çalışan:" + Proje.kendiNaminaCalisanlarListesi[i].adsoyad + " Görev ve Sorumlulukları</h4>";
        //                for (int j = 0; j < Proje.kendiNaminaCalisanlarListesi[i].gorevvesorumluluklar.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += (j + 1) + ". " + Proje.kendiNaminaCalisanlarListesi[i].gorevvesorumluluklar[j] + "<br/>";
        //                }

        //            }
        //            break;
        //        case YazdırmaIslemi.YönetiminTaahhüdü:
        //            webBrowser1.Document.GetElementById("firmaismi").InnerText = Proje.isveren.unvan;
        //            webBrowser1.Document.GetElementById("Proje").InnerText = Proje.projeBilgileri.projeAdi;
        //            for (int i = 0; i < Proje.yonTaahud.taahudler.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("taah").InnerHtml += i+1+". "+ Proje.yonTaahud.taahudler[i]+"<br/>";  
        //            }
                    
        //            webBrowser1.Document.GetElementById("Tarih").InnerText = DateTime.Now.ToShortDateString();
        //            webBrowser1.Document.GetElementById("adsoyad").InnerText = Proje.yonTaahud.adSoyad;
                    
        //            break;
        //        case YazdırmaIslemi.İşverenBilgileri:

        //            webBrowser1.Document.GetElementById("isveren").InnerText = Proje.isveren.isveren;
        //            webBrowser1.Document.GetElementById("unvan").InnerText = Proje.isveren.unvan;
        //            webBrowser1.Document.GetElementById("sgk").InnerText = Proje.isveren.sgksicilno;
        //            webBrowser1.Document.GetElementById("tebligat").InnerText = Proje.isveren.adres;
        //            webBrowser1.Document.GetElementById("tel").InnerText = Proje.isveren.telfaks;
        //            webBrowser1.Document.GetElementById("web").InnerText = Proje.isveren.web;
        //            webBrowser1.Document.GetElementById("sorumlu").InnerText = Proje.isveren.sorumlufirmalar;
        //            break;
        //        case YazdırmaIslemi.ProjeBilgileri:
        //            webBrowser1.Document.GetElementById("ProjeAdı").InnerText = Proje.projeBilgileri.projeAdi;
        //            webBrowser1.Document.GetElementById("sahib").InnerText = Proje.projeBilgileri.isinSahibi;
        //            webBrowser1.Document.GetElementById("adres").InnerText = Proje.projeBilgileri.adres;
        //            webBrowser1.Document.GetElementById("tanım").InnerText = Proje.projeBilgileri.tanim;
        //            webBrowser1.Document.GetElementById("baslangic").InnerText = Proje.projeBilgileri.baslangicTarih.ToShortDateString();
        //            webBrowser1.Document.GetElementById("bitis").InnerText = Proje.projeBilgileri.bitisTarih.ToShortDateString();

        //            break;
        //        case YazdırmaIslemi.kendinamına:
        //            if (Proje.kendiNaminaCalisanlarListesi.Count != 0)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>2.1.4 Kendi Namına Çalışanlara Ait Bilgiler</h3>";
        //                for (int i = 0; i < Proje.kendiNaminaCalisanlarListesi.Count; i++)
        //                {


        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "<h1\">" + (i + 1) + ". Kendi Nam ve Hesabına Çalışan İle İlgili Bilgiler</h1>";


        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "Ad Soyad: ";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.kendiNaminaCalisanlarListesi[i].adsoyad + "<br/>";


        //                    //webBrowser1.Document.GetElementById("alt").InnerHtml += "T.C. Kimlik No: ";
        //                    //webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.kendiNaminaCalisanlarListesi[i].tckimlikno + "<br/>";


        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "Tebligat Adresi: ";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.kendiNaminaCalisanlarListesi[i].adres + "<br/>";

        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "Sözleşme Konusu İşler: ";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.kendiNaminaCalisanlarListesi[i].isler + "<br/>";

        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "Sözleşme Başlangıç Tarihi:";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.kendiNaminaCalisanlarListesi[i].baslangictarih.ToShortDateString() + "<br/>";

        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "Sözleşme Bitiş Tarihi:";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.kendiNaminaCalisanlarListesi[i].bitistarih.ToShortDateString() + "<br/><br/>";

        //                }
        //            }
        //            else
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Kendi namına çalışan bulunmamaktadır";
        //            break;
        //        case YazdırmaIslemi.altisverenler:
        //            if (Proje.altisverenListesi.Count != 0)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>2.1.3 Alt İşveren/Alt Yükleniciye Ait Bilgiler</h3>";
        //                for (int i = 0; i < Proje.altisverenListesi.Count; i++)
        //                {


        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "<h1\">" + (i + 1) + ". Alt İşveren İle İlgili Bilgiler</h1>";


        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "Alt İşveren: ";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.altisverenListesi[i].altisveren + "<br/>";


        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "İşyeri SGK Sicil No.:";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.altisverenListesi[i].sgk + "<br/>";


        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "Tebligat Adresi: ";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.altisverenListesi[i].adres + "<br/>";

        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "Sözleşme Konusu İşler:";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.altisverenListesi[i].isler + "<br/>";

        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "Sözleşme Başlangıç Tarihi:";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.altisverenListesi[i].baslangictarih.ToShortDateString() + "<br/>";

        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "Sözleşme Bitiş Tarihi:";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.altisverenListesi[i].bitistarih.ToShortDateString() + "<br/>";



        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "İş Güvenliği Uzmanı/Sertifika No:";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.altisverenListesi[i].isguzmanad + "/";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.altisverenListesi[i].isguzmansert + "<br/>";

        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "İşyeri Hekimi/Sertifika No:";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.altisverenListesi[i].hekimad + "/";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.altisverenListesi[i].hekimsert + "<br/><br/>";

        //                }
        //            }
        //            else
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Alt işveren bulunmamaktadır";

        //            break;
        //        default:
        //            break;
        //    }
        //   // htmlPanel1.Text = webBrowser1.Document.Body.OuterHtml;
        //}
        string dosyaadi = "";
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dosyaadi = saveFileDialog1.FileName;
                
               
                
            }
            
            //webBrowser1.ShowPrintDialog();


        }
       

        private void YazdırForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        private void HTMLYazdir(YazdırmaIslemi islem)
        {
            
            switch (islem)
            {
                case YazdırmaIslemi.YönetiminTaahhüdü:
                    PdfWriter yazici = new PdfWriter(dosyaadi);
                    
                    break;
                case YazdırmaIslemi.İşverenBilgileri:
                    break;
                case YazdırmaIslemi.ProjeBilgileri:
                    break;
                case YazdırmaIslemi.altisverenler:
                    break;
                case YazdırmaIslemi.kendinamına:
                    break;
                case YazdırmaIslemi.isv_gorev:
                    break;
                case YazdırmaIslemi.alt_gorev:
                    break;
                case YazdırmaIslemi.kendinamına_gorev:
                    break;
                case YazdırmaIslemi.ProjeSorumlusu:
                    break;
                case YazdırmaIslemi.saglık_hazirlik:
                    break;
                case YazdırmaIslemi.saglık_uygulama:
                    break;
                case YazdırmaIslemi.isguzmanlar:
                    break;
                case YazdırmaIslemi.hekimler:
                    break;
                case YazdırmaIslemi.CalisanTemsilcileri:
                    break;
                case YazdırmaIslemi.İşakışPlanı:
                    break;
                case YazdırmaIslemi.ÇalışmaYöntemleri:
                    break;
                case YazdırmaIslemi.YapıSahasıRisk:
                    break;
                case YazdırmaIslemi.İşleAlakalı:
                    break;
                case YazdırmaIslemi.çakışanişler:
                    break;
                case YazdırmaIslemi.UcuncuTaraf:
                    break;
                case YazdırmaIslemi.ŞantiyeKuralları:
                    break;
                case YazdırmaIslemi.Prosedür:
                    break;
                case YazdırmaIslemi.TümRapor:
                   
                    
                    #region YonetiminTaahuduSayfası
                    YonetiminTaahhuduHtml();
                    string pdfyazilacak = BaslikToString();
                    pdfyazilacak += Proje.yonTaahud.toHTML();
                    pdfyazilacak += FooterToString();
                    
                    
                    
                    
                    
                    #endregion
                    



                    break;
                default:
                    break;
            }
        }

        private void YonetiminTaahhuduHtml()
        {
            Proje.yonTaahud.proje = Proje.projeBilgileri.projeAdi;
            Proje.yonTaahud.firma = Proje.isveren.unvan;
           
        }
        private string YonetiminTaahhuduToString()
        {
            string sonuc = "";
            Proje.yonTaahud.proje = Proje.projeBilgileri.projeAdi;
            Proje.yonTaahud.firma = Proje.isveren.unvan;
            sonuc += Proje.yonTaahud.toHTML();
            return sonuc;
        }
        private string FooterToString()
        {
            string sonuc = "";
            sonuc += "</div>";
            sonuc += "</div>";
            sonuc += "</body>";
            sonuc += "</html>";
            return sonuc;
            
        }
        
        private string BaslikToString()
        {
            string sonuc = "";
            sonuc += "<!DOCTYPE html>";
            sonuc += "<html>";
            sonuc += "<head>";
            sonuc += "<title></title>";

            sonuc += "<meta charset = 'utf-8'/>";


            sonuc += "</head> ";
            sonuc += "<body style='width:550px; text-align:justify;'>";
            sonuc += "<div id='wrapper' style='width: 540px;'>";
            sonuc += "<div id='alt' style='width: 500px; margin: auto;'>";
            return sonuc;
        }
       
        //private void button2_Click_1(object sender, EventArgs e)
        //{
        //    if (saveFileDialog1.ShowDialog()==DialogResult.OK)
        //    {
        //        dosyaadi = saveFileDialog1.FileName;
        //    }
        //    switch (Islem)
        //    {
        //        case YazdırmaIslemi.Prosedür:
        //            //webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Ziyaretçilerle ilgili prosedürler</h3>";
        //            //webBrowser1.Document.GetElementById("alt").InnerHtml += "<ol>";
        //            //for (int i = 0; i < Proje.kurallar.ziyaretciprosedur.Count; i++)
        //            //{
        //            //    webBrowser1.Document.GetElementById("alt").InnerHtml += "<li>" + Proje.kurallar.ziyaretciprosedur[i] + "</li>";
        //            //}
        //            //webBrowser1.Document.GetElementById("alt").InnerHtml += "</ol>";
        //            string yazdirilacak = htmlPanel1.GetHtml();

        //           // string yazdirilacak = webBrowser1.Document.GetElementById("alt").InnerHtml;
        //            PdfDocument pdf = PdfGenerator.GeneratePdf(yazdirilacak, PageSize.A4);

        //            pdf.Save(dosyaadi);
        //            break;
        //        case YazdırmaIslemi.ŞantiyeKuralları:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Şantiye Kuralları</h3>";
        //            for (int i = 0; i < Proje.kurallar.kurallar.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += (i + 1) + ". " + Proje.kurallar.kurallar[i] + "<br/>";
        //            }
        //            break;
        //        case YazdırmaIslemi.UcuncuTaraf:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Üçüncü Taraflara Etki</h3>";
        //            for (int i = 0; i < Proje.ucuncutaraflar.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Risk</h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.ucuncutaraflar[i].risk;
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Etki altındaki bölge/tesis</h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.ucuncutaraflar[i].etki;
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Kontrol Tedbirleri</h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.ucuncutaraflar[i].kontrol;
        //            }

        //            break;
        //        case YazdırmaIslemi.çakışanişler:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h2>Zaman ve Mekân Açısından Çakışan İşlerden Kaynaklanan Riskler </h2>";
        //            for (int i = 0; i < Proje.cakisanisler.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Çakışan İşler: ";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.cakisanisler[i].iş1.isinadi + " - " + Proje.cakisanisler[i].iş2.isinadi + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Çakışma Başlangıç Tarihi: " + Proje.cakisanisler[i].çakışmabaşlangıç.ToShortDateString() + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Çakışma Bitiş Tarihi: " + Proje.cakisanisler[i].çakışmabitiş.ToShortDateString() + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Risk: " + Proje.cakisanisler[i].risk + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Etkilenen çalışanlar/Etki altındaki bölge: " + Proje.cakisanisler[i].Etkilenenler + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Kontrol Önlemleri: " + Proje.cakisanisler[i].kontrol + "<br/><br/><br/>";
        //            }
        //            break;
        //        case YazdırmaIslemi.İşleAlakalı:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h2>İşle Alakalı Muhtemel Riskler ve Kontrol Tedbirleri</h2>";
        //            for (int i = 0; i < Proje.plan.yapilacakisler.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Yapılacak İş:" + Proje.plan.yapilacakisler[i].isinadi + "</h3>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Fiziksel Tehlikeler</h4>";
        //                for (int j = 0; j < Proje.plan.yapilacakisler[i].fizikseltehlikeler.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "<h5>Tehlike Kaynağı</h5>";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.plan.yapilacakisler[i].fizikseltehlikeler[j].tehlikekayangi + "<br/>";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "<h5>Riskler</h5>";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.plan.yapilacakisler[i].fizikseltehlikeler[j].risk + "<br/>";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "<h5>Kontrol Önlemi</h5>";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.plan.yapilacakisler[i].fizikseltehlikeler[j].onlem + "<br/>";
        //                }
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Kimyasal Tehlikeler</h4>";
        //                for (int j = 0; j < Proje.plan.yapilacakisler[i].fizikseltehlikeler.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "<h5>Tehlike Kaynağı</h5>";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.plan.yapilacakisler[i].kimyasaltehlikeler[j].tehlikekayangi + "<br/>";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "<h5>Riskler</h5>";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.plan.yapilacakisler[i].kimyasaltehlikeler[j].risk + "<br/>";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "<h5>Kontrol Önlemi</h5>";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.plan.yapilacakisler[i].kimyasaltehlikeler[j].onlem + "<br/>";
        //                }
        //            }
        //            break;
        //        case YazdırmaIslemi.YapıSahasıRisk:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h2>Yapı Sahasının Geneline Etki Eden Riskler ve Kontrol Tedbirleri</h2>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Yapı Sahasının Geneline Özgü</h3>";
        //            for (int i = 0; i < Proje.yapisahasiningenelozgutehlikeler.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Tehlike Kaynağı: </h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.yapisahasiningenelozgutehlikeler[i].tehlikekayangi + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Risk: </h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.yapisahasiningenelozgutehlikeler[i].risk + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Kontrol Önlemi: </h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.yapisahasiningenelozgutehlikeler[i].onlem + "<br/>";
        //            }
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Biyolojik</h3>";
        //            for (int i = 0; i < Proje.biyolojiktehlikeler.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Tehlike Kaynağı: </h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.biyolojiktehlikeler[i].tehlikekayangi + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Risk: </h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.biyolojiktehlikeler[i].risk + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Kontrol Önlemi: </h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.biyolojiktehlikeler[i].onlem + "<br/>";
        //            }
        //            break;
        //        case YazdırmaIslemi.ÇalışmaYöntemleri:
        //            for (int i = 0; i < Proje.plan.yapilacakisler.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h2>Yapılacak İş:" + Proje.plan.yapilacakisler[i].isinadi + "</h2>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Çalışma Yöntemi</h3>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Teknik Açıklama ve Gereklilikler</h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h5>Yapım Tekniği ve Teknolojisi  </h5>";
        //                for (int j = 0; j < Proje.plan.yapilacakisler[i].yontem.yapımtekniği.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.plan.yapilacakisler[i].yontem.yapımtekniği[j] + "<br/>";
        //                }
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h5>İş Ekipmanı Kullanımı</h5>";
        //                for (int j = 0; j < Proje.plan.yapilacakisler[i].yontem.işekipmanikullanimi.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.plan.yapilacakisler[i].yontem.işekipmanikullanimi[j] + "<br/>";
        //                }
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h5>Kimyasal Madde Kullanımı</h5>";
        //                for (int j = 0; j < Proje.plan.yapilacakisler[i].yontem.kimyasalmaddekullanimi.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.plan.yapilacakisler[i].yontem.kimyasalmaddekullanimi[j] + "<br/>";
        //                }
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Çalışma Alanına Erişim</h4>";
        //                for (int j = 0; j < Proje.plan.yapilacakisler[i].yontem.calismaalaninaerisim.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.plan.yapilacakisler[i].yontem.calismaalaninaerisim[j] + "<br/>";
        //                }
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Malzemelerin Taşınması</h4>";
        //                for (int j = 0; j < Proje.plan.yapilacakisler[i].yontem.malzemelerintasinmasi.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.plan.yapilacakisler[i].yontem.malzemelerintasinmasi[j] + "<br/>";
        //                }
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>İş Ekipmanı:</h4>";
        //                for (int j = 0; j < Proje.plan.yapilacakisler[i].yontem.isekipmani.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += (j + 1) + ". " + Proje.plan.yapilacakisler[i].yontem.isekipmani[j] + "<br/>";
        //                }
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Kullanılacak Kimyasallar:</h4>";
        //                for (int j = 0; j < Proje.plan.yapilacakisler[i].yontem.kullanilacakkimyasallar.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += (j + 1) + ". " + Proje.plan.yapilacakisler[i].yontem.kullanilacakkimyasallar[j] + "<br/>";
        //                }
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Eğitimli Personel İhtiyacı:</h4>";
        //                for (int j = 0; j < Proje.plan.yapilacakisler[i].yontem.egitimlipersonelihtiyaci.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += (j + 1) + ". " + Proje.plan.yapilacakisler[i].yontem.egitimlipersonelihtiyaci[j] + "<br/>";
        //                }
        //            }

        //            break;
        //        case YazdırmaIslemi.İşakışPlanı:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>İş Akış Planı</h3>";
        //            for (int i = 0; i < Proje.plan.yapilacakisler.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>" + (i + 1) + ". Yapılacak İş: " + Proje.plan.yapilacakisler[i].isinadi + "</h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Başlangıç Tarihi: " + Proje.plan.yapilacakisler[i].baslangic.ToShortDateString() + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Bitiş Tarihi: " + Proje.plan.yapilacakisler[i].bitis.ToShortDateString() + "<br/>";

        //            }
        //            break;
        //        case YazdırmaIslemi.CalisanTemsilcileri:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Çalışan Temsilcileri - Görev ve Sorumlulukları</h3>";
        //            for (int i = 0; i < Proje.calisantemsilciler.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>" + (i + 1) + ". Çalışan Temsilcisi:</h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Ad Soyad: " + Proje.calisantemsilciler[i].ad + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "TC Kimlik No: " + Proje.calisantemsilciler[i].tc + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Görevi: " + Proje.calisantemsilciler[i].gorevi + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "İletişim Bilgileri: " + Proje.calisantemsilciler[i].iletişim + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Görev ve Sorumlulukları</h4>";
        //                for (int j = 0; j < Proje.calisantemsilciler[i].gorevvesorumluluklar.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += (j + 1) + ". " + Proje.calisantemsilciler[i].gorevvesorumluluklar[j] + "<br/>";
        //                }
        //            }
        //            break;
        //        case YazdırmaIslemi.isguzmanlar:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Asıl İşveren/Ana Yüklenici İş Güvenliği Uzman(lar)ı, Görev ve Sorumlulukları</h3>";
        //            for (int i = 0; i < Proje.asilisverenisguzmanlari.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>" + (i + 1) + ". İş Güvenliği Uzmanı</h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Ad Soyad: " + Proje.asilisverenisguzmanlari[i].ad + "<br/>";
        //                //webBrowser1.Document.GetElementById("alt").InnerHtml += "TC Kimlik No: " + Proje.asilisverenisguzmanlari[i].tc + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Sertifika Sınıfı/No.: " + Proje.asilisverenisguzmanlari[i].sert + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "İletişim Bilgileri: " + Proje.asilisverenisguzmanlari[i].iletişim + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Görev ve Sorumlulukları</h4>";
        //                for (int j = 0; j < Proje.asilisverenisguzmanlari[i].gorevvesorumluluklar.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += (j + 1) + ". " + Proje.asilisverenisguzmanlari[i].gorevvesorumluluklar[j] + "<br/>";
        //                }

        //            }
        //            break;
        //        case YazdırmaIslemi.hekimler:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Asıl İşveren/Ana Yüklenici İşyeri Hekim(ler)i, Görev ve Sorumlulukları</h3>";
        //            for (int i = 0; i < Proje.asilisverenisyerihekimleri.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>" + (i + 1) + ". İşyeri Hekimi</h4>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Ad Soyad: " + Proje.asilisverenisyerihekimleri[i].ad + "<br/>";
        //                //webBrowser1.Document.GetElementById("alt").InnerHtml += "TC Kimlik No: " + Proje.asilisverenisyerihekimleri[i].tc + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Sertifika Sınıfı/No.: " + Proje.asilisverenisyerihekimleri[i].sert + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "İletişim Bilgileri: " + Proje.asilisverenisyerihekimleri[i].iletişim + "<br/>";
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Görev ve Sorumlulukları</h4>";
        //                for (int j = 0; j < Proje.asilisverenisyerihekimleri[i].gorevvesorumluluklar.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += (j + 1) + ". " + Proje.asilisverenisyerihekimleri[i].gorevvesorumluluklar[j] + "<br/>";
        //                }

        //            }
        //            break;
        //        case YazdırmaIslemi.isv_gorev:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>İşveren Görev Ve Sorumlulukları</h3>";
        //            for (int i = 0; i < Proje.isveren.gorevveSorumluluklar.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += (i + 1) + ". " + Proje.isveren.gorevveSorumluluklar[i] + "<br/>";
        //            }
        //            break;
        //        case YazdırmaIslemi.saglık_uygulama:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Sağlık ve Güvenlik Koordinatörü (Uygulama Aşaması), Görev Ve Sorumlulukları</h3>";

        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Sağlık ve Güvenlik Koordinatörü (Uygulama Aşaması)</h4>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "Ad Soyad: " + Proje.SGKoordianator_sorumlu_uygulama.adsoyad + "<br/>";
        //            //webBrowser1.Document.GetElementById("alt").InnerHtml += "TC Kimlik No: " + Proje.SGKoordianator_sorumlu_uygulama.TCKimlikNo + "<br/>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "Mesleği: " + Proje.SGKoordianator_sorumlu_uygulama.Meslek + "<br/>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "İletişim Bilgileri: " + Proje.SGKoordianator_sorumlu_uygulama.iletisim + "<br/>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Görev ve Sorumlulukları</h4>";
        //            for (int i = 0; i < Proje.SGKoordianator_sorumlu_uygulama.gorevvesorumluluklar.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += (i + 1) + ". " + Proje.SGKoordianator_sorumlu_uygulama.gorevvesorumluluklar[i] + "<br/>";
        //            }
        //            break;
        //        case YazdırmaIslemi.saglık_hazirlik:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Sağlık ve Güvenlik Koordinatörü (Hazırlık Aşaması), Görev Ve Sorumlulukları</h3>";

        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Sağlık ve Güvenlik Koordinatörü (Hazırlık Aşaması)</h4>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "Ad Soyad: " + Proje.SGKoordianator_sorumlu_hazirlik.adsoyad + "<br/>";
        //            //webBrowser1.Document.GetElementById("alt").InnerHtml += "TC Kimlik No: " + Proje.SGKoordianator_sorumlu_hazirlik.TCKimlikNo + "<br/>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "Mesleği: " + Proje.SGKoordianator_sorumlu_hazirlik.Meslek + "<br/>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "İletişim Bilgileri: " + Proje.SGKoordianator_sorumlu_hazirlik.iletisim + "<br/>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Görev ve Sorumlulukları</h4>";
        //            for (int i = 0; i < Proje.SGKoordianator_sorumlu_hazirlik.gorevvesorumluluklar.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += (i + 1) + ". " + Proje.SGKoordianator_sorumlu_hazirlik.gorevvesorumluluklar[i] + "<br/>";
        //            }
        //            break;
        //        case YazdırmaIslemi.ProjeSorumlusu:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Proje Sorumlusu, Görev Ve Sorumlulukları</h3>";

        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Proje Sorumlusu</h4>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "Ad Soyad: " + Proje.projeSorumlusu.adsoyad + "<br/>";
        //            //webBrowser1.Document.GetElementById("alt").InnerHtml += "TC Kimlik No: " + Proje.projeSorumlusu.TCKimlikNo + "<br/>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "Mesleği: " + Proje.projeSorumlusu.Meslek + "<br/>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "İletişim Bilgileri: " + Proje.projeSorumlusu.iletisim + "<br/>";
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>Görev ve Sorumlulukları</h4>";
        //            for (int i = 0; i < Proje.projeSorumlusu.gorevvesorumluluklar.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += (i + 1) + ". " + Proje.projeSorumlusu.gorevvesorumluluklar[i] + "<br/>";
        //            }
        //            break;
        //        case YazdırmaIslemi.alt_gorev:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Alt İşveren(ler) Görev Ve Sorumlulukları</h3>";
        //            for (int i = 0; i < Proje.altisverenListesi.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>" + (i + 1) + ". Alt İşveren:" + Proje.altisverenListesi[i].altisveren + " Görev ve Sorumlulukları</h4>";
        //                for (int j = 0; j < Proje.altisverenListesi[i].gorevvesorumluluklar.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += (j + 1) + ". " + Proje.altisverenListesi[i].gorevvesorumluluklar[j] + "<br/>";
        //                }

        //            }
        //            break;
        //        case YazdırmaIslemi.kendinamına_gorev:
        //            webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>Kendi Namına Çalışanların Görev Ve Sorumlulukları</h3>";
        //            for (int i = 0; i < Proje.kendiNaminaCalisanlarListesi.Count; i++)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h4>" + (i + 1) + ". Kendi Namına Çalışan:" + Proje.kendiNaminaCalisanlarListesi[i].adsoyad + " Görev ve Sorumlulukları</h4>";
        //                for (int j = 0; j < Proje.kendiNaminaCalisanlarListesi[i].gorevvesorumluluklar.Count; j++)
        //                {
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += (j + 1) + ". " + Proje.kendiNaminaCalisanlarListesi[i].gorevvesorumluluklar[j] + "<br/>";
        //                }

        //            }
        //            break;
        //        case YazdırmaIslemi.YönetiminTaahhüdü:
        //            //webBrowser1.Document.GetElementById("firmaismi").InnerText = Proje.isveren.unvan;
        //            //webBrowser1.Document.GetElementById("Proje").InnerText = Proje.projeBilgileri.projeAdi;
        //            //for (int i = 0; i < Proje.yonTaahud.taahudler.Count; i++)
        //            //{
        //            //    webBrowser1.Document.GetElementById("taah").InnerHtml += "<li>" + Proje.yonTaahud.taahudler[i] + "</li>";
        //            //}

        //            //webBrowser1.Document.GetElementById("Tarih").InnerText = DateTime.Now.ToShortDateString();
        //            //webBrowser1.Document.GetElementById("adsoyad").InnerText = Proje.yonTaahud.adSoyad;
        //            string taah = htmlPanel1.Text;
        //            PdfDocument taahpdf = PdfGenerator.GeneratePdf(taah, PageSize.A4);
        //            taahpdf.Save(dosyaadi);
        //            break;
        //        case YazdırmaIslemi.İşverenBilgileri:

        //            webBrowser1.Document.GetElementById("isveren").InnerText = Proje.isveren.isveren;
        //            webBrowser1.Document.GetElementById("unvan").InnerText = Proje.isveren.unvan;
        //            webBrowser1.Document.GetElementById("sgk").InnerText = Proje.isveren.sgksicilno;
        //            webBrowser1.Document.GetElementById("tebligat").InnerText = Proje.isveren.adres;
        //            webBrowser1.Document.GetElementById("tel").InnerText = Proje.isveren.telfaks;
        //            webBrowser1.Document.GetElementById("web").InnerText = Proje.isveren.web;
        //            webBrowser1.Document.GetElementById("sorumlu").InnerText = Proje.isveren.sorumlufirmalar;
        //            break;
        //        case YazdırmaIslemi.ProjeBilgileri:
        //            webBrowser1.Document.GetElementById("ProjeAdı").InnerText = Proje.projeBilgileri.projeAdi;
        //            webBrowser1.Document.GetElementById("sahib").InnerText = Proje.projeBilgileri.isinSahibi;
        //            webBrowser1.Document.GetElementById("adres").InnerText = Proje.projeBilgileri.adres;
        //            webBrowser1.Document.GetElementById("tanım").InnerText = Proje.projeBilgileri.tanim;
        //            webBrowser1.Document.GetElementById("baslangic").InnerText = Proje.projeBilgileri.baslangicTarih.ToShortDateString();
        //            webBrowser1.Document.GetElementById("bitis").InnerText = Proje.projeBilgileri.bitisTarih.ToShortDateString();

        //            break;
        //        case YazdırmaIslemi.kendinamına:
        //            if (Proje.kendiNaminaCalisanlarListesi.Count != 0)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>2.1.4 Kendi Namına Çalışanlara Ait Bilgiler</h3>";
        //                for (int i = 0; i < Proje.kendiNaminaCalisanlarListesi.Count; i++)
        //                {


        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "<h1\">" + (i + 1) + ". Kendi Nam ve Hesabına Çalışan İle İlgili Bilgiler</h1>";


        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "Ad Soyad: ";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.kendiNaminaCalisanlarListesi[i].adsoyad + "<br/>";


        //                    //webBrowser1.Document.GetElementById("alt").InnerHtml += "T.C. Kimlik No: ";
        //                    //webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.kendiNaminaCalisanlarListesi[i].tckimlikno + "<br/>";


        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "Tebligat Adresi: ";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.kendiNaminaCalisanlarListesi[i].adres + "<br/>";

        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "Sözleşme Konusu İşler: ";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.kendiNaminaCalisanlarListesi[i].isler + "<br/>";

        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "Sözleşme Başlangıç Tarihi:";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.kendiNaminaCalisanlarListesi[i].baslangictarih.ToShortDateString() + "<br/>";

        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "Sözleşme Bitiş Tarihi:";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.kendiNaminaCalisanlarListesi[i].bitistarih.ToShortDateString() + "<br/><br/>";

        //                }
        //            }
        //            else
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Kendi namına çalışan bulunmamaktadır";
        //            break;
        //        case YazdırmaIslemi.altisverenler:
        //            if (Proje.altisverenListesi.Count != 0)
        //            {
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "<h3>2.1.3 Alt İşveren/Alt Yükleniciye Ait Bilgiler</h3>";
        //                for (int i = 0; i < Proje.altisverenListesi.Count; i++)
        //                {


        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "<h1\">" + (i + 1) + ". Alt İşveren İle İlgili Bilgiler</h1>";


        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "Alt İşveren: ";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.altisverenListesi[i].altisveren + "<br/>";


        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "İşyeri SGK Sicil No.:";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.altisverenListesi[i].sgk + "<br/>";


        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "Tebligat Adresi: ";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.altisverenListesi[i].adres + "<br/>";

        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "Sözleşme Konusu İşler:";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.altisverenListesi[i].isler + "<br/>";

        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "Sözleşme Başlangıç Tarihi:";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.altisverenListesi[i].baslangictarih.ToShortDateString() + "<br/>";

        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "Sözleşme Bitiş Tarihi:";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.altisverenListesi[i].bitistarih.ToShortDateString() + "<br/>";



        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "İş Güvenliği Uzmanı/Sertifika No:";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.altisverenListesi[i].isguzmanad + "/";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.altisverenListesi[i].isguzmansert + "<br/>";

        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += "İşyeri Hekimi/Sertifika No:";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.altisverenListesi[i].hekimad + "/";
        //                    webBrowser1.Document.GetElementById("alt").InnerHtml += Proje.altisverenListesi[i].hekimsert + "<br/><br/>";

        //                }
        //            }
        //            else
        //                webBrowser1.Document.GetElementById("alt").InnerHtml += "Alt işveren bulunmamaktadır";

        //            break;
        //        default:
        //            break;
        //    }
        //}




    }
}