using System;

namespace YSSGP.Sınıflar
{
    public class ProjeBilgileri
    {
        public string projeAdi;
        public string isinSahibi;
        public string adres;
        public string tanim;
        public DateTime baslangicTarih;
        public DateTime bitisTarih;
        public ProjeBilgileri()
        {
            baslangicTarih = DateTime.Now;
            bitisTarih = DateTime.Now;
        }
        public override string ToString()
        {
            string sonuc = "";
            sonuc += projeAdi + System.Environment.NewLine;
            sonuc += adres + System.Environment.NewLine;
            sonuc += tanim + System.Environment.NewLine;
            sonuc += baslangicTarih.ToShortDateString() + System.Environment.NewLine;
            sonuc += bitisTarih.ToShortDateString();
            return sonuc;
        }

    }
}