using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ekogradnjaBE
{
    public class MenuStavka
    {
        private int _idMenuStavka;
        private string _naziv;
        private string _url;
        private MenuStavkaList _podmenu;
        private int _redniBroj;

        public int IdMenuStavka
        {
            get { return _idMenuStavka; }
            set { _idMenuStavka = value; }
        }

        public string Naziv
        {
            get { return _naziv; }
            set { _naziv = value; }
        }

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        public MenuStavkaList Podmenu
        {
            get { return _podmenu; }
            set { _podmenu = value; }
        }

        public bool Count
        {
            get { return (Podmenu.Count > 0); }
        }

        public int RedniBroj
        {
            get { return _redniBroj; }
            set { _redniBroj = value; }
        }
    }
}
