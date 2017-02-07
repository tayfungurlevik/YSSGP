using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YSSGP.Sınıflar
{
    public class ProjeSorumlusu:Personel
    {
        public ProjeSorumlusu()
        {
            gorevvesorumluluklar = new List<string>();
            gorevvesorumluluklar.Add("İşveren adına projenin hazırlanması, uygulanması ve uygulamanın kontrolünü yapmak,");
            gorevvesorumluluklar.Add("Sağlık ve güvenlik konularında bir veya daha fazla sağlık ve güvenlik koordinatörü görevlendirmek,");
            gorevvesorumluluklar.Add("Yapı işine başlamadan önce projenin hazırlık aşamasında, sağlık ve güvenlik planını hazırlamak veya hazırlanmasını sağlamak,");
            gorevvesorumluluklar.Add("Yapı İşlerinde İş Sağlığı ve Güvenliği Yönetmeliği kapsamında bildirim yapılması gereken işlerde bildirimde bulunmak,");
            gorevvesorumluluklar.Add("Yapı işinin, aynı anda veya birbiri ardına gerçekleşen farklı unsur ve aşamalarını planlamak amacıyla mimari, teknik ve organizasyonel konulara ilişkin karar alırken ve işin ya da iş aşamalarının tamamlanması için ilgili meslek disiplinindeki kriterler de dikkate alınarak gereken süreyi hesaplarken, İş Sağlığı ve Güvenliği Kanununun 5 inci maddesinde belirtilen risklerden korunma ilkelerini göz önünde bulundurmak,");
            
        }
        public override string ToString()
        {
            string sonuc = adsoyad + Environment.NewLine;
            sonuc += this.TCKimlikNo + Environment.NewLine;
            sonuc += this.Meslek + Environment.NewLine;
            sonuc += this.iletisim + Environment.NewLine;
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
