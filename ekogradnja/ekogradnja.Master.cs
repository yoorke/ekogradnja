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

namespace ekogradnja
{
    public partial class ekogradnja : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                ucitajGlavniMenu();
        }

        private void ucitajGlavniMenu()
        {
            //DataSet menu = new DataSet();
            //menu.Tables.Add(MenuBL.UcitajStavkeMenu(0));
            //menu.Tables.Add(MenuBL.UcitajStavkeMenu(0));
            //menu.Relations.Add("relation", menu.Tables[0].Columns["idMenuStavka"], menu.Tables[1].Columns["idMenuUp"]);
            repeaterGlavniMenu.DataSource = MenuBL.UcitajMenu(1);
            repeaterGlavniMenu.DataBind();

            /*repeaterGlavniMenu.DataSource = MenuBL.UcitajStavkeMenu(1);
            repeaterGlavniMenu.DataBind();*/
        }

        protected void repeaterSubMenu_DataBinding(object sender, EventArgs e)
        {
            /*Repeater repeater = (Repeater)sender;
            int idMenu = (int)(Eval("idMenu"));

            repeater.DataSource = MenuBL.UcitajStavkeMenu(idMenu);
            repeater.DataBind();*/
        }

        protected void repeaterGlavniMenu_ItemCreated(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
        {
            /*Repeater r = ((Repeater)e.Item.FindControl("repeaterSubMenu"));
            r.ItemCommand += new RepeaterCommandEventHandler(repeaterSubMenu_ItemCommand);
            r.ItemDataBound += new RepeaterItemEventHandler(r_ItemDataBound);*/
        }

        void r_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            /*if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DataRowView drv = (DataRowView)e.Item.DataItem;
                int idMenu = int.Parse(drv["idMenu"].ToString());

                Repeater r = ((Repeater)e.Item.FindControl("repeaterSubMenu"));
                r.DataSource = MenuBL.UcitajStavkeMenu(idMenu);
                r.DataBind();
            }*/
        }

        private void repeaterSubMenu_ItemCommand(object sender, RepeaterCommandEventArgs e)
        {

        }

        protected void repeaterPreRender(object sender, EventArgs e)
        {
            //if (repeaterSubMenu.Items.Count < 1)
                //container.Visible = false;
        }

        protected void repeaterGlavniMenu_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Repeater repeater = (Repeater)repeaterGlavniMenu.FindControl("repeaterSubMenu");
                repeater = ((Repeater)e.Item.FindControl("repeaterSubMenu"));
                //if (repeater.Items.Count == 0)
                    //repeater.Visible = false;
            }
        }
    }
}
