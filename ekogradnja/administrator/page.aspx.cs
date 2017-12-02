using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using ekogradnjaBE;
using ekogradnjaBL;

namespace ekogradnja.administrator
{
    public partial class page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSacuvaj_Click(object sender, EventArgs e)
        {
            ekogradnjaBE.Page page = new ekogradnjaBE.Page();
            page.IdPage = int.Parse(txtIdPage.Text);
            page.Title = txtTitle.Text;
            page.Description = txtDescription.Text;
            page.Keywords = txtKeywords.Text;
            page.Content = txtContent.Text;
            page.Url = txtUrl.Text;

            PageBL.Save(page, true);
        }
    }
}
