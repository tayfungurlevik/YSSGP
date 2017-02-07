using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YSSGP
{
    public class UcuncuTarafEtki
    {
        public string risk;
        public string etki;
        public string kontrol;
        public override string ToString()
        {
            string sonuc = risk + Environment.NewLine;
            sonuc += etki + Environment.NewLine;
            sonuc += kontrol;
            return sonuc;

        }
    }
    
}
