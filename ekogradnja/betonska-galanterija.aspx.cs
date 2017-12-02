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
    public partial class betonska_galanterija : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Betonska galanterija - proizvodnja, transport i ugradnja";
            HtmlMeta tag = new HtmlMeta();
            tag.Attributes.Add("name", "description");
            tag.Attributes.Add("content", "Betonska galanterija je primarna delatnost kompanije Ekogradnja. Duži niz godina bavimo se proizvodnjom, transportom i ugradnjom betonske galanterije.");
            Header.Controls.Add(tag);
            if (!Page.IsPostBack)
            {
                repeaterProizvodi.DataSource = ProizvodBL.UcitajProizvode(0, false, 1);
                repeaterProizvodi.DataBind();
            }
        }
    }
}
