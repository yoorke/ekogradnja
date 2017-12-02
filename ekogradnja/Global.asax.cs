using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Xml.Linq;
using System.Xml;
using ekogradnjaBL;
using ekogradnjaBE;

namespace ekogradnja
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //kreirajSiteMap();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            /*if (Request.RawUrl.ToString().EndsWith("/"))
            {
                Response.Status = "301 Moved Permanently";
                Response.StatusCode = 301;
                Response.AddHeader("Location", Request.RawUrl.ToString().Substring(0, Request.RawUrl.ToString().Length - 1));
            }*/

            /*if (Request.RawUrl.ToString().Contains(".jpg?"))
            {
                Response.Status = "301 Moved Permanently";
                Response.StatusCode = 301;
                Response.AddHeader("Location", Request.RawUrl.ToString().Substring(0, Request.RawUrl.ToString().IndexOf(".jpg?") + 4));
            }*/
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

        protected void kreirajSiteMap()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlTextWriter xmlWriter = new XmlTextWriter(Server.MapPath("~/Web.sitemap"), System.Text.Encoding.UTF8);
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");
            xmlWriter.WriteStartElement("siteMap", "http://schemas.microsoft.com/AspNet/SiteMap-File-1.0");
            xmlWriter.Close();

            xmlDoc.Load(Server.MapPath("~/Web.sitemap"));

            XmlElement xmlRoot = xmlDoc.DocumentElement;
            XmlElement xmlSitemapDefault = null;
            XmlElement xmlSitemap = null;

            MenuStavkaList menu = MenuBL.UcitajMenu(1);
            for (int i = 0; i < menu.Count; i++)
            {
                if (i == 0)
                {
                    xmlSitemapDefault = xmlDoc.CreateElement("siteMapNode");
                    xmlSitemapDefault.SetAttribute("url", menu[i].Url);
                    xmlSitemapDefault.SetAttribute("title", menu[i].Naziv);
                    xmlSitemapDefault.SetAttribute("description", menu[i].Naziv);

                }
                else
                {
                    xmlSitemap = xmlDoc.CreateElement("siteMapNode");
                    xmlSitemap.SetAttribute("url", menu[i].Url);
                    xmlSitemap.SetAttribute("title", menu[i].Naziv);
                    xmlSitemap.SetAttribute("description", menu[i].Naziv);
                    
                }

                XmlElement xmlSitemapMenu = null;
                if (menu[i].Podmenu.Count > 0)
                {
                    
                    for (int j = 0; j < menu[i].Podmenu.Count; j++)
                    {
                        xmlSitemapMenu = xmlDoc.CreateElement("siteMapNode");
                        xmlSitemapMenu.SetAttribute("url", menu[i].Podmenu[j].Url);
                        xmlSitemapMenu.SetAttribute("title", menu[i].Podmenu[j].Naziv);
                        xmlSitemapMenu.SetAttribute("description", menu[i].Podmenu[j].Naziv);

                        if (i < 3)
                        {
                            DataTable proizvodi = ProizvodBL.UcitajProizvode(-1, false, menu[i].Podmenu[j].RedniBroj);
                            XmlElement xmlSitemapProizvodi;
                            for (int l = 0; l < proizvodi.Rows.Count; l++)
                            {
                                xmlSitemapProizvodi = xmlDoc.CreateElement("siteMapNode");
                                xmlSitemapProizvodi.SetAttribute("url", proizvodi.Rows[l]["url"].ToString());
                                xmlSitemapProizvodi.SetAttribute("title", proizvodi.Rows[l]["nazivProizvoda"].ToString());
                                xmlSitemapProizvodi.SetAttribute("description", proizvodi.Rows[l]["nazivProizvoda"].ToString());
                                xmlSitemapMenu.AppendChild(xmlSitemapProizvodi);
                            }
                            
                        }
                        if (i == 8 && j == 2)
                        {
                            DataTable proizvodiSeme = ProizvodBL.UcitajProizvodeZaSeme();
                            XmlElement xmlSitemapProizvodiZaSeme;
                            for (int l = 1; l < proizvodiSeme.Rows.Count; l++)
                            {
                                xmlSitemapProizvodiZaSeme = xmlDoc.CreateElement("siteMapNode");
                                xmlSitemapProizvodiZaSeme.SetAttribute("url", "/seme-polaganja-betonskih-elemenata/" + proizvodiSeme.Rows[l]["url"].ToString());
                                xmlSitemapProizvodiZaSeme.SetAttribute("title", proizvodiSeme.Rows[l]["nazivProizvoda"].ToString());
                                xmlSitemapProizvodiZaSeme.SetAttribute("description", proizvodiSeme.Rows[l]["nazivProizvoda"].ToString());
                                xmlSitemapMenu.AppendChild(xmlSitemapProizvodiZaSeme);
                            }
                        }
                        xmlSitemap.AppendChild(xmlSitemapMenu);    
                        
                    }
                    
                }
                else if(i==4 || i==5)
                {
                    if (i == 4)
                    {
                        DataTable projekti = ProjekatBL.UcitajProjekte(false, DateTime.MinValue, DateTime.MaxValue.AddDays(-1), true);
                        /*xmlSitemapMenu = xmlDoc.CreateElement("siteMapNode");
                        xmlSitemapMenu.SetAttribute("url", "/PROJEKTI");
                        xmlSitemapMenu.SetAttribute("title", "PROJEKTI");
                        xmlSitemapMenu.SetAttribute("description", "PROJEKTI");*/
                        XmlElement xmlSitemapProjekti;
                        for (int l = 0; l < projekti.Rows.Count; l++)
                        {
                            xmlSitemapProjekti = xmlDoc.CreateElement("siteMapNode");
                            xmlSitemapProjekti.SetAttribute("url", "/projekti/" + projekti.Rows[l]["url"].ToString());
                            xmlSitemapProjekti.SetAttribute("title", projekti.Rows[l]["nazivProjekta"].ToString());
                            xmlSitemapProjekti.SetAttribute("description", projekti.Rows[l]["nazivProjekta"].ToString());
                            xmlSitemap.AppendChild(xmlSitemapProjekti);
                        }
                    }
                    else if (i == 5)
                    {
                        /*xmlSitemapMenu = xmlDoc.CreateElement("siteMapNode");
                        xmlSitemapMenu.SetAttribute("url", "/GALERIJA");
                        xmlSitemapMenu.SetAttribute("title", "GALERIJA");
                        xmlSitemapMenu.SetAttribute("description", "GALERIJA");*/
                        XmlElement xmlSitemapGalerija;
                        xmlSitemapGalerija = xmlDoc.CreateElement("siteMapNode");
                        xmlSitemapGalerija.SetAttribute("url", "/galerija/2013");
                        xmlSitemapGalerija.SetAttribute("title", "2013");
                        xmlSitemapGalerija.SetAttribute("description", "2013");
                        xmlSitemap.AppendChild(xmlSitemapGalerija);
                    }
                    //xmlSitemap.AppendChild(xmlSitemapGalerija);
                }
                if (i > 0)
                    xmlSitemapDefault.AppendChild(xmlSitemap);
            }

            xmlRoot.AppendChild(xmlSitemapDefault);




            
            /*xmlSitemapDefault = xmlDoc.CreateElement("siteMapNode");
            xmlSitemapDefault.SetAttribute("url", "./");
            xmlSitemapDefault.SetAttribute("title", "Početna strana");
            xmlSitemapDefault.SetAttribute("description", "Pocetna strana");
            xmlRoot.AppendChild(xmlSitemapDefault);

            XmlElement xmlSitemap;
            xmlSitemap = xmlDoc.CreateElement("siteMapNode");
            xmlSitemap.SetAttribute("url", "./o-nama");
            xmlSitemap.SetAttribute("title", "O nama");
            xmlSitemap.SetAttribute("description", "O nama");
            xmlSitemapDefault.AppendChild(xmlSitemap);

            xmlSitemap = xmlDoc.CreateElement("siteMapNode");
            xmlSitemap.SetAttribute("url", "./proizvodni-program");
            xmlSitemap.SetAttribute("title", "Proizvodni program");
            xmlSitemap.SetAttribute("description", "Proizvodni program");
            

            XmlElement xmlSitemapProizvodniProgram;
            xmlSitemapProizvodniProgram = xmlDoc.CreateElement("siteMapNode");
            xmlSitemapProizvodniProgram.SetAttribute("url", "./betonska-galanterija");
            xmlSitemapProizvodniProgram.SetAttribute("title", "Betonska galanterija");
            xmlSitemapProizvodniProgram.SetAttribute("description", "Betonska galanterija");
            

            DataTable proizvodi = ProizvodBL.UcitajProizvode(-1, false, 1);
            XmlElement xmlSitemapProizvodi;
            for (int i = 0; i < proizvodi.Rows.Count; i++)
            {
                xmlSitemapProizvodi = xmlDoc.CreateElement("siteMapNode");
                xmlSitemapProizvodi.SetAttribute("url", proizvodi.Rows[i]["url"].ToString());
                xmlSitemapProizvodi.SetAttribute("title", proizvodi.Rows[i]["nazivProizvoda"].ToString());
                xmlSitemapProizvodi.SetAttribute("description", proizvodi.Rows[i]["nazivProizvoda"].ToString());
                xmlSitemapProizvodniProgram.AppendChild(xmlSitemapProizvodi);
            }
            xmlSitemap.AppendChild(xmlSitemapProizvodniProgram);

            xmlSitemapProizvodniProgram = xmlDoc.CreateElement("siteMapNode");
            xmlSitemapProizvodniProgram.SetAttribute("url", "./ivicnjaci");
            xmlSitemapProizvodniProgram.SetAttribute("title", "Ivičnjaci");
            xmlSitemapProizvodniProgram.SetAttribute("description", "Ivičnjaci");
            

            proizvodi = ProizvodBL.UcitajProizvode(-1, false, 2);
            for (int i = 0; i < proizvodi.Rows.Count; i++)
            {
                xmlSitemapProizvodi = xmlDoc.CreateElement("siteMapNode");
                xmlSitemapProizvodi.SetAttribute("url", proizvodi.Rows[i]["url"].ToString());
                xmlSitemapProizvodi.SetAttribute("title", proizvodi.Rows[i]["nazivProizvoda"].ToString());
                xmlSitemapProizvodi.SetAttribute("description", proizvodi.Rows[i]["nazivProizvoda"].ToString());
                xmlSitemapProizvodniProgram.AppendChild(xmlSitemapProizvodi);
            }
            xmlSitemap.AppendChild(xmlSitemapProizvodniProgram);

            xmlSitemapProizvodniProgram = xmlDoc.CreateElement("siteMapNode");
            xmlSitemapProizvodniProgram.SetAttribute("url", "./rigole");
            xmlSitemapProizvodniProgram.SetAttribute("title", "Rigole");
            xmlSitemapProizvodniProgram.SetAttribute("description", "Rigole");
            xmlSitemap.AppendChild(xmlSitemapProizvodniProgram);

            xmlSitemapProizvodniProgram = xmlDoc.CreateElement("siteMapNode");
            xmlSitemapProizvodniProgram.SetAttribute("url", "./betonske-cevi-kanalizacioni-elementi");
            xmlSitemapProizvodniProgram.SetAttribute("title", "Betonske cevi i kanalizacioni elementi");
            xmlSitemapProizvodniProgram.SetAttribute("description", "Betonske cevi i kanalizacioni elementi");
            

            proizvodi = ProizvodBL.UcitajProizvode(-1, false, 4);
            for (int i = 0; i < proizvodi.Rows.Count; i++)
            {
                xmlSitemapProizvodi = xmlDoc.CreateElement("siteMapNode");
                xmlSitemapProizvodi.SetAttribute("url", proizvodi.Rows[i]["url"].ToString());
                xmlSitemapProizvodi.SetAttribute("title", proizvodi.Rows[i]["nazivProizvoda"].ToString());
                xmlSitemapProizvodi.SetAttribute("description", proizvodi.Rows[i]["nazivProizvoda"].ToString());
                xmlSitemapProizvodniProgram.AppendChild(xmlSitemapProizvodi);
            }
            xmlSitemap.AppendChild(xmlSitemapProizvodniProgram);

            xmlSitemapProizvodniProgram = xmlDoc.CreateElement("siteMapNode");
            xmlSitemapProizvodniProgram.SetAttribute("url", "./transportni-beton");
            xmlSitemapProizvodniProgram.SetAttribute("title", "Transportni beton i agregat");
            xmlSitemapProizvodniProgram.SetAttribute("description", "Transportni beton i agregat");
            xmlSitemap.AppendChild(xmlSitemapProizvodniProgram);

            xmlSitemapProizvodniProgram = xmlDoc.CreateElement("siteMapNode");
            xmlSitemapProizvodniProgram.SetAttribute("url", "./ostalo");
            xmlSitemapProizvodniProgram.SetAttribute("title", "Ostalo");
            xmlSitemapProizvodniProgram.SetAttribute("description", "Ostalo");
            

            proizvodi = ProizvodBL.UcitajProizvode(-1, false, 6);
            for (int i = 0; i < proizvodi.Rows.Count; i++)
            {
                xmlSitemapProizvodi = xmlDoc.CreateElement("siteMapNode");
                xmlSitemapProizvodi.SetAttribute("url", proizvodi.Rows[i]["url"].ToString());
                xmlSitemapProizvodi.SetAttribute("title", proizvodi.Rows[i]["nazivProizvoda"].ToString());
                xmlSitemapProizvodi.SetAttribute("description", proizvodi.Rows[i]["nazivProizvoda"].ToString());
                xmlSitemapProizvodniProgram.AppendChild(xmlSitemapProizvodi);
            }
            xmlSitemap.AppendChild(xmlSitemapProizvodniProgram);

            xmlSitemapDefault.AppendChild(xmlSitemap);*/

            xmlDoc.Save(Server.MapPath("~/Web.sitemap"));
        }
    }
}