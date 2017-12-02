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
using ekogradnjaBL;
using ekogradnjaBE;

namespace ekogradnjav2.userControls
{
    public partial class Slider : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                loadSlider();
        }

        private void loadSlider()
        {
            rptSlider.DataSource = new SliderBL().GetSliderItems(1);
            rptSlider.DataBind();
        }

        protected void rptSlider_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if(e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                if (((Literal)e.Item.FindControl("lblCaption")).Text == string.Empty)
                    ((HtmlContainerControl)e.Item.FindControl("divCaption")).Visible = false;
            }
        }
    }
}