using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ekogradnjaDL;
using ekogradnjaBE;

namespace ekogradnjaBL
{
    public class MenuBL
    {
        public static MenuStavkaList UcitajStavkeMenu(int idMenuUp)
        {
            return MenuDL.UcitajStavkeMenu(idMenuUp, null);
        }

        public static MenuStavkaList UcitajMenu(int idMenu)
        {
            return MenuDL.UcitajMenu(idMenu);
        }
    }
}
