using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using ekogradnjaBL;

namespace ekogradnja
{
    public partial class seme_polaganja_betonskih_elemenata : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Page.Title = "Šeme polaganja betonskih elemenata | Uputstva";
                ucitajProizvode();

                string url = string.Empty;
                if (Page.Request.QueryString.ToString().Contains("url"))
                {
                    url = Page.Request.QueryString["url"];
                }
                ViewState.Add("url", url);
                //if (url != string.Empty)
                //{
                    ucitajSeme();
                //}


                    lblNaslov.Text = (url != string.Empty) ? "Šeme polaganja za " + ProizvodBL.UcitajProizvod(-1, url).NazivProizvoda : "Šeme polaganja betonskih elemenata";
                    Page.Title = "Šeme polaganja betonskih elemenata - " + ViewState["url"].ToString();
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

            if (repeaterSeme.Items.Count == 0)
                lblStatus.Text = "Ne postoje šeme za odabrani element";
        }
    }
}
