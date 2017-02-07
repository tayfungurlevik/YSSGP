using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace YSSGP.Sınıflar
{
    [XmlRoot]
    public class IsverenBilgileri
    {
        #region parameters
    
        public string isveren;
   
        public string unvan;

        public string sgksicilno;
      
        public string adres;
 
        public string telfaks;
      
        public string web;
       
        public string sorumlufirmalar;
      
        public List<string> gorevveSorumluluklar;
        #endregion
        public override string ToString()
        {
            string sonuc = "";
            sonuc += isveren + Environment.NewLine;
            sonuc += unvan + Environment.NewLine;
            sonuc += sgksicilno + Environment.NewLine;
            sonuc += adres + Environment.NewLine;
            sonuc += telfaks + Environment.NewLine;
            sonuc += web + Environment.NewLine;
            sonuc += sorumlufirmalar + Environment.NewLine;
            sonuc += "begin gorevler"+Environment.NewLine;
            for (int i = 0; i < gorevveSorumluluklar.Count; i++)
            {
                sonuc += gorevveSorumluluklar[i] + Environment.NewLine;
            }
            sonuc += "end gorevler";
            return sonuc;
        }
        public IsverenBilgileri()
        {
            gorevveSorumluluklar = new List<string>();
            
            gorevveSorumluluklar.Add("Çalışanların işle ilgili sağlık ve güvenliğini sağlamak,");
            gorevveSorumluluklar.Add("Mesleki risklerin önlenmesi, eğitim ve bilgi verilmesi dâhil her türlü tedbirin alınması, organizasyonun yapılması, gerekli araç ve gereçlerin sağlanması, sağlık ve güvenlik tedbirlerinin değişen şartlara uygun hale getirilmesi ve mevcut durumun iyileştirilmesi için çalışmalar yapmak,");
            gorevveSorumluluklar.Add("İşyerinde alınan iş sağlığı ve güvenliği tedbirlerine uyulup uyulmadığını izlemek, denetlemek ve uygunsuzlukların giderilmesini sağlamak,");
            gorevveSorumluluklar.Add("Risk değerlendirmesi yapmak veya yaptırmak,");
            gorevveSorumluluklar.Add("Çalışana görev verirken, çalışanın sağlık ve güvenlik yönünden işe uygunluğunu göz önüne almak,");
            gorevveSorumluluklar.Add("Yeterli bilgi ve talimat verilenler dışındaki çalışanların hayati ve özel tehlike bulunan yerlere girmemesi için gerekli tedbirleri almak, ");
            gorevveSorumluluklar.Add("Yapı alanının düzenli tutulmasını ve yeterli temizlikte olmasını sağlamak,");
            gorevveSorumluluklar.Add("Yapı alanındaki çalışma yerlerinin seçiminde; buralara ulaşımın nasıl sağlanacağının ve ekipman, hareket ve geçişler için alan veya yolların belirlenmesini sağlamak,");
            gorevveSorumluluklar.Add("Malzemenin kullanım ve taşıma şartlarının düzenlenmesini sağlamak,");
            gorevveSorumluluklar.Add("Tesis ve ekipmanın kullanılmaya başlamadan önce ve periyodik olarak teknik bakım ve kontrollerinin yapılmasını sağlamak,");
            gorevveSorumluluklar.Add("Çeşitli malzemeler ve özellikle tehlikeli malzeme ve maddeler için uygun depolama alanları ayrılmasını ve bu alanların sınırlarının belirlenmesini sağlamak,");
            gorevveSorumluluklar.Add("Tehlikeli malzemelerin kullanımı ile uzaklaştırılma koşullarının düzenlenmesini sağlamak,");
            gorevveSorumluluklar.Add("Atık ve artıkların depolanmasını, atılmasını veya uzaklaştırılmasını sağlamak,");
            gorevveSorumluluklar.Add("Çeşitli işler veya işin aşamaları için öngörülen sürelerin yapı alanındaki işin durumuna göre yeniden belirlenmesini sağlamak,");
            gorevveSorumluluklar.Add("Alt işverenler ve kendi nam ve hesabına çalışanlar arasında işbirliğini sağlamak,");
            gorevveSorumluluklar.Add("Yapı alanındaki veya yakınındaki endüstriyel faaliyetler ile etkileşimin dikkate alınmasını sağlamak,");
            gorevveSorumluluklar.Add("Kişisel Koruyucu Donanımların İşyerlerinde Kullanılması Hakkında Yönetmeliğe ve uyumlaştırılmış ulusal standartlara uygun kişisel koruyucu donanımların bulundurulmasını ve çalışanlar tarafından kullanılmasını sağlamak,");
            gorevveSorumluluklar.Add("Yapı İşlerinde İş Sağlığı ve Güvenliği Yönetmeliğinin Ek-4’ünde belirtilen asgari şartları dikkate alarak uygun tedbirleri almak,");
            gorevveSorumluluklar.Add("Sağlık ve güvenlikle ilgili konularda sağlık ve güvenlik koordinatörlerinin uyarı, tespit ve talimatlarını dikkate almak");
            gorevveSorumluluklar.Add("Sağlık ve güvenlik konularında bir veya daha fazla sağlık ve güvenlik koordinatörü görevlendirmek,");
            gorevveSorumluluklar.Add("Yapı işine başlamadan önce projenin hazırlık aşamasında, sağlık ve güvenlik planını hazırlamak veya hazırlanmasını sağlamak,");
            gorevveSorumluluklar.Add("Yapı İşlerinde İş Sağlığı ve Güvenliği Yönetmeliği kapsamında bildirim yapılması gereken işlerde bildirimde bulunmak,");
        }
        

    }
}
