using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YSSGP.Sınıflar
{
    public class Ek_4
    {
        public string KKD { get; set; }
        public string Kategori { get; set; }
        public string BakımSüresi { get; set; }
        public string MakSüre { get; set; }
        public string Standart { get; set; }

        public override string ToString()
        {
            string sonuc = "";

            sonuc += KKD + Environment.NewLine;
            sonuc += Kategori + Environment.NewLine;
            sonuc += BakımSüresi + Environment.NewLine;
            sonuc += MakSüre + Environment.NewLine;
            sonuc += Standart + Environment.NewLine;

            return sonuc;
        }
    }
}