using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview
{
    internal class Musteri
    {
        public int id;
        private string ad;
        public string soyad;
        public int yas;
        public string meslek;
        public string sehir;
        
        

        public string Ad { get => ad; set => ad = value.ToLower(); }
        public string Soyad { get => soyad; set => soyad = value.ToUpper(); }

        public string Meslek { get => meslek; set => meslek = value.ToLower(); }
        public string Sehir { get => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(sehir);
            set => sehir = value; }
    }
}
