using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YSSGP.Sınıflar
{
   public  class ISGUzmani:ISGPersonel
    {
        public ISGUzmani()
        {
            gorevvesorumluluklar = new List<string>();
            gorevvesorumluluklar.Add("Görev aldığı işyerinde göreviyle ilgili mevzuat ve teknik gelişmeleri göz önünde bulundurarak iş sağlığı ve güvenliği ile ilgili eksiklik ve aksaklıkları, tedbir ve tavsiyeleri belirlemek ve işverene yazılı olarak bildirmek,");
            gorevvesorumluluklar.Add("Bildirilen eksiklik ve aksaklıkların acil durdurmayı gerektirmesi veya yangın, patlama, göçme, kimyasal sızıntı ve benzeri acil ve hayati tehlike arz etmesi, meslek hastalığına sebep olabilecek ortamların bulunmasına rağmen işveren tarafından gerekli tedbirlerin alınmaması hâlinde, bu durumu Bakanlığın yetkili birimine, varsa yetkili sendika temsilcisine, yoksa çalışan temsilcisine bildirmek,");
            gorevvesorumluluklar.Add("İş sağlığı ve güvenliği hizmetlerini ihmale mahal vermeden yürütmek");
            gorevvesorumluluklar.Add("İşyerinde yapılan çalışmalar ve yapılacak değişikliklerle ilgili olarak tasarım, makine ve diğer teçhizatın durumu, bakımı, seçimi ve kullanılan maddeler de dâhil olmak üzere işin planlanması, organizasyonu ve uygulanması, kişisel koruyucu donanımların seçimi, temini, kullanımı, bakımı, muhafazası ve test edilmesi konularının, iş sağlığı ve güvenliği mevzuatına ve genel iş güvenliği kurallarına uygun olarak sürdürülmesini sağlamak için işverene önerilerde bulunmak");
            gorevvesorumluluklar.Add("İşyerinde meydana gelen iş kazası ve meslek hastalıklarının nedenlerinin araştırılması ve tekrarlanmaması için alınacak önlemler konusunda çalışmalar yaparak işverene önerilerde bulunmak");
            gorevvesorumluluklar.Add("İşyerinde meydana gelen ancak ölüm ya da yaralanmaya neden olmayan, ancak çalışana, ekipmana veya işyerine zarar verme potansiyeli olan olayların nedenlerinin araştırılması konusunda çalışma yapmak ve işverene önerilerde bulunmak");
            gorevvesorumluluklar.Add("İş sağlığı ve güvenliği yönünden risk değerlendirmesi yapılmasıyla ilgili çalışmalara ve uygulanmasına katılmak, risk değerlendirmesi sonucunda alınması gereken sağlık ve güvenlik önlemleri konusunda işverene önerilerde bulunmak ve takibini yapmak");
            gorevvesorumluluklar.Add("Çalışma ortamının gözetiminin yapılması, işyerinde iş sağlığı ve güvenliği mevzuatı gereği yapılması gereken periyodik bakım, kontrol ve ölçümleri planlamak ve uygulamalarını kontrol etmek");
            gorevvesorumluluklar.Add("İşyerinde kaza, yangın veya patlamaların önlenmesi için yapılan çalışmalara katılmak, bu konuda işverene önerilerde bulunmak, uygulamaları takip etmek; doğal afet, kaza, yangın veya patlama gibi durumlar için acil durum planlarının hazırlanması çalışmalarına katılmak, ilgili periyodik eğitimlerin ve tatbikatların yapılmasını ve acil durum planı doğrultusunda hareket edilmesini izlemek ve kontrol etmek");
            gorevvesorumluluklar.Add("Çalışanların iş sağlığı ve güvenliği eğitimlerinin ilgili mevzuata uygun olarak planlanması konusunda çalışma yaparak işverenin onayına sunmak ve uygulamalarını yapmak veya kontrol etmek");
            gorevvesorumluluklar.Add("Çalışma ortamıyla ilgili iş sağlığı ve güvenliği çalışmaları ve çalışma ortamı gözetim sonuçlarının kaydedildiği yıllık değerlendirme raporunu işyeri hekimi ile işbirliği halinde EK-2’deki örneğine uygun olarak hazırlamak");
            gorevvesorumluluklar.Add("Çalışanlara yönelik bilgilendirme faaliyetlerini düzenleyerek işverenin onayına sunmak ve uygulamasını kontrol etmek");
            gorevvesorumluluklar.Add("Gerekli yerlerde kullanılmak amacıyla iş sağlığı ve güvenliği talimatları ile çalışma izin prosedürlerini hazırlayarak işverenin onayına sunmak ve uygulamasını kontrol etmek");
            gorevvesorumluluklar.Add("Bakanlıkça belirlenecek iş sağlığı ve güvenliğini ilgilendiren konularla ilgili bilgileri, İSG KATİP’e bildirmek");
            gorevvesorumluluklar.Add("İşyeri hekimiyle birlikte iş kazaları ve meslek hastalıklarıyla ilgili değerlendirme yapmak, tehlikeli olayın tekrarlanmaması için inceleme ve araştırma yaparak gerekli önleyici faaliyet planlarını hazırlamak ve uygulamaların takibini yapmak");
            gorevvesorumluluklar.Add("Bir sonraki yılda gerçekleştirilecek iş sağlığı ve güvenliğiyle ilgili faaliyetlerin yer aldığı yıllık çalışma planını işyeri hekimiyle birlikte hazırlamak");
            gorevvesorumluluklar.Add("Bulunması halinde üyesi olduğu iş sağlığı ve güvenliği kuruluyla işbirliği içinde çalışmak");
            gorevvesorumluluklar.Add("Çalışan temsilcisi ve destek elemanlarının çalışmalarına destek sağlamak ve bu kişilerle işbirliği yapmak");
            

        }
        public override string ToString()
        {
            string sonuc = ad + Environment.NewLine;
            sonuc += this.tc + Environment.NewLine;
            sonuc += this.sert + Environment.NewLine;
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
