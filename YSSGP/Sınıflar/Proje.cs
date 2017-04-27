using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
namespace YSSGP.Sınıflar
{
    public static class Proje
    {
        public static IsverenBilgileri isveren;
        public static YonetiminTaahudu yonTaahud;
        public static ProjeBilgileri projeBilgileri;
        public static List<KendiNaminaCalisan> kendiNaminaCalisanlarListesi;
        public static List<AltIsverenBilgileri> altisverenListesi;
        public static ProjeSorumlusu projeSorumlusu;
        public static SGKoordinator_Hazirlik SGKoordianator_sorumlu_hazirlik;
        public static SGKUygulama SGKoordianator_sorumlu_uygulama;
        public static List<ISGUzmani> asilisverenisguzmanlari;
        public static List<IsyeriHekimi> asilisverenisyerihekimleri;
        public static List<CalisanTemsilcisi> calisantemsilciler;
        public static IsPlani plan;
        public static List<Tehlike> yapisahasiningenelozgutehlikeler;
        public static List<Tehlike> biyolojiktehlikeler;
        public static string isgorganizasyonsemasi;

        public static List<CakisanIsler> cakisanisler;
        public static List<UcuncuTarafEtki> ucuncutaraflar;
        public static ŞantiyeKuralları kurallar;
        public static List<Ek_3> ekucmaddeleri;
        public static List<Ek_4> ekdortmaddeleri;
        public static List<Ek_5> ekbesmaddeleri;
        public static bool kaydedildi;
        public static void DosyayaYaz(string filename)
        {
            try
            {
                if (Proje.plan.yapilacakisler.Count == 0)
                {
                    throw new NullReferenceException("Proje iş planında en az bir yapılacak iş olmalıdır.");
                    
                }
                using (StreamWriter yazici = new StreamWriter(filename))
                {
                    yazici.AutoFlush = true;
                    yazici.WriteLine("Begin Proje Bilgileri");
                    yazici.WriteLine(Proje.projeBilgileri.ToString());
                    yazici.WriteLine("End Proje Bilgileri");
                    yazici.WriteLine("Begin YonetiminTaahudu");
                    yazici.WriteLine(Proje.yonTaahud.ToString());
                    yazici.WriteLine("End YonetiminTaahudu");
                    yazici.WriteLine("Begin İşveren Bilgileri");
                    yazici.WriteLine(Proje.isveren.ToString());
                    yazici.WriteLine("End İşveren Bilgileri");
                    yazici.WriteLine("Begin Alt İşverenler");
                    yazici.Flush();
                    for (int i = 0; i < Proje.altisverenListesi.Count; i++)
                    {
                        yazici.WriteLine(Proje.altisverenListesi[i].ToString());
                        yazici.Flush();
                    }
                    yazici.Flush();
                    yazici.WriteLine("End Alt İşverenler");
                    yazici.WriteLine("Begin Kendi Namına Çalışanlar");
                    for (int i = 0; i < Proje.kendiNaminaCalisanlarListesi.Count; i++)
                    {
                        yazici.WriteLine(Proje.kendiNaminaCalisanlarListesi[i].ToString());
                        yazici.Flush();
                    }
                    yazici.WriteLine("End Kendi Namına Çalışanlar");
                    yazici.Flush();
                    yazici.WriteLine("Begin Proje Sorumlusu");
                    yazici.WriteLine(Proje.projeSorumlusu.ToString());
                    yazici.WriteLine("End Proje Sorumlusu");
                    yazici.WriteLine("Begin Koordinatör Hazırlık");
                    yazici.WriteLine(Proje.SGKoordianator_sorumlu_hazirlik.ToString());
                    yazici.WriteLine("End Koordinatör Hazırlık");
                    yazici.WriteLine("Begin Koordinatör Uygulama");
                    yazici.WriteLine(Proje.SGKoordianator_sorumlu_uygulama.ToString());
                    yazici.WriteLine("End Koordinatör Uygulama");
                    yazici.Flush();
                    yazici.WriteLine("Begin İSG Uzmanları");
                    for (int i = 0; i < Proje.asilisverenisguzmanlari.Count; i++)
                    {
                        yazici.WriteLine(Proje.asilisverenisguzmanlari[i].ToString());
                        yazici.Flush();
                    }
                    yazici.WriteLine("End İSG Uzmanları");
                    yazici.Flush();
                    yazici.WriteLine("Begin İşyeri Hekimleri");
                    for (int i = 0; i < Proje.asilisverenisyerihekimleri.Count; i++)
                    {
                        yazici.WriteLine(Proje.asilisverenisyerihekimleri[i].ToString());
                        yazici.Flush();
                    }
                    yazici.WriteLine("End İşyeri Hekimleri");
                    yazici.Flush();
                    yazici.WriteLine("Begin Çalışan Temsilcileri");
                    for (int i = 0; i < Proje.calisantemsilciler.Count; i++)
                    {
                        yazici.WriteLine(Proje.calisantemsilciler[i].ToString());
                        yazici.Flush();
                    }
                    yazici.WriteLine("End Çalışan Temsilcileri");
                    yazici.Flush();
                    yazici.WriteLine("Begin İş Planı");
                    yazici.Flush();
                    yazici.WriteLine(Proje.plan.ToString());
                    yazici.WriteLine("End İş Planı");
                    yazici.Flush();
                    yazici.WriteLine("Begin Özgü Tehlikeler");
                    for (int i = 0; i < Proje.yapisahasiningenelozgutehlikeler.Count; i++)
                    {
                        yazici.WriteLine(Proje.yapisahasiningenelozgutehlikeler[i].ToString());
                    }
                    yazici.WriteLine("End Özgü Tehlikeler");
                    yazici.Flush();
                    yazici.WriteLine("Begin Biyolojik Tehlikeler");
                    for (int i = 0; i < Proje.biyolojiktehlikeler.Count; i++)
                    {
                        yazici.WriteLine(Proje.biyolojiktehlikeler[i].ToString());
                    }
                    yazici.WriteLine("End Biyolojik Tehlikeler");
                    yazici.Flush();


                    yazici.WriteLine("Begin Çakışan İşler");
                    for (int i = 0; i < Proje.cakisanisler.Count; i++)
                    {
                        yazici.WriteLine(Proje.cakisanisler[i].ToString());
                    }
                    yazici.WriteLine("End Çakışan İşler");
                    yazici.Flush();
                    yazici.WriteLine("Begin Ucuncu Taraflar");
                    for (int i = 0; i < Proje.ucuncutaraflar.Count; i++)
                    {
                        yazici.WriteLine(Proje.ucuncutaraflar[i].ToString());
                    }
                    yazici.WriteLine("End Ucuncu Taraflar");
                    yazici.Flush();
                    yazici.WriteLine("Begin Kurallar");
                    yazici.WriteLine(Proje.kurallar.ToString());
                    yazici.WriteLine("End Kurallar");
                    yazici.WriteLine("Begin semadosya");
                    yazici.WriteLine(isgorganizasyonsemasi);
                    yazici.WriteLine("End semadosya");
                    yazici.WriteLine("Begin ek3ler");
                    for (int i = 0; i < ekucmaddeleri.Count; i++)
                    {
                        yazici.WriteLine(ekucmaddeleri[i].ToString());
                    }
                    yazici.WriteLine("End ek3ler");

                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                throw new Exception(ex.Message);
            }
            
        }


        public static void DosyadanOku(string filename)
        {
            try
            {
                using (StreamReader okuyucu = new StreamReader(filename))
                {
                    string line;
                    while ((line = okuyucu.ReadLine()) != null)
                    {
                        if (line == "Begin Proje Bilgileri")
                        {
                            ProjeBilgileri projebilgi = new ProjeBilgileri();

                            projebilgi.projeAdi = okuyucu.ReadLine();
                            projebilgi.isinSahibi = okuyucu.ReadLine();
                            projebilgi.adres = okuyucu.ReadLine();
                            projebilgi.tanim = okuyucu.ReadLine();
                            projebilgi.baslangicTarih = Convert.ToDateTime(okuyucu.ReadLine());
                            projebilgi.bitisTarih = Convert.ToDateTime(okuyucu.ReadLine());
                            if ((line = okuyucu.ReadLine()) == "End Proje Bilgileri")
                            {
                                Proje.projeBilgileri = projebilgi;
                            }
                        }
                        line = okuyucu.ReadLine();
                        if (line == "Begin YonetiminTaahudu")
                        {
                            YonetiminTaahudu yon = new YonetiminTaahudu();
                            yon.adSoyad = okuyucu.ReadLine();


                            if ((line = okuyucu.ReadLine()) == "begin taahudler")
                            {
                                yon.taahudler.Clear();
                                while ((line = okuyucu.ReadLine()) != "end taahudler")
                                {
                                    yon.taahudler.Add(line);
                                }
                            }
                            if ((line = okuyucu.ReadLine()) == "End YonetiminTaahudu")
                            {
                                Proje.yonTaahud = yon;
                            }

                        }
                        line = okuyucu.ReadLine();
                        if (line == "Begin İşveren Bilgileri")
                        {
                            IsverenBilgileri isverenbilgi = new IsverenBilgileri();
                            isverenbilgi.isveren = okuyucu.ReadLine();
                            isverenbilgi.unvan = okuyucu.ReadLine();
                            isverenbilgi.sgksicilno = okuyucu.ReadLine();
                            isverenbilgi.adres = okuyucu.ReadLine();
                            isverenbilgi.telfaks = okuyucu.ReadLine();
                            isverenbilgi.web = okuyucu.ReadLine();
                            isverenbilgi.sorumlufirmalar = okuyucu.ReadLine();
                            if ((line = okuyucu.ReadLine()) == "begin gorevler")
                            {
                                isverenbilgi.gorevveSorumluluklar.Clear();
                                while ((line = okuyucu.ReadLine()) != "end gorevler")
                                {
                                    isverenbilgi.gorevveSorumluluklar.Add(line);
                                }
                            }
                            if ((line = okuyucu.ReadLine()) == "End İşveren Bilgileri")
                            {
                                Proje.isveren = isverenbilgi;
                            }

                        }
                        line = okuyucu.ReadLine();
                        if (line == "Begin Alt İşverenler")
                        {
                            List<AltIsverenBilgileri> altisverenlistesi = new List<AltIsverenBilgileri>();
                            while ((line = okuyucu.ReadLine()) != "End Alt İşverenler")
                            {
                                AltIsverenBilgileri altisverenbilgi = new AltIsverenBilgileri();
                                altisverenbilgi.altisveren = line;
                                altisverenbilgi.sgk = okuyucu.ReadLine();
                                altisverenbilgi.adres = okuyucu.ReadLine();
                                altisverenbilgi.isler = okuyucu.ReadLine();
                                altisverenbilgi.baslangictarih = Convert.ToDateTime(okuyucu.ReadLine());
                                altisverenbilgi.bitistarih = Convert.ToDateTime(okuyucu.ReadLine());
                                altisverenbilgi.isguzmanad = okuyucu.ReadLine();
                                altisverenbilgi.isguzmansert = okuyucu.ReadLine();
                                altisverenbilgi.hekimad = okuyucu.ReadLine();
                                altisverenbilgi.hekimsert = okuyucu.ReadLine();


                                if ((line = okuyucu.ReadLine()) == "begin gorev")
                                {
                                    altisverenbilgi.gorevvesorumluluklar.Clear();
                                    while ((line = okuyucu.ReadLine()) != "end gorev")
                                    {
                                        altisverenbilgi.gorevvesorumluluklar.Add(line);
                                    }
                                    altisverenlistesi.Add(altisverenbilgi);
                                }

                                Proje.altisverenListesi = altisverenlistesi;

                            }


                        }
                        line = okuyucu.ReadLine();
                        if (line == "Begin Kendi Namına Çalışanlar")
                        {
                            List<KendiNaminaCalisan> kndclistesi = new List<KendiNaminaCalisan>();
                            while ((line = okuyucu.ReadLine()) != "End Kendi Namına Çalışanlar")
                            {
                                KendiNaminaCalisan kendinamına = new KendiNaminaCalisan();
                                kendinamına.adsoyad = line;
                                kendinamına.tckimlikno = okuyucu.ReadLine();
                                kendinamına.adres = okuyucu.ReadLine();
                                kendinamına.isler = okuyucu.ReadLine();
                                kendinamına.baslangictarih = Convert.ToDateTime(okuyucu.ReadLine());
                                kendinamına.bitistarih = Convert.ToDateTime(okuyucu.ReadLine());


                                if ((line = okuyucu.ReadLine()) == "begin gorev")
                                {
                                    kendinamına.gorevvesorumluluklar.Clear();
                                    while ((line = okuyucu.ReadLine()) != "end gorev")
                                    {
                                        kendinamına.gorevvesorumluluklar.Add(line);
                                    }
                                    kndclistesi.Add(kendinamına);
                                }

                                Proje.kendiNaminaCalisanlarListesi = kndclistesi;

                            }
                        }
                        line = okuyucu.ReadLine();
                        if (line == "Begin Proje Sorumlusu")
                        {
                            ProjeSorumlusu projesorumlu = new ProjeSorumlusu();

                            projesorumlu.adsoyad = okuyucu.ReadLine();
                            projesorumlu.TCKimlikNo = okuyucu.ReadLine();
                            projesorumlu.Meslek = okuyucu.ReadLine();
                            projesorumlu.iletisim = okuyucu.ReadLine();

                            if ((line = okuyucu.ReadLine()) == "begin gorev")
                            {
                                projesorumlu.gorevvesorumluluklar.Clear();
                                while ((line = okuyucu.ReadLine()) != "end gorev")
                                {
                                    projesorumlu.gorevvesorumluluklar.Add(line);
                                }
                            }
                            if ((line = okuyucu.ReadLine()) == "End Proje Sorumlusu")
                            {
                                Proje.projeSorumlusu = projesorumlu;
                            }
                        }
                        line = okuyucu.ReadLine();
                        if (line == "Begin Koordinatör Hazırlık")
                        {
                            SGKoordinator_Hazirlik hazirlik = new SGKoordinator_Hazirlik();

                            hazirlik.adsoyad = okuyucu.ReadLine();
                            hazirlik.TCKimlikNo = okuyucu.ReadLine();
                            hazirlik.Meslek = okuyucu.ReadLine();
                            hazirlik.iletisim = okuyucu.ReadLine();

                            if ((line = okuyucu.ReadLine()) == "begin gorev")
                            {
                                hazirlik.gorevvesorumluluklar.Clear();
                                while ((line = okuyucu.ReadLine()) != "end gorev")
                                {
                                    hazirlik.gorevvesorumluluklar.Add(line);
                                }
                            }
                            if ((line = okuyucu.ReadLine()) == "End Koordinatör Hazırlık")
                            {
                                Proje.SGKoordianator_sorumlu_hazirlik = hazirlik;
                            }
                        }
                        line = okuyucu.ReadLine();
                        if (line == "Begin Koordinatör Uygulama")
                        {
                            SGKUygulama uygulama = new SGKUygulama();

                            uygulama.adsoyad = okuyucu.ReadLine();
                            uygulama.TCKimlikNo = okuyucu.ReadLine();
                            uygulama.Meslek = okuyucu.ReadLine();
                            uygulama.iletisim = okuyucu.ReadLine();

                            if ((line = okuyucu.ReadLine()) == "begin gorev")
                            {
                                uygulama.gorevvesorumluluklar.Clear();
                                while ((line = okuyucu.ReadLine()) != "end gorev")
                                {
                                    uygulama.gorevvesorumluluklar.Add(line);
                                }
                            }
                            if ((line = okuyucu.ReadLine()) == "End Koordinatör Uygulama")
                            {
                                Proje.SGKoordianator_sorumlu_uygulama = uygulama;
                            }
                        }
                        line = okuyucu.ReadLine();
                        if (line == "Begin İSG Uzmanları")
                        {
                            List<ISGUzmani> uzmanlistesi = new List<ISGUzmani>();
                            while ((line = okuyucu.ReadLine()) != "End İSG Uzmanları")
                            {
                                ISGUzmani uzman = new ISGUzmani();
                                uzman.ad = line;
                                uzman.tc = okuyucu.ReadLine();
                                uzman.sert = okuyucu.ReadLine();
                                uzman.iletişim = okuyucu.ReadLine();


                                if ((line = okuyucu.ReadLine()) == "begin gorev")
                                {
                                    uzman.gorevvesorumluluklar.Clear();
                                    while ((line = okuyucu.ReadLine()) != "end gorev")
                                    {
                                        uzman.gorevvesorumluluklar.Add(line);
                                    }
                                    uzmanlistesi.Add(uzman);
                                }

                                Proje.asilisverenisguzmanlari = uzmanlistesi;

                            }


                        }
                        line = okuyucu.ReadLine();
                        if (line == "Begin İşyeri Hekimleri")
                        {
                            List<IsyeriHekimi> hekimlistesi = new List<IsyeriHekimi>();
                            while ((line = okuyucu.ReadLine()) != "End İşyeri Hekimleri")
                            {
                                IsyeriHekimi hekim = new IsyeriHekimi();
                                hekim.ad = line;
                                hekim.tc = okuyucu.ReadLine();
                                hekim.sert = okuyucu.ReadLine();
                                hekim.iletişim = okuyucu.ReadLine();


                                if ((line = okuyucu.ReadLine()) == "begin gorev")
                                {
                                    hekim.gorevvesorumluluklar.Clear();
                                    while ((line = okuyucu.ReadLine()) != "end gorev")
                                    {
                                        hekim.gorevvesorumluluklar.Add(line);
                                    }
                                    hekimlistesi.Add(hekim);
                                }

                                Proje.asilisverenisyerihekimleri = hekimlistesi;

                            }


                        }
                        line = okuyucu.ReadLine();
                        if (line == "Begin Çalışan Temsilcileri")
                        {
                            List<CalisanTemsilcisi> ctlist = new List<CalisanTemsilcisi>();
                            while ((line = okuyucu.ReadLine()) != "End Çalışan Temsilcileri")
                            {
                                CalisanTemsilcisi ct = new CalisanTemsilcisi();
                                ct.ad = line;
                                ct.tc = okuyucu.ReadLine();
                                ct.gorevi = okuyucu.ReadLine();
                                ct.iletişim = okuyucu.ReadLine();


                                if ((line = okuyucu.ReadLine()) == "begin gorev")
                                {
                                    ct.gorevvesorumluluklar.Clear();
                                    while ((line = okuyucu.ReadLine()) != "end gorev")
                                    {
                                        ct.gorevvesorumluluklar.Add(line);
                                    }
                                    ctlist.Add(ct);
                                }

                                Proje.calisantemsilciler = ctlist;

                            }


                        }
                        line = okuyucu.ReadLine();
                        if (line == "Begin İş Planı")
                        {
                            IsPlani işplanı = new IsPlani();

                            List<Is> işler = new List<Is>();
                            işplanı.yapilacakisler = işler;
                            while ((line = okuyucu.ReadLine()) != "End İş Planı")
                            {
                                Is iş = new Is();
                                iş.isinadi = line;
                                iş.baslangic = Convert.ToDateTime(okuyucu.ReadLine());
                                iş.bitis = Convert.ToDateTime(okuyucu.ReadLine());
                                CalismaYontemi yontem = new CalismaYontemi();
                                if ((line = okuyucu.ReadLine()) == "begin yapım")
                                {
                                    List<string> yapım = new List<string>();
                                    while ((line = okuyucu.ReadLine()) != "end yapım")
                                    {
                                        yapım.Add(line);
                                    }
                                    yontem.yapımtekniği = yapım;
                                }

                                if ((line = okuyucu.ReadLine()) == "begin ekipman kullanım")
                                {
                                    List<string> ekipmankullanım = new List<string>();
                                    while ((line = okuyucu.ReadLine()) != "end ekipman kullanım")
                                    {
                                        ekipmankullanım.Add(line);
                                    }
                                    yontem.işekipmanikullanimi = ekipmankullanım;
                                }
                                if ((line = okuyucu.ReadLine()) == "begin kimyasal kullanım")
                                {
                                    List<string> kimya = new List<string>();
                                    while ((line = okuyucu.ReadLine()) != "end kimyasal kullanım")
                                    {
                                        kimya.Add(line);
                                    }
                                    yontem.kimyasalmaddekullanimi = kimya;
                                }
                                if ((line = okuyucu.ReadLine()) == "begin çalışma alanı")
                                {
                                    List<string> cae = new List<string>();
                                    while ((line = okuyucu.ReadLine()) != "end çalışma alanı")
                                    {
                                        cae.Add(line);
                                    }
                                    yontem.calismaalaninaerisim = cae;
                                }
                                if ((line = okuyucu.ReadLine()) == "begin malzeme")
                                {
                                    List<string> malzeme = new List<string>();
                                    while ((line = okuyucu.ReadLine()) != "end malzeme")
                                    {
                                        malzeme.Add(line);
                                    }
                                    yontem.malzemelerintasinmasi = malzeme;
                                }
                                if ((line = okuyucu.ReadLine()) == "begin işekipmanı")
                                {
                                    List<string> işekip = new List<string>();
                                    while ((line = okuyucu.ReadLine()) != "end işekipmanı")
                                    {
                                        işekip.Add(line);
                                    }
                                    yontem.isekipmani = işekip;
                                }
                                if ((line = okuyucu.ReadLine()) == "begin kullanılacakkimyasallar")
                                {
                                    List<string> kulkim = new List<string>();
                                    while ((line = okuyucu.ReadLine()) != "end kullanılacakkimyasallar")
                                    {
                                        kulkim.Add(line);
                                    }
                                    yontem.kullanilacakkimyasallar = kulkim;
                                }
                                if ((line = okuyucu.ReadLine()) == "begin egitim")
                                {
                                    List<string> egirim = new List<string>();
                                    while ((line = okuyucu.ReadLine()) != "end egitim")
                                    {
                                        egirim.Add(line);
                                    }
                                    yontem.egitimlipersonelihtiyaci = egirim;
                                }
                                iş.yontem = yontem;
                                if ((line = okuyucu.ReadLine()) == "Begin Fiziksel Tehlikeler")
                                {
                                    List<Tehlike> fiziksel = new List<Tehlike>();

                                    while ((line = okuyucu.ReadLine()) != "End Fiziksel Tehlikeler")
                                    {
                                        Tehlike fizikseltehlike = new Tehlike();
                                        fizikseltehlike.tehlikekayangi = line;
                                        fizikseltehlike.risk = okuyucu.ReadLine();
                                        fizikseltehlike.onlem = okuyucu.ReadLine();
                                        fiziksel.Add(fizikseltehlike);
                                    }
                                    iş.fizikseltehlikeler = fiziksel;
                                }

                                if ((line = okuyucu.ReadLine()) == "Begin Kimyasal Tehlikeler")
                                {
                                    List<Tehlike> kimyasal = new List<Tehlike>();

                                    while ((line = okuyucu.ReadLine()) != "End Kimyasal Tehlikeler")
                                    {
                                        Tehlike kimyasaltehlike = new Tehlike();
                                        kimyasaltehlike.tehlikekayangi = line;
                                        kimyasaltehlike.risk = okuyucu.ReadLine();
                                        kimyasaltehlike.onlem = okuyucu.ReadLine();
                                        kimyasal.Add(kimyasaltehlike);
                                    }
                                    iş.kimyasaltehlikeler = kimyasal;
                                    işler.Add(iş);
                                }

                            }
                            Proje.plan = işplanı;


                        }
                        line = okuyucu.ReadLine();
                        if (line == "Begin Özgü Tehlikeler")
                        {
                            List<Tehlike> ozgutehlike = new List<Tehlike>();
                            while ((line = okuyucu.ReadLine()) != "End Özgü Tehlikeler")
                            {

                                Tehlike teh = new Tehlike();
                                teh.tehlikekayangi = line;
                                teh.risk = okuyucu.ReadLine();
                                teh.onlem = okuyucu.ReadLine();
                                ozgutehlike.Add(teh);
                            }
                            yapisahasiningenelozgutehlikeler = ozgutehlike;
                        }

                        line = okuyucu.ReadLine();
                        if (line == "Begin Biyolojik Tehlikeler")
                        {
                            List<Tehlike> biyotehlike = new List<Tehlike>();
                            while ((line = okuyucu.ReadLine()) != "End Biyolojik Tehlikeler")
                            {

                                Tehlike teh = new Tehlike();
                                teh.tehlikekayangi = line;
                                teh.risk = okuyucu.ReadLine();
                                teh.onlem = okuyucu.ReadLine();
                                biyotehlike.Add(teh);
                            }
                            biyolojiktehlikeler = biyotehlike;
                        }


                        line = okuyucu.ReadLine();

                        if (line == "Begin Çakışan İşler")
                        {
                            Proje.cakisanisler = new List<CakisanIsler>();


                            while ((line = okuyucu.ReadLine()) != "End Çakışan İşler")
                            {
                                CakisanIsler ciş = new CakisanIsler();
                                if (line == "Begin İş 1")
                                {
                                    Is iş = new Is();
                                    while ((line = okuyucu.ReadLine()) != "End İş 1")
                                    {

                                        iş.isinadi = line;
                                        iş.baslangic = Convert.ToDateTime(okuyucu.ReadLine());
                                        iş.bitis = Convert.ToDateTime(okuyucu.ReadLine());
                                        CalismaYontemi yontem = new CalismaYontemi();
                                        if ((line = okuyucu.ReadLine()) == "begin yapım")
                                        {
                                            List<string> yapım = new List<string>();
                                            while ((line = okuyucu.ReadLine()) != "end yapım")
                                            {
                                                yapım.Add(line);
                                            }
                                            yontem.yapımtekniği = yapım;
                                        }

                                        if ((line = okuyucu.ReadLine()) == "begin ekipman kullanım")
                                        {
                                            List<string> ekipmankullanım = new List<string>();
                                            while ((line = okuyucu.ReadLine()) != "end ekipman kullanım")
                                            {
                                                ekipmankullanım.Add(line);
                                            }
                                            yontem.işekipmanikullanimi = ekipmankullanım;
                                        }
                                        if ((line = okuyucu.ReadLine()) == "begin kimyasal kullanım")
                                        {
                                            List<string> kimya = new List<string>();
                                            while ((line = okuyucu.ReadLine()) != "end kimyasal kullanım")
                                            {
                                                kimya.Add(line);
                                            }
                                            yontem.kimyasalmaddekullanimi = kimya;
                                        }
                                        if ((line = okuyucu.ReadLine()) == "begin çalışma alanı")
                                        {
                                            List<string> cae = new List<string>();
                                            while ((line = okuyucu.ReadLine()) != "end çalışma alanı")
                                            {
                                                cae.Add(line);
                                            }
                                            yontem.calismaalaninaerisim = cae;
                                        }
                                        if ((line = okuyucu.ReadLine()) == "begin malzeme")
                                        {
                                            List<string> malzeme = new List<string>();
                                            while ((line = okuyucu.ReadLine()) != "end malzeme")
                                            {
                                                malzeme.Add(line);
                                            }
                                            yontem.malzemelerintasinmasi = malzeme;
                                        }
                                        if ((line = okuyucu.ReadLine()) == "begin işekipmanı")
                                        {
                                            List<string> işekip = new List<string>();
                                            while ((line = okuyucu.ReadLine()) != "end işekipmanı")
                                            {
                                                işekip.Add(line);
                                            }
                                            yontem.isekipmani = işekip;
                                        }
                                        if ((line = okuyucu.ReadLine()) == "begin kullanılacakkimyasallar")
                                        {
                                            List<string> kulkim = new List<string>();
                                            while ((line = okuyucu.ReadLine()) != "end kullanılacakkimyasallar")
                                            {
                                                kulkim.Add(line);
                                            }
                                            yontem.kullanilacakkimyasallar = kulkim;
                                        }
                                        if ((line = okuyucu.ReadLine()) == "begin egitim")
                                        {
                                            List<string> egirim = new List<string>();
                                            while ((line = okuyucu.ReadLine()) != "end egitim")
                                            {
                                                egirim.Add(line);
                                            }
                                            yontem.egitimlipersonelihtiyaci = egirim;
                                        }
                                        iş.yontem = yontem;
                                        if ((line = okuyucu.ReadLine()) == "Begin Fiziksel Tehlikeler")
                                        {
                                            while ((line = okuyucu.ReadLine()) != "End Fiziksel Tehlikeler")
                                            {
                                                Tehlike fiz = new Tehlike();
                                                fiz.tehlikekayangi = line;
                                                fiz.risk = okuyucu.ReadLine();
                                                fiz.onlem = okuyucu.ReadLine();
                                                iş.fizikseltehlikeler.Add(fiz);
                                            }

                                        }
                                        if ((line = okuyucu.ReadLine()) == "Begin Kimyasal Tehlikeler")
                                        {
                                            while ((line = okuyucu.ReadLine()) != "End Kimyasal Tehlikeler")
                                            {
                                                Tehlike kim = new Tehlike();
                                                kim.tehlikekayangi = line;
                                                kim.risk = okuyucu.ReadLine();
                                                kim.onlem = okuyucu.ReadLine();
                                                iş.kimyasaltehlikeler.Add(kim);
                                            }

                                        }

                                    }


                                    ciş.iş1 = iş;

                                }

                                line = okuyucu.ReadLine();
                                if (line == "Begin İş 2")
                                {
                                    Is işş = new Is();
                                    while ((line = okuyucu.ReadLine()) != "End İş 2")
                                    {

                                        işş.isinadi = line;
                                        işş.baslangic = Convert.ToDateTime(okuyucu.ReadLine());
                                        işş.bitis = Convert.ToDateTime(okuyucu.ReadLine());
                                        CalismaYontemi yontem = new CalismaYontemi();
                                        if ((line = okuyucu.ReadLine()) == "begin yapım")
                                        {
                                            List<string> yapım = new List<string>();
                                            while ((line = okuyucu.ReadLine()) != "end yapım")
                                            {
                                                yapım.Add(line);
                                            }
                                            yontem.yapımtekniği = yapım;
                                        }

                                        if ((line = okuyucu.ReadLine()) == "begin ekipman kullanım")
                                        {
                                            List<string> ekipmankullanım = new List<string>();
                                            while ((line = okuyucu.ReadLine()) != "end ekipman kullanım")
                                            {
                                                ekipmankullanım.Add(line);
                                            }
                                            yontem.işekipmanikullanimi = ekipmankullanım;
                                        }
                                        if ((line = okuyucu.ReadLine()) == "begin kimyasal kullanım")
                                        {
                                            List<string> kimya = new List<string>();
                                            while ((line = okuyucu.ReadLine()) != "end kimyasal kullanım")
                                            {
                                                kimya.Add(line);
                                            }
                                            yontem.kimyasalmaddekullanimi = kimya;
                                        }
                                        if ((line = okuyucu.ReadLine()) == "begin çalışma alanı")
                                        {
                                            List<string> cae = new List<string>();
                                            while ((line = okuyucu.ReadLine()) != "end çalışma alanı")
                                            {
                                                cae.Add(line);
                                            }
                                            yontem.calismaalaninaerisim = cae;
                                        }
                                        if ((line = okuyucu.ReadLine()) == "begin malzeme")
                                        {
                                            List<string> malzeme = new List<string>();
                                            while ((line = okuyucu.ReadLine()) != "end malzeme")
                                            {
                                                malzeme.Add(line);
                                            }
                                            yontem.malzemelerintasinmasi = malzeme;
                                        }
                                        if ((line = okuyucu.ReadLine()) == "begin işekipmanı")
                                        {
                                            List<string> işekip = new List<string>();
                                            while ((line = okuyucu.ReadLine()) != "end işekipmanı")
                                            {
                                                işekip.Add(line);
                                            }
                                            yontem.isekipmani = işekip;
                                        }
                                        if ((line = okuyucu.ReadLine()) == "begin kullanılacakkimyasallar")
                                        {
                                            List<string> kulkim = new List<string>();
                                            while ((line = okuyucu.ReadLine()) != "end kullanılacakkimyasallar")
                                            {
                                                kulkim.Add(line);
                                            }
                                            yontem.kullanilacakkimyasallar = kulkim;
                                        }
                                        if ((line = okuyucu.ReadLine()) == "begin egitim")
                                        {
                                            List<string> egirim = new List<string>();
                                            while ((line = okuyucu.ReadLine()) != "end egitim")
                                            {
                                                egirim.Add(line);
                                            }
                                            yontem.egitimlipersonelihtiyaci = egirim;
                                        }
                                        işş.yontem = yontem;
                                        if ((line = okuyucu.ReadLine()) == "Begin Fiziksel Tehlikeler")
                                        {
                                            while ((line = okuyucu.ReadLine()) != "End Fiziksel Tehlikeler")
                                            {
                                                Tehlike fiz = new Tehlike();
                                                fiz.tehlikekayangi = line;
                                                fiz.risk = okuyucu.ReadLine();
                                                fiz.onlem = okuyucu.ReadLine();
                                                işş.fizikseltehlikeler.Add(fiz);
                                            }

                                        }
                                        if ((line = okuyucu.ReadLine()) == "Begin Kimyasal Tehlikeler")
                                        {
                                            while ((line = okuyucu.ReadLine()) != "End Kimyasal Tehlikeler")
                                            {
                                                Tehlike kim = new Tehlike();
                                                kim.tehlikekayangi = line;
                                                kim.risk = okuyucu.ReadLine();
                                                kim.onlem = okuyucu.ReadLine();
                                                işş.kimyasaltehlikeler.Add(kim);
                                            }

                                        }
                                    }
                                    ciş.iş2 = işş;
                                }
                                ciş.çakışmabaşlangıç = Convert.ToDateTime(okuyucu.ReadLine());
                                ciş.çakışmabitiş = Convert.ToDateTime(okuyucu.ReadLine());
                                ciş.risk = okuyucu.ReadLine();
                                ciş.Etkilenenler = okuyucu.ReadLine();
                                ciş.kontrol = okuyucu.ReadLine();
                                Proje.cakisanisler.Add(ciş);
                            }




                        }
                        line = okuyucu.ReadLine();
                        if (line == "Begin Ucuncu Taraflar")
                        {
                            List<UcuncuTarafEtki> uctaraflar = new List<UcuncuTarafEtki>();
                            while ((line = okuyucu.ReadLine()) != "End Ucuncu Taraflar")
                            {
                                UcuncuTarafEtki etki = new UcuncuTarafEtki();
                                etki.risk = line;
                                etki.etki = okuyucu.ReadLine();
                                etki.kontrol = okuyucu.ReadLine();
                                uctaraflar.Add(etki);
                            }
                            ucuncutaraflar = uctaraflar;
                        }
                        line = okuyucu.ReadLine();
                        if (line == "Begin Kurallar")
                        {
                            ŞantiyeKuralları şk = new ŞantiyeKuralları();

                            while ((line = okuyucu.ReadLine()) != "End Kurallar")
                            {

                                if (line == "begin şantiye kurallar")
                                {
                                    List<string> şkural = new List<string>();
                                    while ((line = okuyucu.ReadLine()) != "end şantiye kurallar")
                                    {
                                        şkural.Add(line);
                                    }
                                    şk.kurallar = şkural;
                                }
                                line = okuyucu.ReadLine();
                                if (line == "begin ziyaretci")
                                {
                                    List<string> ziyar = new List<string>();
                                    while ((line = okuyucu.ReadLine()) != "end ziyaretci")
                                    {
                                        ziyar.Add(line);
                                    }
                                    şk.ziyaretciprosedur = ziyar;
                                }

                            }
                            kurallar = şk;

                        }
                        line = okuyucu.ReadLine();
                        if (line=="Begin semadosya")
                        {
                            isgorganizasyonsemasi = okuyucu.ReadLine();
                        }
                        line = okuyucu.ReadLine();
                        if (line=="Begin ek3ler")
                        {
                            List<Ek_3> ekuc = new List<Ek_3>();
                            while ((line = okuyucu.ReadLine()) != "End ek3ler")
                            {
                                
                                Ek_3 ek = new Ek_3();
                                ek.İşEkipmanı = line;
                                ek.İşEkipmanıSahibi = okuyucu.ReadLine();
                                ek.KişilerinYetkinliği = okuyucu.ReadLine();
                                ek.Gereklilik = okuyucu.ReadLine();
                                ekuc.Add(ek);
                            }
                            ekucmaddeleri = ekuc;
                        }
                        line = okuyucu.ReadLine();
                        //buraya ek4 eklenecek

                        if (line=="")
                        {

                        }

                    }
                }
            }
            catch (Exception ex)
            {

                throw new InvalidDataException("Dosya uygun formatta yazılmamış."+ex.Message);
            }
            
        }
       


    }
}
