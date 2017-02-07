using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YSSGP.Sınıflar
{
    public class KendiNaminaCalisan
    {
        public string adsoyad;
        public string tckimlikno;
        public string adres;
        public string isler;
        public DateTime baslangictarih;
        public DateTime bitistarih;
        public override string ToString()
        {
            string sonuc = adsoyad + Environment.NewLine;
            sonuc += tckimlikno + Environment.NewLine;
            sonuc += adres + Environment.NewLine;
            sonuc += isler + Environment.NewLine;
            sonuc += baslangictarih.ToShortDateString() + Environment.NewLine;
            sonuc += bitistarih.ToShortDateString() + Environment.NewLine;
            sonuc += "begin gorev" + Environment.NewLine;
            for (int i = 0; i < gorevvesorumluluklar.Count; i++)
            {
                sonuc += gorevvesorumluluklar[i] + Environment.NewLine;
            }
            sonuc += "end gorev";
            return sonuc;
        }
        public List<string> gorevvesorumluluklar;
        public KendiNaminaCalisan()
        {
            gorevvesorumluluklar = new List<string>();
            gorevvesorumluluklar.Add("Sağlık ve güvenlik koordinatörlerinin uyarı ve talimatlarını dikkate almak,");
            gorevvesorumluluklar.Add("İş Sağlığı ve Güvenliği Kanunu’nun çalışanların ve İşverenlerin yükümlülüklerini düzenleyen 5 ve 19 uncu maddelerine,");
            gorevvesorumluluklar.Add("İş Sağlığı ve Güvenliği Kanunu’nun işbirliği, koordinasyon ve bilgilendirme hususları ile ilgili 23 üncü maddesine, ");
            gorevvesorumluluklar.Add("Yapı İşlerinde Sağlık ve Güvenlik Yönetmeliği’nin “Yapı Alanları İçin Asgari Sağlık ve Güvenlik Şartları” başlıklı Ek-4’üne, ");
            gorevvesorumluluklar.Add("İş Ekipmanlarının Kullanımında Sağlık ve Güvenlik Şartları Yönetmeliği’nin “İş Ekipmanı ile İlgili Kurallar” başlıklı 6 ncı maddesine,");
            gorevvesorumluluklar.Add("İş Ekipmanlarının Kullanımında Sağlık ve Güvenlik Şartları Yönetmeliği’nin eklerinde belirtilen ilgili hükümlere,");
            gorevvesorumluluklar.Add("Kişisel Koruyucu Donanımların İşyerlerinde Kullanılması Hakkında Yönetmeliğin işveren yükümlülüklerini içeren 5 inci maddesi, 6 ncı maddesinin birinci fıkrasının (a), (ç) ve (ğ) bentleri ile 7 nci maddesine uygun olarak hareket etmek.");
            

        }
    }
}
