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
using System.Net.Mail;

namespace ekogradnjav2
{
    public partial class kontakt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Kontakt podaci i mapa | Ekogradnja";
        }

        protected void btnPosalji_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage("info@ekogradnja.rs", "info@ekogradnja.rs", "From: " + txtEmail.Text + " " + txtNaslov.Text, txtPoruka.Text);
                SmtpClient smtp = new SmtpClient("mail.ekogradnja.rs");

                try
                {
                    smtp.Send(mail);
                }
                catch (Exception ex)
                {
                }
            }
            catch
            {
            }
        }
    }
}
