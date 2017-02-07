using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YSSGP.Sınıflar
{
    public class Is
    {
        public string isinadi;
        public DateTime baslangic;
        public DateTime bitis;
        public CalismaYontemi yontem;
        public List<Tehlike> fizikseltehlikeler;
        public List<Tehlike> kimyasaltehlikeler;
        public List<Is> cakistigiIs;
        public Is()
        {
            yontem = new CalismaYontemi();
            fizikseltehlikeler = new List<Tehlike>();
            kimyasaltehlikeler = new List<Tehlike>();
            cakistigiIs = new List<Is>();
        }
        public override string ToString()
        {
            string sonuc = isinadi + Environment.NewLine;
            sonuc += baslangic.ToShortDateString() + Environment.NewLine;
            sonuc += bitis.ToShortDateString() + Environment.NewLine;
            sonuc += yontem.ToString()+Environment.NewLine;
            sonuc += "Begin Fiziksel Tehlikeler" + Environment.NewLine;
            for (int i = 0; i < fizikseltehlikeler.Count; i++)
            {
                sonuc += fizikseltehlikeler[i].ToString()+Environment.NewLine;
            }
            sonuc += "End Fiziksel Tehlikeler"+Environment.NewLine;
            sonuc += "Begin Kimyasal Tehlikeler" + Environment.NewLine;

            for (int i = 0; i < kimyasaltehlikeler.Count; i++)
            {
                sonuc += kimyasaltehlikeler[i].ToString() + Environment.NewLine;
            }
            sonuc += "End Kimyasal Tehlikeler" ;
           // sonuc += "Begin Çakışan İşler" + Environment.NewLine;
            //for (int i = 0; i < cakistigiIs.Count; i++)
           // {
            //    sonuc += cakistigiIs[i].ToString() + Environment.NewLine;
            //}
           // sonuc += "End Çakışan İşler";
            return sonuc;
        }
        public void Serilestir(string path)
        {

        }
    }
}
