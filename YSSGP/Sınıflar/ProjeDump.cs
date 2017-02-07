using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
namespace YSSGP.Sınıflar
{
    [XmlRoot("Proje")]
    public class ProjeDump
    {
        [XmlElement(ElementName ="İşveren Bilgileri",Type =typeof(IsverenBilgileri))]
        IsverenBilgileri isveren;
       // [XmlElement(ElementName = "Proje Bilgileri", Type = typeof(ProjeBilgileri))]
       // ProjeBilgileri projeBilgileri;
       // [XmlArrayItem(ElementName = "KendiNaminaCalisanlar", Type = typeof(KendiNaminaCalisan))]
       // List<KendiNaminaCalisan> kendiNaminaCalisanlarListesi;
       // [XmlArrayItem(ElementName = "Altİşverenler", Type = typeof(AltIsverenBilgileri))]
       // List<AltIsverenBilgileri> altisverenListesi;
       // [XmlElement(ElementName = "Proje Sorumlusu", Type = typeof(ProjeSorumlusu))]
       // ProjeSorumlusu projeSorumlusu;
       // [XmlElement(ElementName = "SGKKoor_Hazirlik", Type = typeof(SGKoordinator_Hazirlik))]
       // SGKoordinator_Hazirlik SGKoordianator_sorumlu_hazirlik;
       // [XmlElement(ElementName = "SGKKoor_Uygulama", Type = typeof(SGKUygulama))]
       // SGKUygulama SGKoordianator_sorumlu_uygulama;
       // [XmlArrayItem(ElementName = "ISGUzmanları", Type = typeof(ISGUzmani))]
       // List<ISGUzmani> asilisverenisguzmanlari;
       // [XmlArrayItem(ElementName = "Hekimler", Type = typeof(IsyeriHekimi))]
       // List<IsyeriHekimi> asilisverenisyerihekimleri;
       // [XmlArrayItem(ElementName = "CalisanTemsilcileri", Type = typeof(CalisanTemsilcisi))]
       // List<CalisanTemsilcisi> calisantemsilciler;
       // [XmlElement(ElementName = "IsPlani", Type = typeof(IsPlani))]
       // IsPlani plan;
       // [XmlArrayItem(ElementName = "sahaTehlikeler", Type = typeof(Tehlike))]
       // List<Tehlike> yapisahasiningenelozgutehlikeler;
       // [XmlArrayItem(ElementName = "biyoTehlikeler", Type = typeof(Tehlike))]
       // List<Tehlike> biyolojiktehlikeler;
       // [XmlArrayItem(ElementName = "fizikselTehlikeler", Type = typeof(Tehlike))]
       // List<Tehlike> fizikseltehlikeler;
       // [XmlArrayItem(ElementName = "kimyasalTehlikeler", Type = typeof(Tehlike))]
       //List<Tehlike> kimyasaltehlikeler;
       // [XmlArrayItem(ElementName = "CakisanIsler", Type = typeof(CakisanIsler))]
       // List<CakisanIsler> cakisanisler;
       // [XmlArrayItem(ElementName = "UcuncuTaraflar", Type = typeof(UcuncuTarafEtki))]
       // List<UcuncuTarafEtki> ucuncutaraflar;
       // [XmlElement(ElementName = "kurallar", Type = typeof(ŞantiyeKuralları))]
       // ŞantiyeKuralları kurallar;
        public ProjeDump()
        {
            
            this.isveren = Proje.isveren;
            //this.projeBilgileri = Proje.projeBilgileri;
            //this.kendiNaminaCalisanlarListesi = Proje.kendiNaminaCalisanlarListesi;
            //this.altisverenListesi = Proje.altisverenListesi;
            //this.asilisverenisguzmanlari = Proje.asilisverenisguzmanlari;
            //this.asilisverenisyerihekimleri = Proje.asilisverenisyerihekimleri;
            //this.biyolojiktehlikeler = Proje.biyolojiktehlikeler;
            //this.cakisanisler = Proje.cakisanisler;
            //this.calisantemsilciler = Proje.calisantemsilciler;
            //this.fizikseltehlikeler = Proje.fizikseltehlikeler;
            //this.kimyasaltehlikeler = Proje.kimyasaltehlikeler;
            //this.kurallar = Proje.kurallar;
            //this.plan = Proje.plan;
            //this.projeSorumlusu = Proje.projeSorumlusu;
            //this.SGKoordianator_sorumlu_hazirlik = Proje.SGKoordianator_sorumlu_hazirlik;
            //this.SGKoordianator_sorumlu_uygulama = Proje.SGKoordianator_sorumlu_uygulama;
            //this.ucuncutaraflar = Proje.ucuncutaraflar;
            //this.yapisahasiningenelozgutehlikeler = Proje.yapisahasiningenelozgutehlikeler;
            
        }
    }
    
}
