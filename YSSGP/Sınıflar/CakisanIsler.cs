using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using YSSGP.Sınıflar;
namespace YSSGP.Sınıflar
{
    public class CakisanIsler
    {
        
        public Is iş1;
        
        public Is iş2;
        public DateTime çakışmabaşlangıç;
        public DateTime çakışmabitiş;
        public string risk;
        public string Etkilenenler;
        public string kontrol;
        public override string ToString()
        {
            string sonuc = "Begin İş 1"+Environment.NewLine;
            sonuc += iş1.ToString() + Environment.NewLine;
            sonuc += "End İş 1" + Environment.NewLine;
            sonuc += "Begin İş 2" + Environment.NewLine;
            sonuc += iş2.ToString() + Environment.NewLine;
            sonuc += "End İş 2" + Environment.NewLine;
            sonuc += çakışmabaşlangıç.ToShortDateString() + Environment.NewLine;
            sonuc += çakışmabitiş.ToShortDateString() + Environment.NewLine;
            sonuc += risk + Environment.NewLine;
            sonuc += Etkilenenler + Environment.NewLine;
            sonuc += kontrol;
            return sonuc;
        }
        public CakisanIsler()
        {

        }
        public void Serilestir(string path)
        {

        }
    }
}
