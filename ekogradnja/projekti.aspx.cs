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
using System.IO;

namespace ekogradnja
{
    public partial class projekti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Projekti | Ekogradnja - proizvodnja betonske galanterije";

            if (!Page.IsPostBack)
            {
                repeaterProjekti.DataSource = ProjekatBL.UcitajProjekte(false, DateTime.MinValue, DateTime.MaxValue.AddDays(-1), true);
                repeaterProjekti.DataBind();
            }
        }

        protected void repeaterProjekti_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                if (!File.Exists(Server.MapPath(((Image)e.Item.FindControl("imgProjekat1")).ImageUrl.ToString())))
                    ((Image)e.Item.FindControl("imgProjekat1")).Visible = false;

                if (!File.Exists(Server.MapPath(((Image)e.Item.FindControl("imgProjekat2")).ImageUrl.ToString())))
                    ((Image)e.Item.FindControl("imgProjekat2")).Visible = false;

                if (!File.Exists(Server.MapPath(((Image)e.Item.FindControl("imgProjekat3")).ImageUrl.ToString())))
                    ((Image)e.Item.FindControl("imgProjekat3")).Visible = false;
            }
        }
    }
}
