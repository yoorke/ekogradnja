using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ekogradnjaBL;

namespace ekogradnjav2
{
    public partial class betonska_galanterija : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                ucitajProizvode();
        }

        private void ucitajProizvode()
        {
            repeaterProizvodi.DataSource = ProizvodBL.UcitajProizvode(0, false, 1);
            repeaterProizvodi.DataBind();
        }
    }
}