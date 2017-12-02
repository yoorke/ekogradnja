using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ekogradnjaBL;
using System.IO;

namespace ekogradnjav2
{
    public partial class projekti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                ucitajProjekte();
        }

        private void ucitajProjekte()
        {
            repeaterProjekti.DataSource = ProjekatBL.UcitajProjekte(false, DateTime.MinValue, DateTime.MaxValue.AddDays(-1), true);
            repeaterProjekti.DataBind();
        }

        protected void repeaterProjekti_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if(e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                //if (!File.Exists(Server.MapPath(((Image)e.Item.FindControl("imgProjekat1")).ImageUrl.ToString())))
                    //((Image)e.Item.FindControl("imgProjekat1")).Visible = false;
                //if (!File.Exists(Server.MapPath(((Image)e.Item.FindControl("imgProjekat2")).ImageUrl.ToString())))
                    //((Image)e.Item.FindControl("imgProjekat2")).Visible = false;
                //if (!File.Exists(Server.MapPath(((Image)e.Item.FindControl("imgProjekat3")).ImageUrl.ToString())))
                    //((Image)e.Item.FindControl("imgProjekat3")).Visible = false;
            }
        }
    }
}