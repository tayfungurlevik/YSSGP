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
            doc.SetMargins(20, 20, 20, 20);
            //baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\Arial.ttf", "windows-1254", true);
            PdfFont font = PdfFontFactory.CreateFont("C:\\Windows\\Fonts\\times.ttf", "windows-1254",true);


            doc.Add(new Paragraph("1. Yönetimin Taahhüdü").SetFont(font).SetFontSize(24));
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


            doc.Add(new Paragraph("2. Proje Bilgileri").SetFont(font).SetFontSize(24));
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
                doc.Add(new Paragraph((i + 1) + ". Kendi Nam ve Hesabına Çalışanlan").SetFont(font).SetFontSize(12));
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
    }
}
