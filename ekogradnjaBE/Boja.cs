using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ekogradnjaBE
{
    public class Boja
    {
        private int _idBoje;
        private string _nazivBoje;
        private string _url;

        public int IdBoje
        {
            get { return _idBoje; }
            set { _idBoje = value; }
        }

        public string NazivBoje
        {
            get { return _nazivBoje; }
            set { _nazivBoje = value; }
        }

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }
    }
}
