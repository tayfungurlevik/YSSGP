using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YSSGP.Sınıflar
{
    public class Ek_5
    {
        public string YerinTarifi { get; set; }
        public string SınırlıGeçişSebebi { get; set; }
        public string GirişeİzinliKişi { get; set; }
        public string Prosedür { get; set; }
       

        public override string ToString()
        {
            string sonuc = "";

            sonuc += YerinTarifi + Environment.NewLine;
            sonuc += SınırlıGeçişSebebi + Environment.NewLine;
            sonuc += GirişeİzinliKişi + Environment.NewLine;
            sonuc += Prosedür + Environment.NewLine;
            

            return sonuc;
        }
    }
}