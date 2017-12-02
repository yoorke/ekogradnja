using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ekogradnjaBE
{
    public class Dimenzija
    {
        private int _idDimenzije;
        private string _nazivDimenzije;
        private string _dimenzija;
        private double _brojKomada;
        private double _brojNaPaleti;
        private int _idProizvoda;
        private double _l;
        private double _d;
        private double _c;
        private double _e;
        private double _tezina;

        public int IdDimenzije
        {
            get { return _idDimenzije; }
            set { _idDimenzije = value; }
        }

        public string NazivDimenzije
        {
            get { return _nazivDimenzije; }
            set { _nazivDimenzije = value; }
        }

        public string DimenzijaProizvoda
        {
            get { return _dimenzija; }
            set { _dimenzija = value; }
        }

        public double BrojKomada
        {
            get { return _brojKomada; }
            set { _brojKomada = value; }
        }

        public double BrojNaPaleti
        {
            get { return _brojNaPaleti; }
            set { _brojNaPaleti = value; }
        }

        public int IdProizvoda
        {
            get { return _idProizvoda; }
            set { _idProizvoda = value; }
        }

        public double L
        {
            get { return _l; }
            set { _l = value; }
        }

        public double D
        {
            get { return _d; }
            set { _d = value; }
        }

        public double C
        {
            get { return _c; }
            set { _c = value; }
        }

        public double E
        {
            get { return _e; }
            set { _e = value; }
        }

        public double Tezina
        {
            get { return _tezina; }
            set { _tezina = value; }
        }
    }
}
