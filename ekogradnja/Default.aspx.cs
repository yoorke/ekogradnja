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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Ekogradnja - betonska galanterija, proizvodnja, transport i ugradnja";

            if (!Page.IsPostBack)
            {
                ucitajProizvode();

                ucitajProjekte();
            }

            
        }

        private void ucitajProizvode()
        {
            repeaterProizvodi.DataSource = ProizvodBL.UcitajProizvode(0, true, 1);
            repeaterProizvodi.DataBind();
        }

        private void ucitajProjekte()
        {
            repeaterProjekti.DataSource = ProjekatBL.UcitajProjekte(true, DateTime.MinValue, DateTime.MaxValue.AddDays(-1), true);
            repeaterProjekti.DataBind();
        }
    }
}
