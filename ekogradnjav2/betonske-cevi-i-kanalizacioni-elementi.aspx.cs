using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ekogradnjaBL;

namespace ekogradnjav2
{
    public partial class betonske_cevi_i_kanalizacioni_elementi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                ucitajProizvode();
        }

        private void ucitajProizvode()
        {
            repeaterBetonskeCevi.DataSource = ProizvodBL.UcitajProizvode(0, false, 4);
            repeaterBetonskeCevi.DataBind();
        }
    }
}