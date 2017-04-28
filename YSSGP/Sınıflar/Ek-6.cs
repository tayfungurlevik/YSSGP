using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YSSGP.Sınıflar
{
    public class Ek_6
    {
        public string EğitimeKatılacaklar { get; set; }
        public string EğitiminKonusu { get; set; }
        public string HedefveAmaç { get; set; }
        public string EğitiminSüresi { get; set; }
        public DateTime eğitimBaslangic { get; set; }

        public DateTime eğitimBitis { get; set; }
        public override string ToString()
        {
            string sonuc = "";

            sonuc += EğitimeKatılacaklar + Environment.NewLine;
            sonuc += EğitiminKonusu + Environment.NewLine;
            sonuc += HedefveAmaç + Environment.NewLine;
            sonuc += EğitiminSüresi + Environment.NewLine;
            sonuc += eğitimBaslangic.ToShortDateString() + Environment.NewLine;
            sonuc += eğitimBitis.ToShortDateString() + Environment.NewLine;
            

            return sonuc;
        }
    }
}