using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ekogradnjaBE
{
    public class Projekat
    {
        private int _idProjekta;
        private string _nazivProjekta;
        private string _opisProjekta;
        private DateTime _datumProjekta;
        private string _sadrzaj;
        private string _url;

        public int IdProjekta
        {
            get { return _idProjekta; }
            set { _idProjekta = value; }
        }

        public string NazivProjekta
        {
            get { return _nazivProjekta; }
            set { _nazivProjekta = value; }
        }

        public string OpisProjekta
        {
            get { return _opisProjekta; }
            set { _opisProjekta = value; }
        }

        public DateTime DatumProjekta
        {
            get { return _datumProjekta; }
            set { _datumProjekta = value; }
        }

        public string Sadrzaj
        {
            get { return _sadrzaj; }
            set { _sadrzaj = value; }
        }

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }
    }
}
