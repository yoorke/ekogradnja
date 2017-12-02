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
using ekogradnjaBE;
using ekogradnjaBL;

namespace ekogradnja
{
    public partial class betonske_cevi_kanalizacioni_elementi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Betonske cevi i kanalizacioni elementi | Proizvodni program";

            if (!Page.IsPostBack)
            {
                repeaterBetonskeCevi.DataSource = ProizvodBL.UcitajProizvode(0, false, 4);
                repeaterBetonskeCevi.DataBind();
            }
        }
    }
}
