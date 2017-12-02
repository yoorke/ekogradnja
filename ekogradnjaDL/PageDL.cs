using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ekogradnjaUtilities;
using ekogradnjaBE;

namespace ekogradnjaDL
{
    public class PageDL
    {
        public static void Sacuvaj(Page page, bool novi)
        {
            Konekcija konekcija = new Konekcija();
            SqlCommand objComm = new SqlCommand();
            string insert = "INSERT INTO page (idPage, title, description, keywords, content, url, idTipStranice) VALUES (@idPage, @title, @description, @keywords, @content, @url, @idTipStranice)";
            string update = "UPDATE page SET title=@title, description=@description, keywords=@keywords, content=@content, url=@url, idTipStranice=@idTipStranice WHERE idPage=@idPage";

            try
            {
                konekcija.otvoriKonekciju();
                objComm.Connection = konekcija.objConn;
                objComm.CommandText = (novi) ? insert : update;
                if (novi)
                    objComm.Parameters.Add("@idPage", SqlDbType.Int).Value = page.IdPage;
                objComm.Parameters.Add("@title", SqlDbType.NVarChar, 50).Value = page.Title;
                objComm.Parameters.Add("@description", SqlDbType.NVarChar, 200).Value = page.Description;
                objComm.Parameters.Add("@keywords", SqlDbType.NVarChar, 200).Value = page.Keywords;
                objComm.Parameters.Add("@content", SqlDbType.Xml).Value = page.Content;
                objComm.Parameters.Add("@url", SqlDbType.NVarChar, 50).Value = page.Url;
                objComm.Parameters.Add("@idTipStranice", SqlDbType.Int).Value = 1;
                if (!novi)
                    objComm.Parameters.Add("@idPage", SqlDbType.Int).Value = page.IdPage;

                objComm.ExecuteNonQuery();
            }
            catch (Error e)
            {
                throw new Error(e.Type, e.Message);
            }
            catch (Exception ex)
            {
                throw new Error(ErrorType.Stop, "Greška prilikom unosa" + " " + ex.Message);
            }
            finally
            {
                konekcija.zatvoriKonekciju();
            }
        }

        public static Page LoadPage(int idPage, string url)
        {
            Konekcija konekcija = new Konekcija();
            SqlCommand objComm = new SqlCommand("SELECT title, description, keywords, content, url FROM page");
            SqlDataReader reader = null;
            Page page = new Page();

            try
            {
                if (idPage > 0)
                {
                    objComm.CommandText += " WHERE idPage=@idPage";
                    objComm.Parameters.Add("@idPage", SqlDbType.Int).Value = idPage;
                }
                else if (url != string.Empty)
                {
                    objComm.CommandText += " WHERE url=@url";
                    objComm.Parameters.Add("@url", SqlDbType.NVarChar, 50).Value = url;
                }
                konekcija.otvoriKonekciju();
                objComm.Connection = konekcija.objConn;
                reader = objComm.ExecuteReader();
                while (reader.Read())
                {
                    page.IdPage = idPage;
                    page.Title = reader.GetString(0);
                    page.Description = reader.GetString(1);
                    page.Keywords = reader.GetString(2);
                    page.Content = reader.GetString(3);
                    page.Url = reader.GetString(4);
                }
            }
            catch (Error e)
            {
                throw new Error(e.Type, e.Message);
            }
            catch (Exception ex)
            {
                throw new Error(ErrorType.Stop, "Greška prilikom učitavanja." + " " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                konekcija.zatvoriKonekciju();
            }
            return page;
        }
    }
}
