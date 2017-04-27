using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YSSGP.Sınıflar;
using iText;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Kernel.Geom;
using iText.Kernel.Font;
using iText.IO.Font;
using iText.Layout.Element;
using iText.IO.Image;

namespace YSSGP.Sınıflar
{
    static class RaporHelper
    {
        /// <summary>
        /// Yonetimin taahhüdü kısmını pdfe dönüştürme aracı.
        /// </summary>
        /// <param name="taah">Yönetimin Taahhüdü sınıfının örneği</param>
        public static void YonetiminTaahuduYazdır(YonetiminTaahudu taah,string dosya)
        {
            PdfWriter pdfyazici = new PdfWriter(dosya);
            PdfDocument pdf = new PdfDocument(pdfyazici);
            Document doc = new Document(pdf, PageSize.A4);
            doc.SetMargins(40, 60, 30, 30);
            //baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\Arial.ttf", "windows-1254", true);
            PdfFont font = PdfFontFactory.CreateFont("C:\\Windows\\Fonts\\times.ttf", "windows-1254",true);


            doc.Add(new Paragraph("1. YÖNETİMİN TAAHHÜDÜ").SetFont(font).SetFontSize(24));
            doc.Add(new Paragraph(taah.firma+ " yöneticisi olarak " + taah.proje + " projesinin hazırlık ve uygulama aşamalarını kapsayacak şekilde projenin tamamlanmasına kadar geçen sürede çalışanların sağlık ve güvenliklerini korumak amacıyla;").SetFont(font).SetFontSize(12));
            List taahhüdlerlist = new List(iText.Layout.Properties.ListNumberingType.DECIMAL).SetFont(font);
            
            for (int i = 0; i < taah.taahudler.Count; i++)
            {
                taahhüdlerlist.Add(new ListItem(taah.taahudler[i]));
            }
            doc.Add(taahhüdlerlist);

            doc.Add(new Paragraph("taahhüt ederim.").SetFont(font).SetFontSize(12));
            doc.Add(new Paragraph("Tarih: " + DateTime.Now.ToShortDateString()).SetMarginTop(120).SetMarginRight(40).SetFont(font).SetFontSize(12).SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT));
                     
