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

        internal static void ProjeBilgileriYazdir(string dosya,ProjeBilgileri projbilgi)
        {
            PdfWriter pdfyazici = new PdfWriter(dosya);
            PdfDocument pdf = new PdfDocument(pdfyazici);
            Document doc = new Document(pdf, PageSize.A4);
            doc.SetMargins(20, 20, 20, 20);
            
            PdfFont font = PdfFontFactory.CreateFont("C:\\Windows\\Fonts\\times.ttf", "windows-1254", true);


            doc.Add(new Paragraph("2. Yönetimin Taahhüdü").SetFont(font).SetFontSize(24));
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
            doc.Close();
        }
    }
}
