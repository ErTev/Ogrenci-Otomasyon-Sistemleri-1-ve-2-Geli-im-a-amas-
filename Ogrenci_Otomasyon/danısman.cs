using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon_Ödev
{

    internal class danısman
    {
        public string _dad; public string _dsoyad;
        danısman() { }
        public danısman(string ad, string soyad)
        {
            _dad = ad;
            
            _dsoyad = soyad;

        }

        public string ad
        {
            get { return _dad; }
            set { _dad = value; }
        }

        public string soyad
        {
            get { return _dsoyad; }
            set { _dsoyad = value; }
        }
       

    }

}
