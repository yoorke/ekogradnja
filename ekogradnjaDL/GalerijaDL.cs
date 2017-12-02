using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace ekogradnjaDL
{
    public class GalerijaDL
    {
        public static DataTable UcitajGaleriju(string tip, DateTime datumOd, DateTime datumDo)
        {
            return ProjekatDL.UcitajProjekte(false, datumOd, datumDo, true);
        }
    }
}
