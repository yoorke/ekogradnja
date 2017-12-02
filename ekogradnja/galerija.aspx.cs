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
using System.IO;
using ekogradnjaBL;

namespace ekogradnja
{
    public partial class galerija : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Galerija slika završenih projekata i projekata u izradi";

            if (!Page.IsPostBack)
            {
                string godina = "2013";
                if (Page.Request.QueryString.ToString().Contains("godina"))
                {
                    godina = Page.Request.QueryString["godina"];
                }
                ViewState.Add("godina", godina);
                Page.Title += " za " + godina;

                /*galleryProizvodi.DataSource = ucitajGaleriju("proizvodi");
                galleryProizvodi.DataBind();*/

                if (godina != string.Empty)
                {
                    //KreirajGaleriju();
                    galleryProjekti.DataSource = KreirajGaleriju(); //GalerijaBL.UcitajGaleriju("", DateTime.MinValue, DateTime.MaxValue);//ucitajGaleriju("projekti");
                    galleryProjekti.DataBind();
                    lblGodina.Text = "Godina: " + ViewState["godina"].ToString();
                }
            }
        }

        private DataTable KreirajGaleriju()
        {
            DateTime datumOd = new DateTime(int.Parse(ViewState["godina"].ToString()),1,1);
            DateTime datumDo = new DateTime(int.Parse(ViewState["godina"].ToString()), 12, 31);
            DataTable projekti = ProjekatBL.UcitajProjekte(false, datumOd, datumDo, true);

            DataTable galerija = new DataTable();
            galerija.Columns.Add("url");
            galerija.Columns.Add("alt");
            DataRow noviRed;

            for(int i=0; i < projekti.Rows.Count; i++)
                for (int j = 1; j < 36; j++)
                {
                    if (File.Exists(Server.MapPath("~/images/projekti/" + projekti.Rows[i][0].ToString() + "-" + j.ToString() + "-thumb.jpg")))
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
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {

            }
        }
    }
}
