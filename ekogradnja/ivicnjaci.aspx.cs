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
    public partial class ivicnjaci : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Ivičnjaci | Proizvodni program";

            if (!Page.IsPostBack)
            {
                repeaterIvicnjaci.DataSource = ProizvodBL.UcitajProizvode(0, false, 2);
                repeaterIvicnjaci.DataBind();
            }
        }
    }
}
