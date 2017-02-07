using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace YSSGP.Sınıflar
{
    public class CalismaYontemi
    {
        public List<string> yapımtekniği;
        public List<string> işekipmanikullanimi;
        public List<string> kimyasalmaddekullanimi;
        public List<string> calismaalaninaerisim;
        public List<string> malzemelerintasinmasi;
        public List<string> isekipmani;
        public List<string> kullanilacakkimyasallar;
        public List<string> egitimlipersonelihtiyaci;
        public override string ToString()
        {
            string sonuc = "begin yapım"+Environment.NewLine;
            for (int i = 0; i <yapımtekniği.Count; i++)
            {
                sonuc += yapımtekniği[i] + Environment.NewLine;
            }
            sonuc += "end yapım"+Environment.NewLine;
            sonuc += "begin ekipman kullanım" + Environment.NewLine;
            for (int i = 0; i < işekipmanikullanimi.Count; i++)
            {
                sonuc += işekipmanikullanimi[i] + Environment.NewLine;
            }
            sonuc += "end ekipman kullanım" + Environment.NewLine;
            sonuc += "begin kimyasal kullanım" + Environment.NewLine;
            for (int i = 0; i < kimyasalmaddekullanimi.Count; i++)
            {
                sonuc += kimyasalmaddekullanimi[i] + Environment.NewLine;
            }
            sonuc += "end kimyasal kullanım" + Environment.NewLine;
            sonuc += "begin çalışma alanı" + Environment.NewLine;
            for (int i = 0; i < calismaalaninaerisim.Count; i++)
            {
                sonuc += calismaalaninaerisim[i] + Environment.NewLine;
            }
            sonuc += "end çalışma alanı" + Environment.NewLine;
            sonuc += "begin malzeme" + Environment.NewLine;
            for (int i = 0; i < malzemelerintasinmasi.Count; i++)
            {
                sonuc += malzemelerintasinmasi[i] + Environment.NewLine;
            }
            sonuc += "end malzeme" + Environment.NewLine;
            sonuc += "begin işekipmanı" + Environment.NewLine;
            for (int i = 0; i < isekipmani.Count; i++)
            {
                sonuc += isekipmani[i] + Environment.NewLine;
            }
            sonuc += "end işekipmanı" + Environment.NewLine;
            sonuc += "begin kullanılacakkimyasallar" + Environment.NewLine;
            for (int i = 0; i < kullanilacakkimyasallar.Count; i++)
            {
                sonuc += kullanilacakkimyasallar[i] + Environment.NewLine;
            }
            sonuc += "end kullanılacakkimyasallar" + Environment.NewLine;
            sonuc += "begin egitim" + Environment.NewLine;
            for (int i = 0; i < egitimlipersonelihtiyaci.Count; i++)
            {
                sonuc += egitimlipersonelihtiyaci[i] + Environment.NewLine;
            }
            sonuc += "end egitim";
            return sonuc;

        }
        public CalismaYontemi()
        {
            yapımtekniği = new List<string>();
            işekipmanikullanimi = new List<string>();
            kimyasalmaddekullanimi = new List<string>();
            calismaalaninaerisim = new List<string>();
            malzemelerintasinmasi = new List<string>();
            isekipmani = new List<string>();
            kullanilacakkimyasallar = new List<string>();
            egitimlipersonelihtiyaci = new List<string>();
        }
        public void Serilestir(string path)
        {
            using (Stream st = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                XmlSerializer x = new XmlSerializer(typeof(CalisanTemsilcisi));
                x.Serialize(st, this);
            }
        }
    }
}
