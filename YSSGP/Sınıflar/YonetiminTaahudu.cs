using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YSSGP.Sınıflar
{
    public  class YonetiminTaahudu
    {
        public List<string> taahudler;
        public string adSoyad;
        public string firma;
        public string proje;
        public override string ToString()
        {
            string sonuc = "";
            sonuc += adSoyad + Environment.NewLine;
            
            sonuc += "begin taahudler" + Environment.NewLine;
            for (int i = 0; i < taahudler.Count; i++)
            {
                sonuc += taahudler[i] + Environment.NewLine;
            }
            sonuc += "end taahudler";
            return sonuc;
        }
        public string toHTML()
        {
            string sonuc = "";
            sonuc += "<h1 style='margin-top:20px; background-color:aqua;'>1. YÖNETİMİN TAAHHÜDÜ</h1>";
            sonuc += "<br/>";
            sonuc += "<p>" + firma + " yöneticisi olarak " + proje + " projesinin hazırlık ve uygulama aşamalarını kapsayacak şekilde projenin tamamlanmasına kadar geçen sürede çalışanların sağlık ve güvenliklerini korumak amacıyla;</p>";
            sonuc += "<ol>";
            for (int i = 0; i < taahudler.Count; i++)
            {
                sonuc += "<li>"+taahudler[i] +"</li>";
            }
            sonuc += "</ol>";
            sonuc += "<p>taahüt ederim.</p>";
            sonuc += "<br/>";
            sonuc += "<br/>";
            sonuc += "<br/>";
            sonuc += "<br/>";
            sonuc += "<div style='float:right'>";
            sonuc += "Tarih:" + DateTime.Now.ToShortDateString();
            sonuc += "<br/>";
            sonuc += "<br/>";
            sonuc += "İmza";
            sonuc += "<br/>";
            sonuc += "(En üst düzey yönetici tarafından imzalanacaktır.)";
            sonuc += "<br/>";
            sonuc += "<br/>";
            sonuc += "<br/>";
            sonuc += "<br/>";
            sonuc += "<br/>";
            sonuc += adSoyad;
            sonuc += "<br/>";
            sonuc += "<br/>";
            sonuc += "</div>";
            return sonuc;
        }
        public YonetiminTaahudu()
        {
            adSoyad = "";
            firma = "";
            taahudler = new List<string>();
            taahudler.Add("Yapılacak her işte sağlık ve güvenliğin öncelikli olarak göz önünde bulundurulacağı,");
            taahudler.Add("Yürürlükteki iş sağlığı ve güvenliği mevzuatına tam olarak uyulacağını,");
            taahudler.Add("İş sağlığı ve güvenliği koşullarının sürekli iyileştirileceğini,");
            taahudler.Add("İş sağlığı ve güvenliğine yönelik her türlü tedbirin zamanında alınacağını, tedbirler belirlenirken ve uygulanırken toplu koruma önlemlerine öncelik verileceğini,");
            taahudler.Add("Çalışanların iş sağlığı ve güvenliği konusunda eğitim ve bilgilendirilmesine önem verileceğini,");
            taahudler.Add("İş sağlığı ve güvenliği konusunda gerekli ve yeterli kaynağın sağlanacağı ve yapılması gerekli harcamalardan kaçınılmayacağını,");
            taahudler.Add("İş sağlığı ve güvenliği uygulamalarında çalışanların öneri ve fikirlerinin göz önünde bulundurulacağı, yönetim ve çalışanlar arasında iş sağlığı ve güvenliği alanında gerekli katılım, fikir alışverişi ve işbirliğinin sağlanacağını,");
            taahudler.Add("Planın bu şantiye koşulları ve çalışanları için hazırlandığını, proje süresince uygulanacağını ve gerekli hallerde güncelleneceğini, ");
            taahudler.Add("Projede görev alan en üst düzey yönetici de dahil olmak üzere her seviyedeki çalışana ve ziyaretçilere bu plan kapsamında üzerlerine düşen sorumlulukları konusunda yeterli bilgilendirmenin yapılacağını, ");
            

        }
    }
}
