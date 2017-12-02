using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ekogradnjaBL;
using System.Configuration;

namespace ekogradnjav2
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ucitajProjekte();
                ucitajProizvode();
                //Response.Write(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            }
        }

        private void ucitajProjekte()
        {
            repeaterProjekti.DataSource = ProjekatBL.UcitajProjekte(true, DateTime.MinValue, DateTime.MaxValue.AddDays(-1), true);
            repeaterProjekti.DataBind();
        }

        private void ucitajProizvode()
        {
            //repeaterBetonskaGalanterija.DataSource = ProizvodBL.UcitajProizvode(0, true, 1);
            //repeaterBetonskaGalanterija.DataBind();
        }
    }
}