using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YSSGP.Sınıflar
{
    public class SGKoordinator_Hazirlik:Personel
    {
        public SGKoordinator_Hazirlik()
        {
            gorevvesorumluluklar = new List<string>();
            gorevvesorumluluklar.Add("Yapı işinin, aynı anda veya birbiri ardına gerçekleşen farklı unsur ve aşamalarını planlamak amacıyla mimari, teknik ve organizasyonel konulara ilişkin karar alırken ve işin ya da iş aşamalarının tamamlanması için ilgili meslek disiplinindeki kriterler de dikkate alınarak gereken süreyi hesaplarken İş Sağlığı ve Güvenliği Kanununun 5 inci maddesinde belirtilen risklerden korunma ilkelerini göz önünde bulundurulmasını koordine etmek,");
            gorevvesorumluluklar.Add("Sağlık ve güvenlik planını hazırlar veya hazırlanmasını sağlamak,");
            gorevvesorumluluklar.Add("Proje süresince, birbirini takip eden veya daha sonra yapılacak işler sırasında dikkate alınmak üzere sağlık ve güvenlik bilgilerini içeren sağlık ve güvenlik dosyası hazırlamak");
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
