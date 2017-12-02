using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ekogradnjaBE;
using ekogradnjaDL;

namespace ekogradnjaBL
{
    public class PageBL
    {
        public static void Save(Page page, bool novi)
        {
            PageDL.Sacuvaj(page, novi);
        }

        public static Page LoadPage(int idPage, string url)
        {
            return PageDL.LoadPage(idPage, url);
        }
    }
}
