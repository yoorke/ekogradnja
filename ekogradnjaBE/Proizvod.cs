using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ekogradnjaBE
{
    public class Proizvod
    {
        private int _idProizvoda;
        private string _sifraProizvoda;
        private string _nazivProizvoda;
        private string _opisProizvoda;
        private bool _aktivan;
        private int _idTipaProizvoda;
        private DimenzijaList _dimenzije;
        private string _url;
        private BojaList _boje;

        public int IdProizvoda
        {
            get { return _idProizvoda; }
            set { _idProizvoda = value; }
        }

        public string SifraProizvoda
        {
            get { return _sifraProizvoda; }
            set { _sifraProizvoda = value; }
        }

        public string NazivProizvoda
        {
            get { return _nazivProizvoda; }
            set { _nazivProizvoda = value; }
        }

        public string OpisProizvoda
        {
            get { return _opisProizvoda; }
            set { _opisProizvoda = value; }
        }

        public bool Aktivan
        {
            get { return _aktivan; }
            set { _aktivan = value; }
        }

        public int IdTipaProizvoda
        {
            get { return _idTipaProizvoda; }
            set { _idTipaProizvoda = value; }
        }

        public DimenzijaList Dimenzije
        {
            get { return _dimenzije; }
            set { _dimenzije = value; }
        }

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        public BojaList Boje
        {
            get { return _boje; }
            set { _boje = value; }
        }
    }
}
