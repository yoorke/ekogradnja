using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ekogradnjaUtilities;
using System.Data.Sql;
using System.Data.SqlClient;
using ekogradnjaBE;
using System.Data;

namespace ekogradnjaDL
{
    public class MenuDL
    {
        public static MenuStavkaList UcitajStavkeMenu(int idMenuUp, string urlUp)
        {
            Konekcija konekcija = new Konekcija();
            SqlCommand objComm = new SqlCommand("SELECT idMenuStavka, nazivStavke, url, redniBroj FROM menuStavka");
            SqlDataReader reader = null;
            MenuStavkaList stavkeMenu = new MenuStavkaList();

            try
            {
                //if (idMenu > 0)
                //{
                objComm.CommandText += " WHERE idMenuUp=@idMenu";
                objComm.Parameters.Add("@idMenu", SqlDbType.Int).Value = idMenuUp;
                objComm.CommandText += " ORDER BY redniBroj";
                //}
                konekcija.otvoriKonekciju();
                objComm.Connection = konekcija.objConn;
                reader = objComm.ExecuteReader();
                MenuStavka stavkaMenu;
                while (reader.Read())
                {
                    stavkaMenu = new MenuStavka();
                    stavkaMenu.IdMenuStavka = reader.GetInt32(0);
                    stavkaMenu.Naziv = reader.GetString(1);
                    stavkaMenu.Url = reader.GetString(2);
                    stavkaMenu.RedniBroj = reader.GetInt32(3);

                    stavkeMenu.Add(stavkaMenu);
                }
            }
            catch (Error e)
            {
                throw new Error(e.Type, e.Message);
            }
            catch (Exception ex)
            {
                throw new Error(ErrorType.Stop, "Greška prilikom učitavanja stavki menu" + " " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                konekcija.zatvoriKonekciju();
            }
            return stavkeMenu;
        }

        public static MenuStavkaList UcitajMenu(int idMenu)
        {
            Konekcija konekcija = new Konekcija();
            SqlCommand objComm = new SqlCommand("SELECT idMenuStavka, nazivStavke, url FROM menuStavka WHERE idMenu=@idMenu ORDER BY redniBroj");
            SqlDataReader reader = null;
            MenuStavkaList menu = new MenuStavkaList();

            try
            {
                konekcija.otvoriKonekciju();
                objComm.Parameters.Add("@idMenu", SqlDbType.Int).Value = idMenu;
                objComm.Connection = konekcija.objConn;
                reader = objComm.ExecuteReader();
                MenuStavka stavkaMenu;
                while (reader.Read())
                {
                    stavkaMenu = new MenuStavka();
                    stavkaMenu.IdMenuStavka = reader.GetInt32(0);
                    stavkaMenu.Naziv = reader.GetString(1);
                    stavkaMenu.Url = reader.GetString(2);
                    stavkaMenu.Podmenu = UcitajStavkeMenu(stavkaMenu.IdMenuStavka, stavkaMenu.Url);

                    menu.Add(stavkaMenu);
                }
            }
            catch (Error e)
            {
                throw new Error(e.Type, e.Message);
            }
            catch (Exception ex)
            {
                throw new Error(ErrorType.Stop, "Greška prilikom učitavanja spiska menu." + " " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                konekcija.zatvoriKonekciju();
            }
            return menu;
        }
    }
}
