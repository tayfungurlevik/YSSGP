using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YSSGP.Sınıflar
{
   public class ŞantiyeKuralları
    {
        public List<string> kurallar;
        public List<string> ziyaretciprosedur;
        public override string ToString()
        {
            string sonuc = "begin şantiye kurallar"+Environment.NewLine;
            for (int i = 0; i < kurallar.Count; i++)
            {
                sonuc += kurallar[i] + Environment.NewLine;
                
            }
            sonuc += "end şantiye kurallar" + Environment.NewLine;
            sonuc += "begin ziyaretci" + Environment.NewLine;
            for (int i = 0; i < ziyaretciprosedur.Count; i++)
            {
                sonuc += ziyaretciprosedur[i] + Environment.NewLine;

            }
            sonuc += "end ziyaretci";
            return sonuc;
        }
        
        public ŞantiyeKuralları()
        {
            kurallar = new List<string>();
            ziyaretciprosedur = new List<string>();
            kurallar.Add("Yapılan çalışma sırasında o iş için yapılan risk değerlendirmesi ve geliştirilen uygulamalara uyulması zorunludur.");
            kurallar.Add("Çalışanlar sadece eğitimini aldıkları ve yetkilendirildikleri cihazları kullanacaktır ve kendilerine yetki ve izin verilen işleri yapacaklardır.");
            kurallar.Add("Herhangi bir tehlike görülmesi durumunda veya herhangi bir cihazın güvenlik sorunu olduğundan şüphelenildiğinde, bu durum derhal yetkili kişilere bildirilecektir. ");
            kurallar.Add("İşyerinde gereksiz şakalaşmalar yapılmayacaktır. ");
            kurallar.Add("Çalışma esnasında bir başkasının dikkatini dağıtacak hareketlerden kaçınılacaktır.");
            kurallar.Add("Çalışma ortamı temiz ve düzenli tutulacaktır. Şantiye içerisinde hiçbir malzeme veya ekipman kazaya neden olabilecek şekilde gelişigüzel bırakılmayacaktır.");
            kurallar.Add("Çalışırken o işi yapmak için tasarlanmış doğru ekipmanlar kullanılacaktır.");
            kurallar.Add("İşyerinde alkol veya uyuşturucu kullanmak yasaktır.");
            kurallar.Add("Çalışanlar, kendilerine teslim edilen KKD’leri kullanmaları gereken her yerde talimatlara uygun olarak kullanacak ve muhafaza edeceklerdir. Zarar gören KKD’ler hakkında yetkililer bilgilendirilecek ve zarar görmüş ekipman tekrar kullanılmayacak, yenisiyle değiştirilmesi sağlanacaktır");
            kurallar.Add("Herhangi bir kimyasal madde ile temas halinde kimyasalın MSDS’ine uygun müdahale yöntemi ile müdahale edilecek ve gerekli hallerde tıbbi yardıma başvurulacaktır");
            kurallar.Add("Acil kaçış yolları ve geçitler kişilerin geçemeyeceği şekilde kapatılmayacak, engeller koyulmayacaktır.");
            kurallar.Add("Herhangi bir kişi izinsiz bir şekilde şantiyeye ve çalışma alanlarına getirilmeyecek. Önce mutlaka yetkili bir kişi ile görüşülecek ve izni alınarak ziyaretçi prosedürü uygulanacaktır.");
            kurallar.Add("Çalışanların düşebileceği boşluklar veya kuyular görülürse bölgedeki çalışanlar zaman geçirilmeksizin uyarılacak ve mutlaka yetkili kişiye haber verilecektir. Geçici olarak önlem alınacaksa kırılgan malzemelerle kapatılmadığından emin olunacaktır.");
            kurallar.Add("Şantiyede bulunan herkes, baret, iş elbisesi ve taban ve burun korumalı iş ayakkabıları kullanacaktır");
            kurallar.Add("Yapılan işe uygun koruyucu eldiven kullanılacaktır");
            kurallar.Add("Tüm sosyal alanlar temiz tutulacak ve bu alanlara zarar verilmeyecektir");
            kurallar.Add("Yeme ve içme alanının dışında yemek ve içmek yasaktır.");
            kurallar.Add("Girişe yasaklı olan yerlere yetkilendirilenler haricinde giriş yapılmayacaktır");
            kurallar.Add("Şantiye sahasının tamamında sağlık ve güvenlik işaretlerine uymak zorunludur");
            kurallar.Add("Yapılacak hiçbir işe gerekli güvenlik tedbirleri tam olarak alınmadan başlanılmayacaktır");
            kurallar.Add("Yapımında şüpheye düşülen her şey için şantiye şefi, iş güvenliği uzmanı vb. yetkin kişilerden bilgi istenilecektir. Yapılacak iş tam olarak öğrenilmeden hiçbir şekilde çalışmaya başlanılmayacaktır.");
            kurallar.Add("Acil durumlarla ilgili yapılan eğitim ve tatbikatlara katılım sağlanacaktır");
            kurallar.Add("Ekipmanlara çalışır vaziyette bakım, onarım ve yağlama yapılmayacaktır");
            kurallar.Add("İskeleler sadece iskele kurulum elemanları tarafından kurulacaktır"); 
            kurallar.Add("Yayalar, şantiye içerisinde kendileri için tahsis edilen güvenli ulaşım yollarını kullanacaktır.");
            kurallar.Add("İş ekipmanlarının ve araçların manevra ve etki alanlarında kimse bulunmayacak, eğer bulunma zorunluluğu varsa operatörün kendisini gördüğünden emin olacaktır");
            kurallar.Add("Yüksekte yapılacak çalışmalarda korkuluk ve platform gibi toplu korunmanın sağlanamadığı durumlarda yüksekten düşmeyi engelleyici olarak sadece paraşüt tipi kemer kullanılacak ve mutlaka bir başkasının gözetimi olmadan çalışılmayacaktır");
            ziyaretciprosedur.Add("Ziyaretçiler, uyulması gerekli kurallar konusunda şantiye sahasına girmeden önce bilgilendirilecek ve ziyaret süresince kendilerine eşlik edilecektir");
            ziyaretciprosedur.Add("Şantiye içerisinde ziyaretçiler kendilerine verilen KKD’leri kullanmak zorundadır. Ziyaretçilere KKD’lerin kullanımı ile ilgili bilgilendirme yapılacaktır");
            ziyaretciprosedur.Add("Ziyaretçilerin şantiye içerisinde kendilerine gösterilen yerler ve rotalar haricindeki alanlara girişleri yasaktır");
            ziyaretciprosedur.Add("Ziyaretçi kendisine eşlik eden kişiyi kaybettiği zaman bulunduğu yerden uzaklaşmadan en yakınındaki çalışana durumu bildirecek ve kendisine ulaşılmasını bekleyecektir");
            

        }
    }
}
