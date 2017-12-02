using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ekogradnjaBL;

namespace ekogradnjav2
{
    public partial class ostalo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                ucitajProizvode();
        }

        private void ucitajProizvode()
        {
            repeaterOstalo.DataSource = ProizvodBL.UcitajProizvode(0, false, 6);
            repeaterOstalo.DataBind();
        }
    }
}