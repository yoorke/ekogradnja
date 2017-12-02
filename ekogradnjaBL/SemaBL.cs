using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ekogradnjaDL;
using System.Data;

namespace ekogradnjaBL
{
    public class SemaBL
    {
        public static DataTable UcitajSeme(string url)
        {
            return SemaDL.UcitajSeme(url);
        }
    }
}
