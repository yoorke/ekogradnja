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
    public partial class Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string query = Page.Request["url"];

                ekogradnjaBE.Page page = PageBL.LoadPage(0, query);

                lblNaslov.Text = page.Title;
                txtContent.InnerHtml = page.Content;
                Page.Title = page.Title;
            }
        }
    }
}
