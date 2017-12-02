using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using ekogradnjaBE;
using ekogradnjaBL;
using System.Web.UI.HtmlControls;

namespace ekogradnjav2
{
    public partial class proizvod : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                string opis = string.Empty;
                if (Page.RouteData.Values["opis"] != null)
                    opis = Page.RouteData.Values["opis"].ToString();
                if (opis.Contains(" data-width"))
                    opis = opis.Remove(opis.IndexOf(" data-width"), opis.Length - opis.IndexOf(" data-width"));

                StringBuilder sb = new StringBuilder();
                for (int i = opis.Length - 1; i > 0; i--)
                {
                    if (opis[i] == '-')
                        break;
                    if (char.IsDigit(opis[i]))
                        sb.Insert(0, opis[i]);
                }

                Proizvod proizvod = ProizvodBL.UcitajProizvod(int.Parse(sb.ToString()), string.Empty);
                ViewState.Add("nazivProizvoda", proizvod.NazivProizvoda);

                string nazivTipaProizvoda = string.Empty;
                switch (proizvod.IdTipaProizvoda)
                {
                    case 1: nazivTipaProizvoda = "Betonska galanterija"; break;
                    case 2: nazivTipaProizvoda = "Ivičnjaci"; break;
                    case 3: nazivTipaProizvoda = "Rigole"; break;
                    case 4: nazivTipaProizvoda = "Betonske cevi i kanalizacioni elementi"; break;
                    case 5: nazivTipaProizvoda = "Transportni beton"; break;
                    case 6: nazivTipaProizvoda = "Ostalo"; break;
                }
                ViewState.Add("nazivTipaProizvoda", nazivTipaProizvoda);


                ViewState.Add("idProizvoda", proizvod.IdProizvoda);
                ViewState.Add("opisProizvoda", proizvod.OpisProizvoda.Length >= 200 ? proizvod.OpisProizvoda.Substring(0, 200) + "..." : proizvod.OpisProizvoda + "...");

                lblNaziv.Text = proizvod.NazivProizvoda;
                lblOpisProizvoda.Text = proizvod.OpisProizvoda;

                imgProizvod.ImageUrl = "./images/proizvodi/" + proizvod.IdProizvoda.ToString() + "-1.jpg";
                imgProizvod.AlternateText = proizvod.NazivProizvoda;

                if (File.Exists(Server.MapPath("~/images/proizvodi/" + ViewState["idProizvoda"].ToString() + "-5.jpg")))
                    imgDimenzije.ImageUrl = "./images/proizvodi/" + proizvod.IdProizvoda.ToString() + "-5.jpg";
                else
                    imgDimenzije.Visible = false;
                imgDimenzije.AlternateText = "Dimenzija " + proizvod.NazivProizvoda;

                /*imgPrimer.ImageUrl = "./images/proizvodi/" + proizvod.IdProizvoda.ToString() + "-4.jpg";*/
                imgBoje.ImageUrl = "./images/proizvodi/" + proizvod.IdProizvoda.ToString() + "-6.jpg";

                prikaziSlike();

                podesiTabeluDimenzije(proizvod.IdTipaProizvoda);

                if (proizvod.IdTipaProizvoda == 1 || proizvod.IdTipaProizvoda == 2 || proizvod.IdTipaProizvoda == 3 || proizvod.IdTipaProizvoda == 6)
                {
                    dgvDimenzije1.DataSource = proizvod.Dimenzije;
                    dgvDimenzije1.DataBind();
                    dgvDimenzije2.Visible = false;
                }
                else if (proizvod.IdTipaProizvoda == 4)
                {
                    dgvDimenzije2.DataSource = proizvod.Dimenzije;
                    dgvDimenzije2.DataBind();
                    dgvDimenzije1.Visible = false;
                }

                repeaterBoje.DataSource = proizvod.Boje;
                repeaterBoje.DataBind();

