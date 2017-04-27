using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YSSGP.Sınıflar
{
    public class Ek_3
    {
        public string İşEkipmanı { get; set; }
        public string İşEkipmanıSahibi { get; set; }
        public string KişilerinYetkinliği { get; set; }
        public string Gereklilik { get; set; }

        public override string ToString()
        {
            string sonuc = "";
            
            sonuc += İşEkipmanı + Environment.NewLine;
            sonuc += İşEkipmanıSahibi + Environment.NewLine;
            sonuc += KişilerinYetkinliği + Environment.NewLine;
            sonuc += Gereklilik + Environment.NewLine;
            
            return sonuc;
        }
    }
}
