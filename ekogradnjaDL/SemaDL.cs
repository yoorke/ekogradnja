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
    public class SemaDL
    {
        public static DataTable UcitajSeme(string url)
        {
            Konekcija konekcija = new Konekcija();
            SqlCommand objComm = new SqlCommand("SELECT DISTINCT sema.idSeme, nazivSeme FROM ((sema INNER JOIN semaDimenzija ON sema.idSeme=semaDimenzija.idSeme) INNER JOIN dimenzija ON semaDimenzija.idDimenzije=dimenzija.idDimenzije) INNER JOIN proizvod ON proizvod.idProizvoda=dimenzija.idProizvoda");
            SqlDataReader reader = null;
            DataTable seme = new DataTable();
            seme.Columns.Add("idSeme", typeof(int));
            seme.Columns.Add("nazivSeme", typeof(string));
            seme.Columns.Add("dimenzija", typeof(string));

            try
            {
                konekcija.otvoriKonekciju();
                objComm.Connection = konekcija.objConn;
                if (url != string.Empty)
                {
                    objComm.CommandText += " WHERE url=@url";
                    objComm.Parameters.Add("@url", SqlDbType.NVarChar, 50).Value = url;
                }
                objComm.CommandText += " ORDER BY sema.idSeme";
                DataRow noviRed;
                reader = objComm.ExecuteReader();
                while (reader.Read())
                {
                    noviRed = seme.NewRow();
                    noviRed["idSeme"] = reader.GetInt32(0);
                    noviRed["nazivSeme"] = reader.GetString(1);
                    noviRed["dimenzija"] = ucitajDimenzijeZaSemu(reader.GetInt32(0)); //reader.GetString(2);

                    seme.Rows.Add(noviRed);
                    /*if (seme.Rows.Count == 0 || (seme.Rows.Count > 0 && seme.Rows[seme.Rows.Count - 1]["idSeme"].ToString() != noviRed["idSeme"].ToString()))
                        seme.Rows.Add(noviRed);
                    else if (seme.Rows.Count > 0 && seme.Rows[seme.Rows.Count - 1]["idSeme"].ToString() == noviRed["idSeme"].ToString())
                    {
                        seme.Rows[seme.Rows.Count - 1]["dimenzija"] += " i " + noviRed["dimenzija"];
                    }*/
                }
            }
            catch (Error e)
            {
                throw new Error(e.Type, e.Message);
            }
            catch (Exception ex)
            {
                throw new Error(ErrorType.Stop, "Greška prilikom učitavanja šema" + " " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                konekcija.zatvoriKonekciju();
            }
            return seme;
        }

        private static string ucitajDimenzijeZaSemu(int idSeme)
        {
            Konekcija konekcija = new Konekcija();
            SqlCommand objComm = new SqlCommand("SELECT dimenzija, proizvod.url FROM (dimenzija INNER JOIN semaDimenzija ON dimenzija.idDimenzije=semaDimenzija.idDimenzije) INNER JOIN proizvod ON dimenzija.idProizvoda=proizvod.idProizvoda WHERE idSeme=@idSeme");
            SqlDataReader reader = null;
            string dimenzije = string.Empty;

            try
            {
                konekcija.otvoriKonekciju();
                objComm.Connection = konekcija.objConn;
                objComm.Parameters.Add("@idSeme", SqlDbType.Int).Value = idSeme;
                reader = objComm.ExecuteReader();
                while (reader.Read())
                {
                    dimenzije += dimenzije.Length > 0 ? " i " + reader.GetString(0) : reader.GetString(0);
                }
            }
            catch (Error e)
            {
                throw new Error(e.Type, e.Message);
            }
            catch (Exception ex)
            {
                throw new Error(ErrorType.Stop, "Greška prilikom učitavanja dimenzija" + " " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                konekcija.zatvoriKonekciju();
            }
            return dimenzije;
        }
    }
}
