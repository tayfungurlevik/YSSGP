using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YSSGP.Sınıflar
{
    public class Tehlike
    {
        public string tehlikekayangi;
        public string risk;
        public string onlem;
        public Tehlike()
        {

        }
        public override string ToString()
        {
            string sonuc = tehlikekayangi + Environment.NewLine;
            sonuc += risk + Environment.NewLine;
            sonuc += onlem ;
            return sonuc;
        }
    }
}