            doc.Add(new Paragraph("İmza").SetMarginTop(40).SetMarginRight(40).SetFont(font).SetFontSize(12).SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT));
            doc.Add(new Paragraph("(En üst düzey yönetici tarafından imzalanacaktır.)").SetMarginRight(40).SetFont(font).SetItalic().SetFontSize(12).SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT));
            doc.Add(new Paragraph(taah.adSoyad).SetMarginTop(40).SetMarginRight(40).SetFont(font).SetFontSize(12).SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT));
            doc.Close();
        }

        internal static void ProjeBilgileriYazdir(string dosya,ProjeBilgileri projbilgi,IsverenBilgileri isveren,List<AltIsverenBilgileri> altisverenler, List<KendiNaminaCalisan> kendinamlist)
        {
            PdfWriter pdfyazici = new PdfWriter(dosya);
            PdfDocument pdf = new PdfDocument(pdfyazici);
            Document doc = new Document(pdf, PageSize.A4);
            doc.SetMargins(20, 20, 20, 20);
            
            PdfFont font = PdfFontFactory.CreateFont("C:\\Windows\\Fonts\\times.ttf", "windows-1254", true);


            doc.Add(new Paragraph("2. PROJE BİLGİLERİ").SetFont(font).SetFontSize(24));
            doc.Add(new Paragraph("2.1 Genel Bilgiler").SetFont(font).SetFontSize(12).SetBold());
            doc.Add(new Paragraph("2.1.1 Projeye Ait Bilgiler").SetFont(font).SetFontSize(12));
            Table tablo = new Table(2);
            tablo.SetFont(font);
            tablo.AddCell("Proje Adı:");
            tablo.AddCell(projbilgi.projeAdi);
            tablo.AddCell("İşin Sahibi / İhale Makamı:");
            tablo.AddCell(projbilgi.isinSahibi);
            tablo.AddCell("Yapı Sahasının Açık Adresi:");
            tablo.AddCell(projbilgi.adres);
            tablo.AddCell("Projenin Tanımı ve Kapsamı:");
            tablo.AddCell(projbilgi.tanim);
            tablo.AddCell("Projenin Başlangıç Tarihi:");
            tablo.AddCell(projbilgi.baslangicTarih.ToShortDateString());
            tablo.AddCell("Projenin Planlanan Bitiş Tarihi:");
            tablo.AddCell(projbilgi.bitisTarih.ToShortDateString());

            doc.Add(tablo);

            doc.Add(new Paragraph("2.1.2 İşveren/Ana Yükleniciye Ait Bilgiler").SetFont(font).SetFontSize(12));
            Table isverentablo = new Table(2);
            isverentablo.SetFont(font);
            isverentablo.AddCell("İşveren:");
            isverentablo.AddCell(isveren.isveren);
            isverentablo.AddCell("İşveren/Ana Yüklenici Unvanı:");
            isverentablo.AddCell(isveren.unvan);
            isverentablo.AddCell("İşyeri SGK Sicil No.:");
            isverentablo.AddCell(isveren.sgksicilno);
            isverentablo.AddCell("Tebligat Adresi:");
            isverentablo.AddCell(isveren.adres);
            isverentablo.AddCell("Telefon / Faks:");
            isverentablo.AddCell(isveren.telfaks);
            isverentablo.AddCell("Web adresi:");
            isverentablo.AddCell(isveren.web);
            isverentablo.AddCell("Sorumlu Yapı Denetim Firması /Sorumlu Müşavir Firma/ Diğer Kontrol Birimleri:");
            isverentablo.AddCell(isveren.sorumlufirmalar);

            doc.Add(isverentablo);

            doc.Add(new Paragraph("2.1.3 Alt İşveren/Alt Yükleniciye Ait Bilgiler").SetFont(font).SetFontSize(12));
            for (int i = 0; i < altisverenler.Count; i++)
            {
                doc.Add(new Paragraph((i+1) + ". Alt İşveren").SetFont(font).SetFontSize(12));
                Table altisverentablo = new Table(2);
                altisverentablo.SetFont(font);

                altisverentablo.AddCell("Alt İşveren:");
                //Cell altishucre = new Cell(2, 2).Add(altisverenler[i].altisveren);
                altisverentablo.AddCell(altisverenler[i].altisveren);
                altisverentablo.AddCell("İşyeri SGK Sicil No.: ");
                altisverentablo.AddCell(altisverenler[i].sgk);
                altisverentablo.AddCell("Tebligat Adresi: ");
                altisverentablo.AddCell(altisverenler[i].adres);
                altisverentablo.AddCell("Sözleşme Konusu İşler: ");
                altisverentablo.AddCell(altisverenler[i].isler);
                altisverentablo.AddCell("Sözleşmenin Başlama ve Bitiş Tarihleri: ");
                altisverentablo.AddCell("Başlama Tarihi: " + altisverenler[i].baslangictarih.ToShortDateString() + " - " + "Bitiş Tarihi:" + altisverenler[i].bitistarih.ToShortDateString());
                doc.Add(altisverentablo);
                doc.Add(new Paragraph("İş Güvenliği Uzmanı ve İşyeri Hekimi Bilgileri").SetFont(font).SetFontSize(12));
                Table igutablo = new Table(3);
                igutablo.SetFont(font);
                igutablo.AddCell("");
                igutablo.AddCell("Adı ve Soyadı");
                igutablo.AddCell("Sertifika Sınıfı/No");
                igutablo.AddCell("İş Güvenliği Uzmanı:");
                igutablo.AddCell(altisverenler[i].isguzmanad);
                igutablo.AddCell(altisverenler[i].isguzmansert);
                igutablo.AddCell("İşyeri Hekimi:");
                igutablo.AddCell(altisverenler[i].hekimad);
                igutablo.AddCell(altisverenler[i].hekimsert);
                doc.Add(igutablo);
                
            }

            doc.Add(new Paragraph("2.1.4 Kendi Nam ve Hesabına Çalışanlara Ait Bilgiler").SetFont(font).SetFontSize(12));
            for (int i = 0; i < kendinamlist.Count; i++)
            {
                doc.Add(new Paragraph((i + 1) + ". Kendi Nam ve Hesabına Çalışan").SetFont(font).SetFontSize(12));
                Table kenditablo = new Table(2);
                kenditablo.SetFont(font);
                kenditablo.AddCell("Adı Soyadı:");
                kenditablo.AddCell(kendinamlist[i].adsoyad);
                kenditablo.AddCell("Tebligat Adresi:");
                kenditablo.AddCell(kendinamlist[i].adres);
                kenditablo.AddCell("Sözleşme Konusu İşler:");
                kenditablo.AddCell(kendinamlist[i].isler);
                kenditablo.AddCell("Sözleşmenin Başlama ve Bitiş Tarihleri");
                kenditablo.AddCell("Başlama Tarihi: " + kendinamlist[i].baslangictarih.ToShortDateString() + " - " + "Bitiş Tarihi:" + kendinamlist[i].bitistarih.ToShortDateString());
                doc.Add(kenditablo);
            }


            doc.Close();
        }

        internal static void Bolum3Yazdir(string fileName,IsverenBilgileri isveren,List<AltIsverenBilgileri> altisverenler,List<KendiNaminaCalisan> kendinamlist,ProjeSorumlusu sorumlu,SGKoordinator_Hazirlik hazirlik,SGKUygulama uygulama,List<ISGUzmani> asilisvuzmanlar,List<IsyeriHekimi> asilisvhekimler,List<CalisanTemsilcisi> calisantemsilciler)
        { 
            PdfWriter pdfyazici = new PdfWriter(fileName);
            PdfDocument pdf = new PdfDocument(pdfyazici);
            Document doc = new Document(pdf, PageSize.A4);
            doc.SetMargins(40, 60, 30, 30);
            doc.SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED);
            PdfFont font = PdfFontFactory.CreateFont("C:\\Windows\\Fonts\\times.ttf", "windows-1254", true);


            doc.Add(new Paragraph("3. SAĞLIK VE GÜVENLİK ORGANİZASYONU").SetFont(font).SetFontSize(24));

            doc.Add(new Paragraph("3.1 Görev ve Sorumluluklar").SetFont(font).SetFontSize(12).SetBold());

            doc.Add(new Paragraph("Bu bölümde çalışan, işveren, alt işveren, kendi nam ve hesabına çalışanlar ile ilgili görev ve sorumluluklara yer verilecektir. Ayrıca bu bölümde; iş güvenliği uzmanı, işyeri hekimi, proje sorumlusu, sağlık ve güvenlik koordinatörleri ve çalışan temsilcisine ait bilgiler ile görev ve sorumlulukları belirtilecektir.").SetFont(font).SetFontSize(12));
            doc.Add(new Paragraph("Aşağıda belirtilen görev ve sorumluluklar mevzuat çerçevesinde belirlenmiş genel asgari hükümlerdir. Bu görev ve sorumluluklar haricinde, iş ve işyeri koşulları göz önünde bulundurularak detaylandırmalar yapılabilir.").SetFontSize(12).SetFont(font));

            doc.Add(new Paragraph("İşverenin Görev ve Sorumlulukları").SetFontSize(12).SetFont(font).SetBold());

            List isverengorevvesorumluluklar = new List();

            isverengorevvesorumluluklar.SetFont(font);
            isverengorevvesorumluluklar.SetFontSize(12);

            for (int i = 0; i < isveren.gorevveSorumluluklar.Count; i++)
            {
                ListItem item = new ListItem(isveren.gorevveSorumluluklar[i]);
                isverengorevvesorumluluklar.Add(item);
            }
            doc.Add(isverengorevvesorumluluklar);

            doc.Add(new Paragraph("Alt İşverenlerin Görev ve Sorumlulukları").SetFont(font).SetFontSize(12).SetBold());

            for (int i = 0; i < altisverenler.Count; i++)
            {
                doc.Add(new Paragraph(altisverenler[i].altisveren+ " Görev ve Sorumlulukları").SetFont(font).SetFontSize(12));
                List altisverengorevlist = new List();
                altisverengorevlist.SetFont(font);
                altisverengorevlist.SetFontSize(12);
                for (int j = 0; j < altisverenler[i].gorevvesorumluluklar.Count; j++)
                {
                    ListItem altli_item = new ListItem(altisverenler[i].gorevvesorumluluklar[j]);
                    altisverengorevlist.Add(altli_item);
                }
                doc.Add(altisverengorevlist);
            }
            doc.Add(new Paragraph("Kendi Nam ve Hesabına Çalışanların Görev ve Sorumlulukları").SetFont(font).SetFontSize(12).SetBold());

            for (int i = 0; i < kendinamlist.Count; i++)
            {
                doc.Add(new Paragraph(kendinamlist[i].adsoyad + " Görev ve Sorumlulukları").SetFont(font).SetFontSize(12));
                List kendinamlistesi = new List();
                kendinamlistesi.SetFont(font);
                kendinamlistesi.SetFontSize(12);
                for (int j = 0; j < kendinamlist[i].gorevvesorumluluklar.Count; j++)
                {
                    ListItem altli_item = new ListItem(kendinamlist[i].gorevvesorumluluklar[j]);
                    kendinamlistesi.Add(altli_item);
                }
                doc.Add(kendinamlistesi);
            }

            doc.Add(new Paragraph("Proje Sorumlusu").SetFont(font).SetFontSize(12).SetBold());
            Table ProjeSorumlusuTable = new Table(2);
            ProjeSorumlusuTable.SetFont(font);
            ProjeSorumlusuTable.SetFontSize(12);
            ProjeSorumlusuTable.AddCell("Adı Soyadı:");
            ProjeSorumlusuTable.AddCell(sorumlu.adsoyad);
            ProjeSorumlusuTable.AddCell("Mesleği:");
            ProjeSorumlusuTable.AddCell(sorumlu.Meslek);
            ProjeSorumlusuTable.AddCell("İletişim Bilgileri:");
            ProjeSorumlusuTable.AddCell(sorumlu.iletisim);

            doc.Add(ProjeSorumlusuTable);
            doc.Add(new Paragraph("Proje Sorumlusu Görev ve Sorumlulukları").SetFontSize(12).SetFont(font));
            List projesorumlugorevlist = new List();
            projesorumlugorevlist.SetFont(font);
            projesorumlugorevlist.SetFontSize(12);
            for (int i = 0; i < sorumlu.gorevvesorumluluklar.Count; i++)
            {
                ListItem projlistitem = new ListItem(sorumlu.gorevvesorumluluklar[i]);
                projesorumlugorevlist.Add(projlistitem);
            }
            doc.Add(projesorumlugorevlist);
            doc.Add(new Paragraph("Sağlık ve Güvenlik Koordinatörü (Hazırlık Aşaması)").SetFont(font).SetFontSize(12).SetBold());
            Table SaglikHazirTable = new Table(2);
            SaglikHazirTable.SetFont(font);
            SaglikHazirTable.SetFontSize(12);
            SaglikHazirTable.AddCell("Adı Soyadı:");
            SaglikHazirTable.AddCell(hazirlik.adsoyad);
            SaglikHazirTable.AddCell("Mesleği:");
            SaglikHazirTable.AddCell(hazirlik.Meslek);
            SaglikHazirTable.AddCell("İletişim Bilgileri:");
            SaglikHazirTable.AddCell(hazirlik.iletisim);

            doc.Add(SaglikHazirTable);
            doc.Add(new Paragraph("Sağlık ve Güvenlik Koordinatörü (Hazırlık Aşaması) Görev ve Sorumlulukları").SetFontSize(12).SetFont(font));
            List sghazgorevlist = new List();
            sghazgorevlist.SetFont(font);
            sghazgorevlist.SetFontSize(12);
            for (int i = 0; i < hazirlik.gorevvesorumluluklar.Count; i++)
            {
                ListItem projlistitem = new ListItem(hazirlik.gorevvesorumluluklar[i]);
                sghazgorevlist.Add(projlistitem);
            }
            doc.Add(sghazgorevlist);

            doc.Add(new Paragraph("Sağlık ve Güvenlik Koordinatörü (Uygulama Aşaması)").SetFont(font).SetFontSize(12).SetBold());
            Table SaglikUygulamaTable = new Table(2);
            SaglikUygulamaTable.SetFont(font);
            SaglikUygulamaTable.SetFontSize(12);
            SaglikUygulamaTable.AddCell("Adı Soyadı:");
            SaglikUygulamaTable.AddCell(uygulama.adsoyad);
            SaglikUygulamaTable.AddCell("Mesleği:");
            SaglikUygulamaTable.AddCell(uygulama.Meslek);
            SaglikUygulamaTable.AddCell("İletişim Bilgileri:");
            SaglikUygulamaTable.AddCell(uygulama.iletisim);

            doc.Add(SaglikUygulamaTable);
            doc.Add(new Paragraph("Sağlık ve Güvenlik Koordinatörü (Uygulama Aşaması) Görev ve Sorumlulukları").SetFontSize(12).SetFont(font));
            List sguyggorevlist = new List();
            sguyggorevlist.SetFont(font);
            sguyggorevlist.SetFontSize(12);
            for (int i = 0; i < uygulama.gorevvesorumluluklar.Count; i++)
            {
                ListItem projlistitem = new ListItem(uygulama.gorevvesorumluluklar[i]);
                sguyggorevlist.Add(projlistitem);
            }
            doc.Add(sguyggorevlist);

            doc.Add(new Paragraph("Asıl İşveren/Ana Yüklenici İş Güvenliği Uzman(lar)ı").SetFont(font).SetFontSize(12).SetBold());
            for (int i = 0; i < asilisvuzmanlar.Count; i++)
            {
                Table tablo = new Table(2);
                tablo.SetFont(font);
                tablo.SetFontSize(12);
                tablo.AddCell("Adı Soyadı:");
                tablo.AddCell(asilisvuzmanlar[i].ad);
                tablo.AddCell("Sertifika No.:");
                tablo.AddCell(asilisvuzmanlar[i].sert);
                tablo.AddCell("İletişim Bilgileri:");
                tablo.AddCell(asilisvuzmanlar[i].iletişim);
                doc.Add(tablo);
                doc.Add(new Paragraph(asilisvuzmanlar[i].ad+ " Görev ve Sorumlulukları")).SetFontSize(12).SetFont(font);
                List uzmangorevlist = new List();
                uzmangorevlist.SetFontSize(12);
                uzmangorevlist.SetFont(font);
                for (int j = 0; j < asilisvuzmanlar[i].gorevvesorumluluklar.Count; j++)
                {
                    ListItem item = new ListItem(asilisvuzmanlar[i].gorevvesorumluluklar[j]);
                    uzmangorevlist.Add(item);
                }
                doc.Add(uzmangorevlist);

            }
            doc.Add(new Paragraph("Asıl İşveren/Ana Yüklenici İşyeri Hekim(ler)i").SetFont(font).SetFontSize(12).SetBold());
            for (int i = 0; i < asilisvhekimler.Count; i++)
            {
                Table tablo = new Table(2);
                tablo.SetFont(font);
                tablo.SetFontSize(12);
                tablo.AddCell("Adı Soyadı:");
                tablo.AddCell(asilisvhekimler[i].ad);
                tablo.AddCell("Sertifika No.:");
                tablo.AddCell(asilisvhekimler[i].sert);
                tablo.AddCell("İletişim Bilgileri:");
                tablo.AddCell(asilisvhekimler[i].iletişim);
                doc.Add(tablo);
                doc.Add(new Paragraph(asilisvhekimler[i].ad + " Görev ve Sorumlulukları")).SetFontSize(12).SetFont(font);
                List uzmangorevlist = new List();
                uzmangorevlist.SetFontSize(12);
                uzmangorevlist.SetFont(font);
                for (int j = 0; j < asilisvhekimler[i].gorevvesorumluluklar.Count; j++)
                {
                    ListItem item = new ListItem(asilisvhekimler[i].gorevvesorumluluklar[j]);
                    uzmangorevlist.Add(item);
                }
                doc.Add(uzmangorevlist);

            }
            
            doc.Add(new Paragraph("Çalışan Temsilcileri").SetFont(font).SetFontSize(12).SetBold());
            for (int i = 0; i < calisantemsilciler.Count; i++)
            {
                Table tablo = new Table(2);
                tablo.SetFont(font);
                tablo.SetFontSize(12);
                tablo.AddCell("Adı Soyadı:");
                tablo.AddCell(calisantemsilciler[i].ad);
                tablo.AddCell("Görevi:");
                tablo.AddCell(calisantemsilciler[i].gorevi);
                tablo.AddCell("İletişim Bilgileri:");
                tablo.AddCell(calisantemsilciler[i].iletişim);
                doc.Add(tablo);
                doc.Add(new Paragraph(calisantemsilciler[i].ad + " Görev ve Sorumlulukları")).SetFontSize(12).SetFont(font);
                List uzmangorevlist = new List();
                uzmangorevlist.SetFontSize(12);
                uzmangorevlist.SetFont(font);
                for (int j = 0; j < calisantemsilciler[i].gorevvesorumluluklar.Count; j++)
                {
                    ListItem item = new ListItem(calisantemsilciler[i].gorevvesorumluluklar[j]);
                    uzmangorevlist.Add(item);
                }
                doc.Add(uzmangorevlist);

            }
            doc.Add(new AreaBreak(iText.Layout.Properties.AreaBreakType.NEXT_PAGE));
            doc.Add(new Paragraph("3.2 İSG Organizasyon Şeması").SetFont(font).SetFontSize(12).SetBold());
            Image isgsema = new Image(ImageDataFactory.Create(Proje.isgorganizasyonsemasi));
            doc.Add(isgsema);
            doc.Close();


        }

        internal static void Bolum4Yazdir(string fileName)
        {
            PdfWriter pdfyazici = new PdfWriter(fileName);
            PdfDocument pdf = new PdfDocument(pdfyazici);
            Document doc = new Document(pdf, PageSize.A4);
            doc.SetMargins(40, 60, 30, 30);
            doc.SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED);
            PdfFont font = PdfFontFactory.CreateFont("C:\\Windows\\Fonts\\times.ttf", "windows-1254", true);


            doc.Add(new Paragraph("4. İŞLERİN YÖNETİMİ").SetFont(font).SetFontSize(24));

            doc.Add(new Paragraph("4.1 İş Akış Planı ").SetFont(font).SetFontSize(12).SetBold());

            Table işakışplanıtablosu = new Table(4);
            işakışplanıtablosu.SetFont(font);
            işakışplanıtablosu.SetFontSize(12);
            işakışplanıtablosu.AddCell("Yapılacak İş");
            işakışplanıtablosu.AddCell("Süresi");
            işakışplanıtablosu.AddCell("Başlangıç Tarihi");
            işakışplanıtablosu.AddCell("Bitiş Tarihi");
            for (int i = 0; i < Proje.plan.yapilacakisler.Count; i++)
            {
                işakışplanıtablosu.AddCell(Proje.plan.yapilacakisler[i].isinadi);
                işakışplanıtablosu.AddCell((Proje.plan.yapilacakisler[i].bitis- Proje.plan.yapilacakisler[i].baslangic).Days+" Gün" );
                işakışplanıtablosu.AddCell(Proje.plan.yapilacakisler[i].baslangic.ToShortDateString());
                işakışplanıtablosu.AddCell(Proje.plan.yapilacakisler[i].bitis.ToShortDateString());

            }
            doc.Add(işakışplanıtablosu);

            doc.Add(new Paragraph("4.2 Çalışma Yöntemleri, Ekipman ve Eğitimli Personel İhtiyacının Belirlenmesi ").SetFont(font).SetFontSize(12).SetBold());

            for (int i = 0; i < Proje.plan.yapilacakisler.Count; i++)
            {
                doc.Add(new Paragraph("Yapılacak İş: " +Proje.plan.yapilacakisler[i].isinadi).SetBold().SetFont(font).SetFontSize(12));
                doc.Add(new Paragraph("Çalışma Yöntemi").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER).SetBold().SetFont(font).SetFontSize(12));
                doc.Add(new Paragraph("Teknik Açıklama ve Gereklilikler").SetBold().SetFont(font).SetFontSize(12).SetUnderline());
                doc.Add(new Paragraph("Yapım Tekniği ve Teknolojisi").SetItalic().SetFont(font).SetFontSize(12));
                List yapımtekniklist = new List();
                yapımtekniklist.SetFont(font);
                yapımtekniklist.SetFontSize(12);

                for (int j = 0; j < Proje.plan.yapilacakisler[i].yontem.yapımtekniği.Count; j++)
                {
                    ListItem item = new ListItem(Proje.plan.yapilacakisler[i].yontem.yapımtekniği[j]);
                    yapımtekniklist.Add(item);
                }
                doc.Add(yapımtekniklist);
                doc.Add(new Paragraph("İş Ekipmanı Kullanımı").SetItalic().SetFont(font).SetFontSize(12));
                List isekipmanlist = new List();
                isekipmanlist.SetFont(font);
                isekipmanlist.SetFontSize(12);

                for (int j = 0; j < Proje.plan.yapilacakisler[i].yontem.işekipmanikullanimi.Count; j++)
                {
                    ListItem item = new ListItem(Proje.plan.yapilacakisler[i].yontem.işekipmanikullanimi[j]);
                    isekipmanlist.Add(item);
                }
                doc.Add(isekipmanlist);
                doc.Add(new Paragraph("Kimyasal Madde Kullanımı").SetItalic().SetFont(font).SetFontSize(12));
                List kimyasallist = new List();
                kimyasallist.SetFont(font);
                kimyasallist.SetFontSize(12);

                for (int j = 0; j < Proje.plan.yapilacakisler[i].yontem.kimyasalmaddekullanimi.Count; j++)
                {
                    ListItem item = new ListItem(Proje.plan.yapilacakisler[i].yontem.kimyasalmaddekullanimi[j]);
                    kimyasallist.Add(item);
                }
                doc.Add(kimyasallist);
                doc.Add(new Paragraph("Çalışma Alanına Erişim").SetBold().SetFont(font).SetFontSize(12).SetUnderline());
                List calismalist = new List();
                calismalist.SetFont(font);
                calismalist.SetFontSize(12);

                for (int j = 0; j < Proje.plan.yapilacakisler[i].yontem.calismaalaninaerisim.Count; j++)
                {
                    ListItem item = new ListItem(Proje.plan.yapilacakisler[i].yontem.calismaalaninaerisim[j]);
                    calismalist.Add(item);
                }
                doc.Add(calismalist);
                doc.Add(new Paragraph("Malzemelerin Taşınması").SetBold().SetFont(font).SetFontSize(12).SetUnderline());
                List malzemelist = new List();
                malzemelist.SetFont(font);
                malzemelist.SetFontSize(12);

                for (int j = 0; j < Proje.plan.yapilacakisler[i].yontem.malzemelerintasinmasi.Count; j++)
                {
                    ListItem item = new ListItem(Proje.plan.yapilacakisler[i].yontem.malzemelerintasinmasi[j]);
                    malzemelist.Add(item);
                }
                doc.Add(malzemelist);

                Table calismayontemTablo = new Table(3);
                calismayontemTablo.SetFontSize(12);
                calismayontemTablo.SetFont(font);
                calismayontemTablo.AddCell("İş Ekipmanı");
                calismayontemTablo.AddCell("Kullanılacak Kimyasallar");
                calismayontemTablo.AddCell("Eğitimli Personel İhtiyacı");
                List isekipmanlist2 = new List();
                isekipmanlist2.SetFont(font);
                isekipmanlist2.SetFontSize(12);
                for (int k = 0; k < Proje.plan.yapilacakisler[i].yontem.isekipmani.Count; k++)
                {
                    ListItem item = new ListItem(Proje.plan.yapilacakisler[i].yontem.isekipmani[k]);
                    isekipmanlist2.Add(item);
                }
                calismayontemTablo.AddCell(isekipmanlist2);
                List kimyasallist2 = new List();
                kimyasallist2.SetFont(font);
                kimyasallist2.SetFontSize(12);
                for (int k = 0; k < Proje.plan.yapilacakisler[i].yontem.kullanilacakkimyasallar.Count; k++)
                {
                    ListItem item = new ListItem(Proje.plan.yapilacakisler[i].yontem.kullanilacakkimyasallar[k]);
                    kimyasallist2.Add(item);
                }
                calismayontemTablo.AddCell(kimyasallist2);
                List egitimlist = new List();
                egitimlist.SetFont(font);
                egitimlist.SetFontSize(12);
                for (int k = 0; k < Proje.plan.yapilacakisler[i].yontem.egitimlipersonelihtiyaci.Count; k++)
                {
                    ListItem item = new ListItem(Proje.plan.yapilacakisler[i].yontem.egitimlipersonelihtiyaci[k]);
                    egitimlist.Add(item);
                }
                calismayontemTablo.AddCell(egitimlist);
                doc.Add(calismayontemTablo);


            }

            
            doc.Close();
        }

        internal static void Bolum6Yazdir(string fileName)
        {
            PdfWriter pdfyazici = new PdfWriter(fileName);
            PdfDocument pdf = new PdfDocument(pdfyazici);
            Document doc = new Document(pdf, PageSize.A4);
            doc.SetMargins(40, 60, 30, 30);
            doc.SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED);
            PdfFont font = PdfFontFactory.CreateFont("C:\\Windows\\Fonts\\times.ttf", "windows-1254", true);


            doc.Add(new Paragraph("5. ŞANTİYE KURALLARI").SetFont(font).SetFontSize(24));

            List santiyeliste = new List();
            santiyeliste.SetFont(font);
            santiyeliste.SetFontSize(12);
            for (int i = 0; i < Proje.kurallar.kurallar.Count; i++)
            {
                ListItem item = new ListItem(Proje.kurallar.kurallar[i]);
                santiyeliste.Add(item);
            }
            doc.Add(santiyeliste);
            doc.Add(new Paragraph("Ziyaretçilerle ilgili prosedürler").SetFont(font).SetFontSize(12).SetBold());
            List ziyaretciliste = new List();
            ziyaretciliste.SetFont(font);
            ziyaretciliste.SetFontSize(12);
            for (int i = 0; i < Proje.kurallar.ziyaretciprosedur.Count; i++)
            {
                ListItem item = new ListItem(Proje.kurallar.ziyaretciprosedur[i]);
                ziyaretciliste.Add(item);
            }
            doc.Add(ziyaretciliste);
            doc.Close();
        }

        internal static void Bolum5Yazdir(string fileName)
        {


            PdfWriter pdfyazici = new PdfWriter(fileName);
            PdfDocument pdf = new PdfDocument(pdfyazici);
            Document doc = new Document(pdf, PageSize.A4);
            doc.SetMargins(40, 60, 30, 30);
            doc.SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED);
            PdfFont font = PdfFontFactory.CreateFont("C:\\Windows\\Fonts\\times.ttf", "windows-1254", true);


            doc.Add(new Paragraph("5. RİSKLERİN VE KONTROL TEDBİRLERİNİN BELİRLENMESİ").SetFont(font).SetFontSize(24));

            doc.Add(new Paragraph("5.1 Yapı Sahasının Geneline Etki Eden Riskler ve Kontrol Tedbirlerinin Belirlenmesi ").SetFont(font).SetFontSize(12).SetBold());
            Table yapisahasınaozgutablo = new Table(3);
            yapisahasınaozgutablo.SetFont(font);
            yapisahasınaozgutablo.SetFontSize(12);
            Cell baslik = new Cell(1, 3);
            baslik.SetFont(font);
            baslik.SetFontSize(12);
            baslik.SetBold().SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
            baslik.Add("Yapı Sahasının Geneline Özgü");
            yapisahasınaozgutablo.AddCell(baslik);
            
            yapisahasınaozgutablo.AddCell("Tehlike Kaynağı");
            yapisahasınaozgutablo.AddCell("Riskler");
            yapisahasınaozgutablo.AddCell("Kontrol Önlemi");

            for (int i = 0; i < Proje.yapisahasiningenelozgutehlikeler.Count; i++)
            {
                yapisahasınaozgutablo.AddCell(Proje.yapisahasiningenelozgutehlikeler[i].tehlikekayangi);
                yapisahasınaozgutablo.AddCell(Proje.yapisahasiningenelozgutehlikeler[i].risk);
                yapisahasınaozgutablo.AddCell(Proje.yapisahasiningenelozgutehlikeler[i].onlem);

            }
            Cell baslik2 = new Cell(1, 3);
            baslik2.SetFont(font);
            baslik2.SetFontSize(12);
            baslik2.SetBold().SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
            baslik2.Add("Biyolojik");
            yapisahasınaozgutablo.AddCell(baslik2);

            yapisahasınaozgutablo.AddCell("Tehlike Kaynağı");
            yapisahasınaozgutablo.AddCell("Riskler");
            yapisahasınaozgutablo.AddCell("Kontrol Önlemi");
            for (int i = 0; i < Proje.biyolojiktehlikeler.Count; i++)
            {
                yapisahasınaozgutablo.AddCell(Proje.biyolojiktehlikeler[i].tehlikekayangi);
                yapisahasınaozgutablo.AddCell(Proje.biyolojiktehlikeler[i].risk);
                yapisahasınaozgutablo.AddCell(Proje.biyolojiktehlikeler[i].onlem);

            }
            doc.Add(yapisahasınaozgutablo);
            doc.Add(new Paragraph("5.2 İşle Alakalı Muhtemel Riskler ve Kontrol Tedbirlerinin Belirlenmesi ").SetFont(font).SetFontSize(12).SetBold());
            for (int i = 0; i < Proje.plan.yapilacakisler.Count; i++)
            {
                doc.Add(new Paragraph("Yapılacak İş: " + Proje.plan.yapilacakisler[i].isinadi).SetFont(font).SetFontSize(12).SetBold());
                Table fizikseltablo = new Table(3);
                fizikseltablo.SetFontSize(12).SetFont(font);
                Cell baslikfiziksel = new Cell(1, 3);
                baslikfiziksel.Add("Fiziksel");
                baslikfiziksel.SetFont(font).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                baslikfiziksel.SetFontSize(12);
                baslikfiziksel.SetBold();
                fizikseltablo.AddCell(baslikfiziksel);
                fizikseltablo.AddCell("Tehlike Kaynağı");
                fizikseltablo.AddCell("Riskler");
                fizikseltablo.AddCell("Kontrol Önlemi");
                for (int j = 0; j < Proje.plan.yapilacakisler[i].fizikseltehlikeler.Count; j++)
                {
                    fizikseltablo.AddCell(Proje.plan.yapilacakisler[i].fizikseltehlikeler[j].tehlikekayangi);
                    fizikseltablo.AddCell(Proje.plan.yapilacakisler[i].fizikseltehlikeler[j].risk);
                    fizikseltablo.AddCell(Proje.plan.yapilacakisler[i].fizikseltehlikeler[j].onlem);

                }
                doc.Add(fizikseltablo);
                Table kimyasaltablo = new Table(3);
                kimyasaltablo.SetFontSize(12).SetFont(font);
                Cell baslikkimyasal = new Cell(1, 3);
                baslikkimyasal.Add("Kimyasal");
                baslikkimyasal.SetFont(font).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                baslikkimyasal.SetFontSize(12);
                baslikkimyasal.SetBold();
                kimyasaltablo.AddCell(baslikkimyasal);
                kimyasaltablo.AddCell("Tehlike Kaynağı");
                kimyasaltablo.AddCell("Riskler");
                kimyasaltablo.AddCell("Kontrol Önlemi");
                for (int j = 0; j < Proje.plan.yapilacakisler[i].kimyasaltehlikeler.Count; j++)
                {
                    kimyasaltablo.AddCell(Proje.plan.yapilacakisler[i].kimyasaltehlikeler[j].tehlikekayangi);
                    kimyasaltablo.AddCell(Proje.plan.yapilacakisler[i].kimyasaltehlikeler[j].risk);
                    kimyasaltablo.AddCell(Proje.plan.yapilacakisler[i].kimyasaltehlikeler[j].onlem);

                }
                doc.Add(kimyasaltablo);
            }
            doc.Add(new Paragraph("5.3	Zaman ve Mekân Açısından Çakışan İşlerden Kaynaklanan Riskler").SetFont(font).SetFontSize(12).SetBold());
            

            Table cakisanislerTablosu = new Table(6);
            cakisanislerTablosu.SetFont(font);
            cakisanislerTablosu.SetFontSize(12);
            cakisanislerTablosu.AddCell("Çakışan İşler");
            cakisanislerTablosu.AddCell("Çakışma Başlangıç Tarihi");
            cakisanislerTablosu.AddCell("Çakışma Bitiş Tarihi");
            cakisanislerTablosu.AddCell("Risk");
            cakisanislerTablosu.AddCell("Etkilenen çalışanlar/Etki altındaki bölge");
            cakisanislerTablosu.AddCell("Kontrol Önlemleri");

            for (int i = 0; i < Proje.cakisanisler.Count; i++)
            {
                cakisanislerTablosu.AddCell(Proje.cakisanisler[i].iş1.isinadi + " - " + Proje.cakisanisler[i].iş2.isinadi);
                cakisanislerTablosu.AddCell(Proje.cakisanisler[i].çakışmabaşlangıç.ToShortDateString());
                cakisanislerTablosu.AddCell(Proje.cakisanisler[i].çakışmabitiş.ToShortDateString());
                cakisanislerTablosu.AddCell(Proje.cakisanisler[i].risk);
                cakisanislerTablosu.AddCell(Proje.cakisanisler[i].Etkilenenler);
                cakisanislerTablosu.AddCell(Proje.cakisanisler[i].kontrol);

            }
            doc.Add(cakisanislerTablosu);
            doc.Add(new Paragraph("5.4	Üçüncü taraflara olan etkisinin değerlendirilmesi ").SetFont(font).SetFontSize(12).SetBold());

            Table ucuncuTablo = new Table(3);
            ucuncuTablo.SetFont(font);
            ucuncuTablo.SetFontSize(12);
            ucuncuTablo.AddCell("Risk");
            ucuncuTablo.AddCell("Etki altındaki bölge/tesis");
            ucuncuTablo.AddCell("Kontrol Tedbirleri");
            for (int i = 0; i < Proje.ucuncutaraflar.Count; i++)
            {
                ucuncuTablo.AddCell(Proje.ucuncutaraflar[i].risk);
                ucuncuTablo.AddCell(Proje.ucuncutaraflar[i].risk);
                ucuncuTablo.AddCell(Proje.ucuncutaraflar[i].risk);

            }
            doc.Add(ucuncuTablo);

           
            doc.Close();

        }
    }
}
