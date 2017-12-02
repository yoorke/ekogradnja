using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ekogradnjaBL;
using System.Data;
using System.IO;

namespace ekogradnjav2
{
    public partial class galerija : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                string godina = "2013";
                if(Page.RouteData.Values["godina"] != null)
                {
                    godina = Page.RouteData.Values["godina"].ToString();
                }
                ViewState.Add("godina", godina);
                Page.Title += "za " + godina;

                if(godina != string.Empty)
                {
                    galleryProjekti.DataSource = kreirajGaleriju();
                    galleryProjekti.DataBind();
                    lblGodina.Text = "Godina: " + ViewState["godina"].ToString();
                }
            }
        }

        private DataTable kreirajGaleriju()
        {
            DateTime datumOd = new DateTime(int.Parse(ViewState["godina"].ToString()), 1, 1);
            DateTime datumDo = new DateTime(int.Parse(ViewState["godina"].ToString()), 12, 31);

            DataTable projekti = ProjekatBL.UcitajProjekte(false, datumOd, datumDo, true);

            DataTable galerija = new DataTable();
            galerija.Columns.Add("url");
            galerija.Columns.Add("alt");
            DataRow noviRed;

            for(int i = 0; i < projekti.Rows.Count;i++)
                for(int j=1;j<36;j++)
                {
                    if(File.Exists(Server.MapPath("~/images/projekti/" + projekti.Rows[i][0].ToString() + "-" + j.ToString() + "-thumb.jpg")))
                    {
                        noviRed = galerija.NewRow();
                        noviRed["url"] = "/images/projekti/" + projekti.Rows[i][0].ToString() + "-" + j.ToString();
                        noviRed["alt"] = projekti.Rows[i]["nazivProjekta"].ToString() + " - Slika " + j.ToString();
                        galerija.Rows.Add(noviRed);
                    }
                }
            return galerija;
               
        }

        protected void galleryProjekti_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

        }
    }
}