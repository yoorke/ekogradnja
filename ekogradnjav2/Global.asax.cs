using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;
using Utility;

namespace ekogradnjav2
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            Utility.ExceptionHandling.ExceptionLog.LogError(ex);
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

        private void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("betonska-galanterija-proizvodi", "betonska-galanterija/{opis}", "~/proizvod.aspx", false);
            routes.MapPageRoute("betonska-galanterija", "betonska-galanterija", "~/betonska-galanterija.aspx", false);
            routes.MapPageRoute("ivicnjaci-proizvodi", "ivicnjaci/{opis}", "~/proizvod.aspx", false);
            routes.MapPageRoute("ivicnjaci", "ivicnjaci", "~/ivicnjaci.aspx", false);
            routes.MapPageRoute("rigole-i-kanalete-proizvodi", "rigole-i-kanalete/{opis}", "~/proizvod.aspx", false);
            routes.MapPageRoute("rigole-i-kanalete", "rigole-i-kanalete", "~/rigole-i-kanalete.aspx", false);
            routes.MapPageRoute("betonske-cevi-kanalizacioni-elementi-proizvodi", "betonske-cevi-kanalizacioni-elementi/{opis}", "~/proizvod.aspx", false);
            routes.MapPageRoute("betonske-cevi-kanalizacioni-elementi", "betonske-cevi-kanalizacioni-elementi", "~/betonske-cevi-i-kanalizacioni-elementi.aspx", false);
            routes.MapPageRoute("transportni-beton", "transportni-beton", "~/transportni-beton-i-agregat.aspx", false);
            routes.MapPageRoute("ostalo-proizvodi", "ostalo/{opis}", "~/proizvod.aspx", false);
            routes.MapPageRoute("ostalo", "ostalo", "~/ostalo.aspx", false);
            routes.MapPageRoute("delatnosti", "delatnosti", "~/delatnosti.aspx", false);
            routes.MapPageRoute("projekti-projekat", "projekti/{url}", "~/projekat.aspx", false);
            routes.MapPageRoute("projekti", "projekti", "~/projekti.aspx", false);
            routes.MapPageRoute("galerija-godina", "galerija/{godina}", "~/galerija.aspx", false);
            routes.MapPageRoute("galerija", "galerija", "~/galerija.aspx", false);
            routes.MapPageRoute("kontakt", "kontakt", "~/kontakt.aspx", false);
            routes.MapPageRoute("dokumenti", "dokumenti", "~/dokumenti.aspx", false);
            routes.MapPageRoute("uputstva", "uputstva", "~/uputstva.aspx", false);
            routes.MapPageRoute("o-nama", "o-nama", "~/o-nama.aspx", false);
            //routes.MapPageRoute("uputstva", "uputstva", "~/uputstva.aspx", false);
            routes.MapPageRoute("kako-postaviti-betonske-elemente", "kako-postaviti-betonske-elemente", "~/kako-postaviti-betonske-elemente.aspx", false);
            routes.MapPageRoute("slojevi-tla-za-preopterecenje", "slojevi-tla-za-preopterecenje", "~/slojevi-tla-za-preopterecenje.aspx", false);
            routes.MapPageRoute("seme-polaganja-betonskih-elemenata", "seme-polaganja-betonskih-elemenata", "~/seme-polaganja-betonskih-elemenata.aspx", false);
            routes.MapPageRoute("seme-polaganja-betonskih-elemenata1", "seme-polaganja-betonskih-elemenata/{url}", "~/seme-polaganja-betonskih-elemenata.aspx", false);
            routes.MapPageRoute("gde-se-nalazimo", "gde-se-nalazimo", "~/gde-se-nalazimo.aspx", false);
            routes.MapPageRoute("uslovi-prodaje", "uslovi-prodaje", "~/uslovi-prodaje.aspx", false);
            routes.MapPageRoute("proizvodni-program", "proizvodni-program", "~/proizvodi.aspx", false);
            routes.MapPageRoute("oprema", "oprema", "~/oprema.aspx", false);
            routes.MapPageRoute("sertifikati", "sertifikati", "~/sertifikati.aspx", false);
        }
    }
}