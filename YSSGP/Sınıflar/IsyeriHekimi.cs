using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YSSGP.Sınıflar
{
    public class IsyeriHekimi:ISGPersonel
    {
        public IsyeriHekimi()
        {
            gorevvesorumluluklar = new List<string>();
            gorevvesorumluluklar.Add("Görev aldığı işyerinde göreviyle ilgili mevzuat ve teknik gelişmeleri göz önünde bulundurarak iş sağlığı ve güvenliği ile ilgili eksiklik ve aksaklıkları, tedbir ve tavsiyeleri belirlemek ve işverene yazılı olarak bildirmek");
            gorevvesorumluluklar.Add("Bildirilen eksiklik ve aksaklıkların acil durdurmayı gerektirmesi veya yangın, patlama, göçme, kimyasal sızıntı ve benzeri acil ve hayati tehlike arz etmesi, meslek hastalığına sebep olabilecek ortamların bulunmasına rağmen işveren tarafından gerekli tedbirlerin alınmaması hâlinde, bu durumu Bakanlığın yetkili birimine, varsa yetkili sendika temsilcisine, yoksa çalışan temsilcisine bildirmek");
            gorevvesorumluluklar.Add("İş sağlığı ve güvenliği hizmetlerini ihmale mahal vermeden yürütmek");
            gorevvesorumluluklar.Add("İş sağlığı ve güvenliği hizmetleri kapsamında çalışanların sağlık gözetimi ve çalışma ortamının gözetimi ile ilgili işverene rehberlik yapmak");
            gorevvesorumluluklar.Add("İşyerinde yapılan çalışmalar ve yapılacak değişikliklerle ilgili olarak işyerinin tasarımı, kullanılan maddeler de dâhil olmak üzere işin planlanması, organizasyonu ve uygulanması, kişisel koruyucu donanımların seçimi konularının iş sağlığı ve güvenliği mevzuatına ve genel iş sağlığı kurallarına uygun olarak sürdürülmesini sağlamak için işverene önerilerde bulunmak");
            gorevvesorumluluklar.Add("İşyerinde çalışanların sağlığının geliştirilmesi amacıyla gerekli aktiviteler konusunda işverene tavsiyelerde bulunmak");
            gorevvesorumluluklar.Add("İş sağlığı ve güvenliği alanında yapılacak araştırmalara katılmak, ayrıca işin yürütümünde ergonomik ve psikososyal riskler açısından çalışanların fiziksel ve zihinsel kapasitelerini dikkate alarak iş ile çalışanın uyumunun sağlanması ve çalışma ortamındaki stres faktörlerinden korunmaları için araştırmalar yapmak ve bu araştırma sonuçlarını rehberlik faaliyetlerinde dikkate almak");
            gorevvesorumluluklar.Add("Kantin, yemekhane, yatakhane, kreş ve emzirme odaları ile soyunma odaları, duş ve tuvaletler dahil olmak üzere işyeri bina ve eklentilerinin genel hijyen şartlarını sürekli izleyip denetleyerek, çalışanlara yürütülen işin gerektirdiği beslenme ihtiyacının ve uygun içme suyunun sağlanması konularında tavsiyelerde bulunmak");
            gorevvesorumluluklar.Add("İşyerinde meydana gelen iş kazası ve meslek hastalıklarının nedenlerinin araştırılması ve tekrarlanmaması için alınacak önlemler konusunda çalışmalar yaparak işverene önerilerde bulunmak");
            gorevvesorumluluklar.Add("İşyerinde meydana gelen ancak ölüm ya da yaralanmaya neden olmadığı halde çalışana, ekipmana veya işyerine zarar verme potansiyeli olan olayların nedenlerinin araştırılması konusunda çalışma yapmak ve işverene önerilerde bulunmak");
            gorevvesorumluluklar.Add("İş sağlığı ve güvenliğiyle ilgili alınması gereken tedbirleri işverene yazılı olarak bildirmek");
            gorevvesorumluluklar.Add("İş sağlığı ve güvenliği yönünden risk değerlendirmesi yapılmasıyla ilgili çalışmalara ve uygulanmasına katılmak, risk değerlendirmesi sonucunda alınması gereken sağlık ve güvenlik önlemleri konusunda işverene önerilerde bulunmak ve takibini yapmak");
            gorevvesorumluluklar.Add("Gebe veya emziren kadınlar, 18 yaşından küçükler, meslek hastalığı tanısı veya ön tanısı olanlar, kronik hastalığı olanlar, yaşlılar, malul ve engelliler, alkol, ilaç ve uyuşturucu bağımlılığı olanlar, birden fazla iş kazası geçirmiş olanlar gibi özel politika gerektiren grupları yakın takip ve koruma altına almak, bilgilendirmek ve yapılacak risk değerlendirmesinde özel olarak dikkate almak");
            gorevvesorumluluklar.Add("Sağlık gözetimi kapsamında yapılacak işe giriş ve periyodik muayeneler ve tetkikler ile ilgili olarak çalışanları bilgilendirmek ve onların rızasını almak");
            gorevvesorumluluklar.Add("Gece postaları da dâhil olmak üzere çalışanların sağlık gözetimini yapmak");
            gorevvesorumluluklar.Add("Özel politika gerektiren gruplar, meslek hastalığı tanısı veya ön tanısı alanlar, kronik hastalığı, madde bağımlılığı, birden fazla iş kazası geçirmiş olanlar gibi çalışanların, uygun işe yerleştirilmeleri için gerekli sağlık muayenelerini yaparak rapor düzenlemek, meslek hastalığı tanısı veya ön tanısı almış çalışanın olması durumunda kişinin çalıştığı ortamdaki diğer çalışanların sağlık muayenelerini tekrarlamak");
            gorevvesorumluluklar.Add("Sağlık sorunları nedeniyle işe devamsızlık durumları ile işyerinde olabilecek sağlık tehlikeleri arasında bir ilişkinin olup olmadığını tespit etmek, gerektiğinde çalışma ortamı ile ilgili ölçümler yapılmasını planlayarak işverenin onayına sunmak ve alınan sonuçların çalışanların sağlığı yönünden değerlendirmesini yapmak");
            gorevvesorumluluklar.Add("Çalışanların sağlık nedeniyle tekrarlanan işten uzaklaşmalarından sonra işe dönüşlerinde talep etmeleri halinde işe dönüş muayenesi yaparak eski görevinde çalışması sakıncalı bulunanlara mevcut sağlık durumlarına uygun bir görev verilmesini tavsiye ederek işverenin onayına sunmak");
            gorevvesorumluluklar.Add("Bulaşıcı hastalıkların kontrolü için yayılmayı önleme ve bağışıklama çalışmalarının yanı sıra gerekli hijyen eğitimlerini vermek, gerekli muayene ve tetkiklerinin yapılmasını sağlamak");
            gorevvesorumluluklar.Add("İşyerindeki sağlık gözetimi ile ilgili çalışmaları kaydetmek, iş güvenliği uzmanı ile işbirliği yaparak iş kazaları ve meslek hastalıkları ile ilgili değerlendirme yapmak, tehlikeli olayın tekrarlanmaması için inceleme ve araştırma yaparak gerekli önleyici faaliyet planlarını hazırlamak ve bu konuları da içerecek şekilde yıllık çalışma planını hazırlayarak işverenin onayına sunmak, uygulamaların takibini yapmak");
            gorevvesorumluluklar.Add("Bir başka işverenden iş görmek için işyerine geçici olarak gönderilen çalışanlar ile alt işveren çalışanlarının yapacakları işe uygun olduğunu gösteren sağlık raporlarının süresinin dolup dolmadığını kontrol etmek");
            gorevvesorumluluklar.Add("Çalışanların iş sağlığı ve güvenliği eğitimlerinin ilgili mevzuata uygun olarak planlanması konusunda çalışma yaparak işverenin onayına sunmak ve uygulamalarını yapmak veya kontrol etmek");
            gorevvesorumluluklar.Add("İşyerinde ilkyardım ve acil müdahale hizmetlerinin organizasyonu ve personelin eğitiminin sağlanması çalışmalarını ilgili mevzuat doğrultusunda yürütmek");
            gorevvesorumluluklar.Add("Yöneticilere, bulunması halinde iş sağlığı ve güvenliği kurulu üyelerine ve çalışanlara genel sağlık, iş sağlığı ve güvenliği, hijyen, bağımlılık yapan maddelerin kullanımının zararları, kişisel koruyucu donanımlar ve toplu korunma yöntemleri konularında eğitim vermek, eğitimin sürekliliğini sağlamak");
            gorevvesorumluluklar.Add("Çalışanları işyerindeki riskler, sağlık gözetimi, yapılan işe giriş ve periyodik muayeneler konusunda bilgilendirmek");
            gorevvesorumluluklar.Add("İş sağlığı ve güvenliği çalışmaları ve sağlık gözetimi sonuçlarının kaydedildiği yıllık değerlendirme raporunu iş güvenliği uzmanı ile işbirliği halinde hazırlamak");
            gorevvesorumluluklar.Add("Bakanlıkça belirlenecek iş sağlığı ve güvenliğini ilgilendiren konularla ilgili bilgileri İSG KATİP sistemi üzerinden Genel Müdürlüğe bildirmek");
            gorevvesorumluluklar.Add("Sağlık gözetimi sonuçlarına göre, iş güvenliği uzmanı ile işbirliği içinde çalışma ortamının gözetimi kapsamında gerekli ölçümlerin yapılmasını önermek, ölçüm sonuçlarını değerlendirmek");
            gorevvesorumluluklar.Add("Bulunması halinde üyesi olduğu iş sağlığı ve güvenliği kuruluyla işbirliği içinde çalışmak");
            gorevvesorumluluklar.Add("İşyerinde iş sağlığı ve güvenliği konularında bilgi ve eğitim sağlanması için ilgili taraflarla işbirliği yapmak");
            gorevvesorumluluklar.Add("İş kazaları ve meslek hastalıklarının analizi, iş uygulamalarının iyileştirilmesine yönelik programlar ile yeni teknoloji ve donanımın sağlık açısından değerlendirilmesi ve test edilmesi gibi mevcut uygulamaların iyileştirilmesine yönelik programların geliştirilmesi çalışmalarına katılmak");
            gorevvesorumluluklar.Add("Çalışma Gücü ve Meslekte Kazanma Gücü Kaybı Oranı Yönetmeliğine göre meslek hastalığı ile ilgili sağlık kurulu raporlarını düzenlemeye yetkili hastaneler ile işbirliği içinde çalışmak, iş kazasına uğrayan veya meslek hastalığına yakalanan çalışanların rehabilitasyonu konusunda ilgili birimlerle işbirliği yapmak");
            gorevvesorumluluklar.Add("İş sağlığı ve güvenliği alanında yapılacak araştırmalara katılmak");
            gorevvesorumluluklar.Add("Gerekli yerlerde kullanılmak amacıyla iş sağlığı ve güvenliği talimatları ile çalışma izin prosedürlerinin hazırlanmasında iş güvenliği uzmanına katkı vermek");
            gorevvesorumluluklar.Add("Bir sonraki yılda gerçekleştirilecek iş sağlığı ve güvenliğiyle ilgili faaliyetlerin yer aldığı yıllık çalışma planını iş güvenliği uzmanıyla birlikte hazırlamak");
            gorevvesorumluluklar.Add("İşyerinde görevli çalışan temsilcisi ve destek elemanlarının çalışmalarına destek sağlamak ve bu kişilerle işbirliği yapmak");
            

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
