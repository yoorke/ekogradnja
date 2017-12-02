using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ekogradnjaBE;
using ekogradnjaDL;
using System.Data;

namespace ekogradnjaBL
{
    public class ProjekatBL
    {
        public static DataTable UcitajProjekte(bool prvaStrana, DateTime datumOd, DateTime datumDo, bool aktivan)
        {
            return ProjekatDL.UcitajProjekte(prvaStrana, datumOd, datumDo, aktivan);
        }

        public static Projekat UcitajProjekat(int idProjekta, string url)
        {
            return ProjekatDL.UcitajProjekat(idProjekta, url);
        }
    }
}
