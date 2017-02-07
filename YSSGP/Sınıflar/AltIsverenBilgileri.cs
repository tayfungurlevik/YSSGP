using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YSSGP.Sınıflar
{
    public class AltIsverenBilgileri
    {
        public string altisveren;
        public string sgk;
        public string adres;
        public string isler;
        public DateTime baslangictarih;
        public DateTime bitistarih;
        public string isguzmanad;
        public string isguzmansert;
        public string hekimad;
        public string hekimsert;
        public List<string> gorevvesorumluluklar;
        public override string ToString()
        {
            string sonuc = altisveren + Environment.NewLine;
            sonuc += sgk + Environment.NewLine;
            sonuc += adres + Environment.NewLine;
            sonuc += isler + Environment.NewLine;
            sonuc += baslangictarih.ToShortDateString() + Environment.NewLine;
            sonuc += bitistarih.ToShortDateString() + Environment.NewLine;
            sonuc += isguzmanad + Environment.NewLine;
            sonuc += isguzmansert = Environment.NewLine;
            sonuc += hekimad + Environment.NewLine;
            sonuc += hekimsert + Environment.NewLine;
            sonuc += "begin gorev"+Environment.NewLine;
            for (int i = 0; i < gorevvesorumluluklar.Count; i++)
            {
                sonuc += gorevvesorumluluklar[i] + Environment.NewLine;
            }
            sonuc += "end gorev";
            return sonuc;
        }
        //public string toHTML()
        //{
        //    string sonuc = "";
        //    sonuc+=
        //    return sonuc;
        //}
        public AltIsverenBilgileri()
        {
            gorevvesorumluluklar = new List<string>();
            gorevvesorumluluklar.Add("İşveren, çalışanların işle ilgili sağlık ve güvenliğini sağlamak,");
            gorevvesorumluluklar.Add("Mesleki risklerin önlenmesi, eğitim ve bilgi verilmesi dâhil her türlü tedbirin alınması, organizasyonun yapılması, gerekli araç ve gereçlerin sağlanması, sağlık ve güvenlik tedbirlerinin değişen şartlara uygun hale getirilmesi ve mevcut durumun iyileştirilmesi için çalışmalar yapmak,");
            gorevvesorumluluklar.Add("İşyerinde alınan iş sağlığı ve güvenliği tedbirlerine uyulup uyulmadığını izlemek, denetlemek ve uygunsuzlukların giderilmesini sağlamak,");
            gorevvesorumluluklar.Add("Risk değerlendirmesi yapmak veya yaptırmak,");
            gorevvesorumluluklar.Add("Çalışana görev verirken, çalışanın sağlık ve güvenlik yönünden işe uygunluğunu göz önüne almak,");
            gorevvesorumluluklar.Add("Yeterli bilgi ve talimat verilenler dışındaki çalışanların hayati ve özel tehlike bulunan yerlere girmemesi için gerekli tedbirleri almak,");
            gorevvesorumluluklar.Add("Yapı alanının düzenli tutulmasını ve yeterli temizlikte olmasını sağlamak,");
            gorevvesorumluluklar.Add("Yapı alanındaki çalışma yerlerinin seçiminde; buralara ulaşımın nasıl sağlanacağının ve ekipman, hareket ve geçişler için alan veya yolların belirlenmesini sağlamak,");
            gorevvesorumluluklar.Add("Malzemenin kullanım ve taşıma şartlarının düzenlenmesini sağlamak,");
            gorevvesorumluluklar.Add("Tesis ve ekipmanın kullanılmaya başlamadan önce ve periyodik olarak teknik bakım ve kontrollerinin yapılmasını sağlamak,");
            gorevvesorumluluklar.Add("Çeşitli malzemeler ve özellikle tehlikeli malzeme ve maddeler için uygun depolama alanları ayrılmasını ve bu alanların sınırlarının belirlenmesini sağlamak,");
            gorevvesorumluluklar.Add("Tehlikeli malzemelerin kullanımı ile uzaklaştırılma koşullarının düzenlenmesini sağlamak,");
            gorevvesorumluluklar.Add("Atık ve artıkların depolanmasını, atılmasını veya uzaklaştırılmasını sağlamak,");
            gorevvesorumluluklar.Add("Çeşitli işler veya işin aşamaları için öngörülen sürelerin yapı alanındaki işin durumuna göre yeniden belirlenmesini sağlamak,");
            gorevvesorumluluklar.Add("Asıl işveren, diğer alt işverenler ve kendi nam ve hesabına çalışanlar ile işbirliğini halinde çalışmak,");
            gorevvesorumluluklar.Add("Yapı alanındaki veya yakınındaki endüstriyel faaliyetler ile etkileşimin dikkate alınmasını sağlamak,");
            gorevvesorumluluklar.Add("Kişisel Koruyucu Donanımların İşyerlerinde Kullanılması Hakkında Yönetmeliğe ve uyumlaştırılmış ulusal standartlara uygun kişisel koruyucu donanımların bulundurulmasını ve çalışanlar tarafından kullanılmasını sağlamak,,");
            gorevvesorumluluklar.Add("Yapı İşlerinde İş Sağlığı ve Güvenliği Yönetmeliğinin Ek-4’ünde belirtilen asgari şartları dikkate alarak uygun tedbirleri almak,");
            gorevvesorumluluklar.Add("Sağlık ve güvenlikle ilgili konularda sağlık ve güvenlik koordinatörlerinin uyarı, tespit ve talimatlarını dikkate almak.");
        }
    }
}
