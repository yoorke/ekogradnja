using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ekogradnjaBE;
using ekogradnjaDL;
using System.Data;

namespace ekogradnjaBL
{
    public class ProizvodBL
    {
        public static DataTable UcitajProizvode(int idProizvoda, bool slider, int idTipProizvoda)
        {
            return ProizvodDL.UcitajProizvode(idProizvoda, slider, idTipProizvoda);
        }

        public static Proizvod UcitajProizvod(int idProizvoda, string url)
        {
            return ProizvodDL.UcitajProizvod(idProizvoda, url);
            
            /*Proizvod proizvod = new Proizvod();
            DataTable ucitanProizvod = ProizvodDL.UcitajProizvode(idProizvoda, false, 0);

            proizvod.IdProizvoda = int.Parse(ucitanProizvod.Rows[0]["idProizvoda"].ToString());
            proizvod.NazivProizvoda = ucitanProizvod.Rows[0]["nazivProizvoda"].ToString();
            proizvod.OpisProizvoda = ucitanProizvod.Rows[0]["opisProizvoda"].ToString();
            proizvod.SifraProizvoda = ucitanProizvod.Rows[0]["sifraProizvoda"].ToString();
            //proizvod.IdTipaProizvoda = int.Parse(ucitanProizvod.Rows[0]["idTipaProizvoda"].ToString());
            //proizvod.Aktivan = bool.Parse(ucitanProizvod.Rows[0]["aktivan"].ToString());

            return proizvod;*/
        }

        public static DataTable UcitajProizvodeZaSeme()
        {
            return ProizvodDL.UcitajProizvodeZaSeme();
        }
    }
}
