using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ekogradnjaBE;
using ekogradnjaUtilities;
using System.Data;
using System.Data.SqlClient;

namespace ekogradnjaDL
{
    public class ProjekatDL
    {
        public static DataTable UcitajProjekte(bool prvaStrana, DateTime datumOd, DateTime datumDo, bool aktivan)
        {
            Konekcija konekcija = new Konekcija();
            SqlCommand objComm = new SqlCommand();
            string select = "idProjekta, nazivProjekta, opisProjekta, datumProjekta, sadrzaj, url FROM projekat";
            SqlDataReader reader = null;
            DataTable projekti = new DataTable();
            projekti.Columns.Add("idProjekta", typeof(int));
            projekti.Columns.Add("nazivProjekta", typeof(string));
            projekti.Columns.Add("opisProjekta",typeof(string));
            projekti.Columns.Add("datumProjekta", typeof(DateTime));
            projekti.Columns.Add("sadrzaj", typeof(string));
            projekti.Columns.Add("url", typeof(string));

            try
            {
                select = (prvaStrana) ? "SELECT TOP 2 " + select : "SELECT " + select;
                select += " WHERE datumProjekta>=@datumOd AND datumProjekta<@datumDo";

                if (aktivan)
                    select += " AND aktivan=1";

                select += " ORDER BY datumProjekta DESC";


                konekcija.otvoriKonekciju();
                objComm.CommandText = select;
                objComm.Connection = konekcija.objConn;
                objComm.Parameters.Add("@datumOd", SqlDbType.Date).Value = datumOd;
                objComm.Parameters.Add("@datumDo", SqlDbType.Date).Value = datumDo.AddDays(1);
                if (aktivan)
                    objComm.Parameters.Add("@aktivan", SqlDbType.Bit).Value = aktivan;
                DataRow noviRed;
                reader = objComm.ExecuteReader();
                while (reader.Read())
                {
                    noviRed = projekti.NewRow();
                    noviRed["idProjekta"] = reader.GetInt32(0);
                    noviRed["nazivProjekta"] = reader.GetString(1);
                    noviRed["opisProjekta"] = reader.GetString(2);
                    noviRed["datumProjekta"] = reader.GetDateTime(3).ToShortDateString();
                    if (Convert.IsDBNull(reader[4]) == false)
                        noviRed["sadrzaj"] = reader.GetString(4);
                    noviRed["url"] = reader.GetString(5);

                    projekti.Rows.Add(noviRed);
                }
            }
            catch (Error e)
            {
                throw new Error(e.Type, e.Message);
            }
            catch (Exception ex)
            {
                throw new Error(ErrorType.Stop, "Greška prilikom učitavanja projekta" + " " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                konekcija.zatvoriKonekciju();
            }
            return projekti;
        }

        public static Projekat UcitajProjekat(int idProjekta, string url)
        {
            Konekcija konekcija = new Konekcija();
            SqlCommand objComm = new SqlCommand("SELECT idProjekta, nazivProjekta, opisProjekta, datumProjekta, sadrzaj FROM projekat");
            SqlDataReader reader = null;
            Projekat projekat = null;

            try
            {
                if (idProjekta > 0)
                {
                    objComm.CommandText += " WHERE idProjekta=@idProjekta";
                    objComm.Parameters.Add("@idProjekta", SqlDbType.Int).Value = idProjekta;
                }
                else
                {
                    objComm.CommandText += " WHERE url=@url";
                    objComm.Parameters.Add("@url", SqlDbType.NVarChar, 50).Value = url;
                }

                konekcija.otvoriKonekciju();
                objComm.Connection = konekcija.objConn;
                //objComm.Parameters.Add("@idProjekta", SqlDbType.Int).Value = idProjekta;
                reader = objComm.ExecuteReader();
                while (reader.Read())
                {
                    projekat = new Projekat();
                    projekat.IdProjekta = reader.GetInt32(0);
                    projekat.NazivProjekta = reader.GetString(1);
                    projekat.OpisProjekta = reader.GetString(2);
                    projekat.DatumProjekta = reader.GetDateTime(3);
                    if (Convert.IsDBNull(reader[4]) == false)
                        projekat.Sadrzaj = reader.GetString(4);
                }
            }
            catch (Error e)
            {
                throw new Error(e.Type, e.Message);
            }
            catch (Exception ex)
            {
                throw new Error(ErrorType.Stop, "Greška prilikom učitavanja projekta" + " " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                konekcija.zatvoriKonekciju();
            }
            return projekat;
        }
    }
}
