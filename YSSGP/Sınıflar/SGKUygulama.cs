using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YSSGP.Sınıflar
{
    public class SGKUygulama:Personel
    {
        public  SGKUygulama()
        {
            gorevvesorumluluklar = new List<string>();
            gorevvesorumluluklar.Add("Aynı anda veya birbiri ardına yapılacak iş ve iş aşamalarının belirlendiği iş programlarının oluşturulması için teknik ve organizasyona yönelik kararların alınmasında ve işin ya da iş aşamalarının tamamlanması için ilgili meslek disiplinindeki kriterler de dikkate alınarak yapılacak süre hesabında, İş Sağlığı ve Güvenliği Kanununun 5 inci maddesinde belirtilen risklerden korunma ilkelerini göz önünde bulundurulmasını koordine etmek,");
            gorevvesorumluluklar.Add("İşverenlerin gerekli tedbirleri uygulamasını ve gerektiğinde çalışanların ve kendi nam ve hesabına çalışanların korunmasını, Yapı İşlerinde İş Sağlığı ve Güvenliği Yönetmeliğinin işverenlerin yükümlülüklerini konu alan 5 inci maddenin birinci fıkrasında belirtilen prensiplerin istikrarlı bir şekilde uygulanmasını, sağlık ve güvenlik planının yapılmasının gerektiği durumlarda bu planın uygulanmasını koordine etmek,");
            gorevvesorumluluklar.Add("Yapılan işteki ilerlemeleri ve meydana gelen değişiklikleri dikkate alarak sağlık ve güvenlik planında ve sağlık ve güvenlik dosyasında gerekli düzenlemeleri yapmak veya yapılmasını sağlamak,");
            gorevvesorumluluklar.Add("Aynı yapı alanında, işe sonradan katılanlarda dâhil olmak üzere, işveren veya alt işverenler arasında organizasyonu sağlamak, iş kazaları ve meslek hastalıklarından çalışanları korumak üzere işverenlerce yapılan çalışmaları koordine etmek, Kanunun 23 üncü maddesinin birinci fıkrasında belirtilen işverenler arası bilgi alış verişinin sağlanmasına katkıda bulunmak ve gerekli hallerde kendi nam ve hesabına çalışan kişilerin de bu çalışmalarda yer almasını sağlamak,");
            gorevvesorumluluklar.Add("Yapı işlerinde güvenli bir şekilde çalışılmasını sağlamak üzere yapılması gerekli kontrolleri koordine etmek,");
            gorevvesorumluluklar.Add("Yİzin verilen kişiler dışındakilerin yapı alanına girmesini önlemek üzere gerekli düzenlemeleri yapmak.");
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
