using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogikLayer
{
    public class Converter : SubjectConverter
    {
        public void ConvertList(List<double> RawList)
        {
            List<double> KonverteretListe = new List<double>();

            foreach (var item in RawList)
            {
                KonverteretListe.Add(item);
            }
            Notify(KonverteretListe);
        }
    }
}
