using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YSSGP.Sınıflar
{
    public class IsPlani
    {
        public List<Is> yapilacakisler ;
        public IsPlani()
        {
            yapilacakisler = new List<Is>();
        }
        public override string ToString()
        {
            string sonuc = "";
            
                
                for (int i = 0; i < yapilacakisler.Count - 1; i++)
                {
                    sonuc += yapilacakisler[i].ToString() + Environment.NewLine;
                }
                sonuc += yapilacakisler[yapilacakisler.Count - 1].ToString();
                
            
            return sonuc;

        }
        public List<Is> CakisanIsler()
        {
            
            List<Is> isler = new List<Is>();
            foreach (Is iş in yapilacakisler)
            {
                for (int i = 0; i < yapilacakisler.Count; i++)
                {
                    if (i!=yapilacakisler.IndexOf(iş))
                    {
                        //eğer aynı iş değilse
                        if (yapilacakisler[i].baslangic<=iş.bitis&&yapilacakisler[i].bitis>=iş.baslangic)
                        {
                            if (!isler.Contains(iş))
                            {
                                isler.Add(iş);
                            }

                            if (!iş.cakistigiIs.Contains(yapilacakisler[i]))
                            {
                                iş.cakistigiIs.Add ( yapilacakisler[i]);
                            }
                           
                        }
                    }
                }
            }
            
            return isler;
        }
    }
}
