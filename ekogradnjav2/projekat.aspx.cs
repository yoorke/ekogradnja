using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ekogradnjaBE;
using ekogradnjaBL;
using System.Data;
using System.IO;

namespace ekogradnjav2
{
    public partial class projekat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string url = Page.RouteData.Values["url"].ToString();

                Projekat projekat = ProjekatBL.UcitajProjekat(0, url);

                lblNazivProjekta.Text = projekat.NazivProjekta;
                lblDatumProjekta.Text = projekat.DatumProjekta.ToShortDateString();
                lblOpisProjekta.Text = projekat.OpisProjekta;
                lblSadrzaj.Text = projekat.Sadrzaj;

                Page.Title = projekat.NazivProjekta + " | Projekti";
                ViewState.Add("nazivProjekta", projekat.NazivProjekta);

                repeaterSlike.DataSource = ucitajGaleriju(projekat.IdProjekta);
                repeaterSlike.DataBind();
            }
        }

        private DataTable ucitajGaleriju(int idProjekta)
        {
            DataTable galerija = new DataTable();
            galerija.Columns.Add("url");
            galerija.Columns.Add("rb");
            DataRow noviRed;

            for (int i = 1; i < 100; i++)
            {
                if (File.Exists(Server.MapPath("~/images/projekti/" + idProjekta.ToString() + "-" + i.ToString() + ".jpg")))
                {
                    noviRed = galerija.NewRow();
                    noviRed["url"] = "/images/projekti/" + idProjekta.ToString() + "-" + i.ToString();
                    noviRed["rb"] = i.ToString();
                    galerija.Rows.Add(noviRed);
                }
            }

            return galerija;
        }
    }
}