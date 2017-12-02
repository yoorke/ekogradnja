using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ekogradnjaBL;

namespace ekogradnjav2
{
    public partial class seme_polaganja_betonskih_elemenata : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                ucitajProizvode();
                string url = string.Empty;
                if (Page.RouteData.Values["url"] != null)
                    url = Page.RouteData.Values["url"].ToString();
                ViewState.Add("url", url);
                ucitajSeme();

                
            }
        }

        private void ucitajProizvode()
        {
            repeaterProizvodi.DataSource = ProizvodBL.UcitajProizvodeZaSeme();
            repeaterProizvodi.DataBind();
        }

        private void ucitajSeme()
        {
            repeaterSeme.DataSource = SemaBL.UcitajSeme(ViewState["url"].ToString());
            repeaterSeme.DataBind();
        }
    }
}