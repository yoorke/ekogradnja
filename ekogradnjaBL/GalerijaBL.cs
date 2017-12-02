using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ekogradnjaDL;
using System.Data;

namespace ekogradnjaBL
{
    public class GalerijaBL
    {
        public static DataTable UcitajGaleriju(string tip, DateTime datumOd, DateTime datumDo)
        {
            return GalerijaDL.UcitajGaleriju(tip, datumOd, datumDo);
        }
    }
}