                lblNazivProizvoda.Text = proizvod.NazivProizvoda;
                lnkSemePolaganja.NavigateUrl = "/seme-polaganja-betonskih-elemenata/" + proizvod.Url;
            }
            Page.Title = ViewState["nazivProizvoda"].ToString() + " | " + ViewState["nazivTipaProizvoda"].ToString() + " | " + "Proizvodni program";
            like.InnerHtml = "<div class='fb-like' data-href='http://www.ekogradnja.rs" + Page.Request.RawUrl + "' data-width='200' data-layout='button_count' data-action='like' data-show-faces='false' data-share='true'></div>";

            HtmlMeta tag = new HtmlMeta();
            tag.Attributes.Clear();
            tag.Attributes.Add("property", "fb:admins");
            tag.Attributes.Add("content", "1014054126");
            Header.Controls.Add(tag);

            tag = new HtmlMeta();
            tag.Attributes.Clear();
            tag.Attributes.Add("property", "og:title");
            tag.Attributes.Add("content", ViewState["nazivProizvoda"].ToString() + " - Betonska galanterija");
            Header.Controls.Add(tag);

            tag = new HtmlMeta();
            tag.Attributes.Clear();
            tag.Attributes.Add("property", "og:type");
            tag.Attributes.Add("content", "product");
            Header.Controls.Add(tag);

            tag = new HtmlMeta();
            tag.Attributes.Clear();
            tag.Attributes.Add("property", "og:url");
            tag.Attributes.Add("content", "http://www.ekogradnja.rs" + Page.Request.RawUrl);
            Header.Controls.Add(tag);

            tag = new HtmlMeta();
            tag.Attributes.Clear();
            tag.Attributes.Add("property", "og:image");
            tag.Attributes.Add("content", "http://www.ekogradnja.rs/images/proizvodi/" + ViewState["idProizvoda"].ToString() + "-1.jpg");
            Header.Controls.Add(tag);

            tag = new HtmlMeta();
            tag.Attributes.Clear();
            tag.Attributes.Add("property", "og:site_name");
            tag.Attributes.Add("content", "Ekogradnja - proizvodnja betonske galanterije");
            Header.Controls.Add(tag);

            tag = new HtmlMeta();
            tag.Attributes.Clear();
            tag.Attributes.Add("property", "og:description");
            tag.Attributes.Add("content", ViewState["opisProizvoda"].ToString());
            Header.Controls.Add(tag);
        }

        protected void imgProizvod1_Click(object sender, ImageClickEventArgs e)
        {
            imgProizvod.ImageUrl = "/images/proizvodi/" + ViewState["idProizvoda"].ToString() + "-1.jpg";
        }

        protected void imgProizvod2_Click(object sender, ImageClickEventArgs e)
        {
            imgProizvod.ImageUrl = "/images/proizvodi/" + ViewState["idProizvoda"].ToString() + "-2.jpg";
        }

        protected void imgProizvod3_Click(object sender, ImageClickEventArgs e)
        {
            imgProizvod.ImageUrl = "/images/proizvodi/" + ViewState["idProizvoda"].ToString() + "-3.jpg";
        }

        protected void imgProizvod4_Click(object sender, ImageClickEventArgs e)
        {
            imgProizvod.ImageUrl = "/images/proizvodi/" + ViewState["idProizvoda"].ToString() + "-4.jpg";
        }

        private void prikaziSlike()
        {
            imgProizvod1.ImageUrl = "/images/proizvodi/" + ViewState["idProizvoda"].ToString() + "-1-thumb.jpg";
            if (File.Exists(Server.MapPath("~/images/proizvodi/" + ViewState["idProizvoda"].ToString() + "-2-thumb.jpg")))
            {
                imgProizvod2.ImageUrl = "/images/proizvodi/" + ViewState["idProizvoda"].ToString() + "-2-thumb.jpg";
            }
            else
                imgProizvod2.Visible = false;
            if (File.Exists(Server.MapPath("~/images/proizvodi/" + ViewState["idProizvoda"].ToString() + "-3-thumb.jpg")))
            {
                imgProizvod3.ImageUrl = "/images/proizvodi/" + ViewState["idProizvoda"].ToString() + "-3-thumb.jpg";
            }
            else
                imgProizvod3.Visible = false;
            if (File.Exists(Server.MapPath("~/images/proizvodi/" + ViewState["idProizvoda"].ToString() + "-4-thumb.jpg")))
            {
                imgProizvod4.ImageUrl = "/images/proizvodi/" + ViewState["idProizvoda"].ToString() + "-4-thumb.jpg";
            }
            else
                imgProizvod4.Visible = false;
        }

        private void podesiTabeluDimenzije(int idTipaProizvoda)
        {
            if (idTipaProizvoda == 2 || idTipaProizvoda == 3 || idTipaProizvoda == 6)
            {
                dgvDimenzije1.Columns[2].HeaderText = "š x v x d [cm]";
                dgvDimenzije1.Columns[3].HeaderText = "kom/m";
                dgvDimenzije1.Columns[4].HeaderText = "kom/pal";
            }
        }
    }
}