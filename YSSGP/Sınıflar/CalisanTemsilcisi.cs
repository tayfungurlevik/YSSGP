using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YSSGP.Sınıflar
{
    public class CalisanTemsilcisi:ISGPersonel
    {
        public string gorevi;
        public  CalisanTemsilcisi()
        {
            gorevvesorumluluklar = new List<string>();
            
            gorevvesorumluluklar.Add("İş sağlığı ve güvenliği ile ilgili çalışmalara katılmak");
            gorevvesorumluluklar.Add("İş sağlığı ve güvenliği ile ilgili çalışmaları izlemek");
            gorevvesorumluluklar.Add("Tehlike kaynağının yok edilmesi veya tehlikeden kaynaklanan riskin azaltılması için tedbir alınmasını istemek");
            gorevvesorumluluklar.Add("İş sağlığı ve güvenliği ile ilgili tekliflerde bulunmak ve benzeri konularda çalışanları temsil etmek");
            


        }
        public override string ToString()
        {
            string sonuc = ad + Environment.NewLine;
            sonuc += this.tc + Environment.NewLine;
            
            sonuc += this.gorevi + Environment.NewLine;
            sonuc += this.iletişim + Environment.NewLine;

            sonuc += "begin gorev" + Environment.NewLine;

            for (int i = 0; i < this.gorevvesorumluluklar.Count; i++)
            {
                sonuc += gorevvesorumluluklar[i] + Environment.NewLine;
            }
            sonuc += "end gorev";
            return sonuc;
        }
    }
}
