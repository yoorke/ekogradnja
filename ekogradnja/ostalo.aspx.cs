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
    public partial class ostalo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Ostalo | Proizvodni program";

            if (!Page.IsPostBack)
            {
                repeaterOstalo.DataSource = ProizvodBL.UcitajProizvode(0, false, 6);
                repeaterOstalo.DataBind();
            }
        }
    }
}
