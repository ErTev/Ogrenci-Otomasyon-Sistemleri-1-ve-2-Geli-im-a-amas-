using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon_Ödev
{
    internal class ogrencı
    {
        public string _ad; public string _no; public string _soyad; public string _cinsiyet; public string _danısman;

        ogrencı() { }

        public ogrencı(string ad, string no, string soyad, string cinsiyet,string danısman)
        {
            _ad = ad;
            _no = no;
            _soyad = soyad;
            _cinsiyet = cinsiyet;
            _danısman = danısman;
        }

        public string ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        public string soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }

        public string no
        {
            get { return _no; }
            set { _no = value; }
        }
        public string cinsiyet
        {
            get { return _cinsiyet; }
            set { _cinsiyet = value; }
        }
        public string danısman
        {
            get { return _danısman; }
            set { _danısman = value; }
        }
    }



}


