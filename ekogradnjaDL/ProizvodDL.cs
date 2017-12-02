using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ekogradnjaUtilities;
using ekogradnjaBE;
using System.Data;
using System.Data.SqlClient;

namespace ekogradnjaDL
{
    public class ProizvodDL
    {
        public static DataTable UcitajProizvode(int idProizvoda, bool slider, int idTipProizvoda)
        {
            Konekcija konekcija = new Konekcija();
            SqlCommand objComm = new SqlCommand("idProizvoda, sifraProizvoda, nazivProizvoda, opisProizvoda, url, idTipProizvoda FROM proizvod WHERE aktivan=1");
            SqlDataReader reader = null;
            DataTable proizvodi = new DataTable();
            proizvodi.Columns.Add("idProizvoda", typeof(int));
            proizvodi.Columns.Add("sifraProizvoda", typeof(string));
            proizvodi.Columns.Add("nazivProizvoda", typeof(string));
            proizvodi.Columns.Add("opisProizvoda", typeof(string));
            proizvodi.Columns.Add("url", typeof(string));
            bool postoji = true;

            try
            {
                if (slider)
                    objComm.CommandText = "SELECT TOP 8 " + objComm.CommandText;
                else
                    objComm.CommandText = "SELECT " + objComm.CommandText;
                if (idProizvoda > 0)
                {
                    objComm.CommandText += " AND idProizvoda=@idProizvoda";
                    objComm.Parameters.Add("@idProizvoda", SqlDbType.Int).Value = idProizvoda;
                    postoji = true;
                }
                if (idTipProizvoda > 0)
                {
                    if (postoji)
                        objComm.CommandText += " AND idTipProizvoda=@idTipProizvoda";
                    else
                    {
                        objComm.CommandText += " WHERE idTipProizvoda=@idTipProizvoda";
                        postoji = true;
                    }
                    objComm.Parameters.Add("@idTipProizvoda", SqlDbType.Int).Value = idTipProizvoda;
                }
                if (slider)
                    objComm.CommandText += " ORDER BY NEWID()";
                else
                    objComm.CommandText += " ORDER BY nazivProizvoda";

                konekcija.otvoriKonekciju();
                objComm.Connection = konekcija.objConn;
                DataRow noviRed;
                reader = objComm.ExecuteReader();
                while (reader.Read())
                {
                    noviRed = proizvodi.NewRow();
                    noviRed["idProizvoda"] = reader.GetInt32(0);
                    noviRed["sifraProizvoda"] = reader.GetString(1);
                    noviRed["nazivProizvoda"] = reader.GetString(2);
                    noviRed["opisProizvoda"] = reader.GetString(3);
                    noviRed["url"] = "/" + vratiUrlTipaProizvoda(reader.GetInt32(5)) + "/" + reader.GetString(4) + "-" + reader.GetInt32(0).ToString();

                    proizvodi.Rows.Add(noviRed);
                }

                if (slider)
                {
                    /*for (int i = 0; i < 6; i++)
                    {
                        noviRed = proizvodi.NewRow();
                        noviRed["idProizvoda"] = proizvodi.Rows[i][0];
                        noviRed["sifraProizvoda"] = proizvodi.Rows[i][1];
                        noviRed["nazivProizvoda"] = proizvodi.Rows[i][2];
                        noviRed["opisProizvoda"] = proizvodi.Rows[i][3];
                        noviRed["url"] = proizvodi.Rows[i][4];

                        proizvodi.Rows.Add(noviRed);
                    }*/
                }
            }
            catch (Error e)
            {
                throw new Error(e.Type, e.Message);
            }
            catch (Exception ex)
            {
                throw new Error(ErrorType.Stop, "Greška prilikom učitavanja proizvoda" + " " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                konekcija.zatvoriKonekciju();
            }
            return proizvodi;
        }

        public static DimenzijaList UcitajDimenzijeProizvoda(int idProizvoda)
        {
            Konekcija konekcija = new Konekcija();
            SqlCommand objComm = new SqlCommand("SELECT idDimenzije, nazivDimenzije, dimenzija, brojKomada, brojNaPaleti, l, d, c, e, tezina FROM dimenzija WHERE idProizvoda=@idProizvoda");
            SqlDataReader reader = null;
            DimenzijaList dimenzije = new DimenzijaList();

            try
            {
                konekcija.otvoriKonekciju();
                objComm.Connection = konekcija.objConn;
                objComm.Parameters.Add("@idProizvoda", SqlDbType.Int).Value = idProizvoda;
                reader = objComm.ExecuteReader();
                Dimenzija dimenzija;
                while (reader.Read())
                {
                    dimenzija = new Dimenzija();
                    dimenzija.IdDimenzije = reader.GetInt32(0);
                    dimenzija.NazivDimenzije = reader.GetString(1);
                    if (Convert.IsDBNull(reader[2]) == false)
                        dimenzija.DimenzijaProizvoda = reader.GetString(2);
                    if (Convert.IsDBNull(reader[3]) == false)
                        dimenzija.BrojKomada = reader.GetDouble(3);
                    if (Convert.IsDBNull(reader[4]) == false)
                        dimenzija.BrojNaPaleti = reader.GetDouble(4);
                    dimenzija.IdProizvoda = idProizvoda;
                    if (Convert.IsDBNull(reader[5]) == false)
                        dimenzija.L = reader.GetDouble(5);
                    if (Convert.IsDBNull(reader[6]) == false)
                        dimenzija.D = reader.GetDouble(6);
                    if (Convert.IsDBNull(reader[7]) == false)
                        dimenzija.C = reader.GetDouble(7);
                    if (Convert.IsDBNull(reader[8]) == false)
                        dimenzija.E = reader.GetDouble(8);
                    if (Convert.IsDBNull(reader[9]) == false)
                        dimenzija.Tezina = reader.GetDouble(9);

                    dimenzije.Add(dimenzija);
                }
            }
            catch (Error e)
            {
                throw new Error(e.Type, e.Message);
            }
            catch (Exception ex)
            {
                throw new Error(ErrorType.Stop, "Greška prilikom učitavanja dimenzija." + " " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                konekcija.zatvoriKonekciju();
            }
            return dimenzije;
        }

        public static Proizvod UcitajProizvod(int idProizvoda, string url)
        {
            Konekcija konekcija = new Konekcija();
            SqlCommand objComm = new SqlCommand("SELECT idProizvoda, sifraProizvoda, nazivProizvoda, opisProizvoda, aktivan, idTipProizvoda, url FROM proizvod");
            SqlDataReader reader = null;
            Proizvod proizvod = new Proizvod();

            try
            {
                konekcija.otvoriKonekciju();
                objComm.Connection = konekcija.objConn;

                if (idProizvoda > 0)
                {
                    objComm.CommandText += " WHERE idProizvoda=@idProizvoda";
                    objComm.Parameters.Add("@idProizvoda", SqlDbType.Int).Value = idProizvoda;
                }
                else if (url != string.Empty)
                {
                    objComm.CommandText += " WHERE url=@url";
                    objComm.Parameters.Add("@url", SqlDbType.NVarChar, 50).Value = url;
                }

                reader = objComm.ExecuteReader();
                while (reader.Read())
                {
                    proizvod.IdProizvoda = reader.GetInt32(0);
                    proizvod.SifraProizvoda = reader.GetString(1);
                    proizvod.NazivProizvoda = reader.GetString(2);
                    proizvod.OpisProizvoda = reader.GetString(3);
                    proizvod.Aktivan = reader.GetBoolean(4);
                    proizvod.IdTipaProizvoda = reader.GetInt32(5);
                    proizvod.Url = reader.GetString(6);
                    proizvod.Dimenzije = UcitajDimenzijeProizvoda(proizvod.IdProizvoda);
                    proizvod.Boje = UcitajBojeProizvoda(proizvod.IdProizvoda);
                }
            }
            catch (Error e)
            {
                throw new Error(e.Type, e.Message);
            }
            catch (Exception ex)
            {
                throw new Error(ErrorType.Stop, "Greška prilikom učitavanja proizvoda." + " " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                konekcija.zatvoriKonekciju();
            }
            return proizvod;
        }

        public static BojaList UcitajBojeProizvoda(int idProizvoda)
        {
            Konekcija konekcija = new Konekcija();
            SqlCommand objComm = new SqlCommand("SELECT boja.idBoje, nazivBoje, url FROM boja INNER JOIN proizvodBoja ON boja.idBoje=proizvodBoja.idBoje WHERE idProizvoda=@idProizvoda");
            SqlDataReader reader = null;
            BojaList boje = new BojaList();

            try
            {
                konekcija.otvoriKonekciju();
                objComm.Connection = konekcija.objConn;
                objComm.Parameters.Add("@idProizvoda", SqlDbType.Int).Value = idProizvoda;
                reader = objComm.ExecuteReader();
                Boja boja;
                while (reader.Read())
                {
                    boja = new Boja();
                    boja.IdBoje = reader.GetInt32(0);
                    boja.NazivBoje = reader.GetString(1);
                    boja.Url = "/images/boja/" + reader.GetString(2) + ".jpg";

                    boje.Add(boja);
                }
            }
            catch (Error e)
            {
                throw new Error(e.Type, e.Message);
            }
            catch (Exception ex)
            {
                throw new Error(ErrorType.Stop, "Greška prilikom učitavanja boje" + " " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                konekcija.zatvoriKonekciju();
            }
            return boje;
        }

        private static string vratiUrlTipaProizvoda(int idTipaProizvoda)
        {
            Konekcija konekcija = new Konekcija();
            SqlCommand objComm = new SqlCommand("SELECT url FROM tipProizvoda WHERE idTipProizvoda=@idTipProizvoda");
            SqlDataReader reader = null;
            string url = string.Empty;

            try
            {
                konekcija.otvoriKonekciju();
                objComm.Connection = konekcija.objConn;
                objComm.Parameters.Add("@idTipProizvoda", SqlDbType.Int).Value = idTipaProizvoda;
                reader = objComm.ExecuteReader();
                while (reader.Read())
                {
                    url = reader.GetString(0);
                }

            }
            catch (Error e)
            {
                throw new Error(e.Type, e.Message);
            }
            catch (Exception ex)
            {
                throw new Error(ErrorType.Stop, "Greška prilikom učitavanja url" + " " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                konekcija.zatvoriKonekciju();
            }
            return url;
        }

        public static DataTable UcitajTipProizvoda(string url)
        {
            Konekcija konekcija = new Konekcija();
            SqlCommand objComm = new SqlCommand("SELECT idTipProizvoda, nazivTipaProizvoda, url, opis FROM tipProizvoda WHERE url=@url");
            SqlDataReader reader = null;
            DataTable tipProizvoda = new DataTable();
            tipProizvoda.Columns.Add("idTipProizvoda", typeof(int));
            tipProizvoda.Columns.Add("nazivTipaProizvoda", typeof(string));
            tipProizvoda.Columns.Add("url", typeof(string));
            tipProizvoda.Columns.Add("opis", typeof(string));

            try
            {
                konekcija.otvoriKonekciju();
                objComm.Connection = konekcija.objConn;
                objComm.Parameters.Add("@url", SqlDbType.NVarChar, 50).Value = url;
                reader = objComm.ExecuteReader();
                DataRow noviRed;
                while (reader.Read())
                {
                    noviRed = tipProizvoda.NewRow();
                    noviRed["idTipProizvoda"] = reader.GetInt32(0);
                    noviRed["nazivTipaProizvoda"] = reader.GetString(1);
                    noviRed["url"] = reader.GetString(2);
                    noviRed["opis"] = reader.GetString(3);

                    tipProizvoda.Rows.Add(noviRed);
                }
            }
            catch (Error e)
            {
                throw new Error(e.Type, e.Message);
            }
            catch (Exception ex)
            {
                throw new Error(ErrorType.Stop, "Greška prilikom učitavnja tipa proizvoda." + " " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                konekcija.zatvoriKonekciju();
            }
            return tipProizvoda;
        }

        public static DataTable UcitajProizvodeZaSeme()
        {
            Konekcija konekcija = new Konekcija();
            SqlCommand objComm = new SqlCommand("SELECT DISTINCT proizvod.idProizvoda, nazivProizvoda, url FROM (proizvod INNER JOIN dimenzija ON proizvod.idProizvoda=dimenzija.idProizvoda) INNER JOIN semaDimenzija ON dimenzija.idDimenzije=semaDimenzija.idDimenzije");
            SqlDataReader reader = null;
            DataTable artikli = new DataTable();
            artikli.Columns.Add("idProizvoda", typeof(int));
            artikli.Columns.Add("nazivProizvoda", typeof(string));
            artikli.Columns.Add("url", typeof(string));

            try
            {
                konekcija.otvoriKonekciju();
                objComm.Connection = konekcija.objConn;
                DataRow noviRed;

                noviRed = artikli.NewRow();
                noviRed["idProizvoda"] = 0;
                noviRed["nazivProizvoda"] = "Svi";
                noviRed["url"] = string.Empty;
                artikli.Rows.Add(noviRed);

                reader = objComm.ExecuteReader();
                while (reader.Read())
                {
                    noviRed = artikli.NewRow();
                    noviRed["idProizvoda"] = reader.GetInt32(0);
                    noviRed["nazivProizvoda"] = reader.GetString(1);
                    noviRed["url"] = reader.GetString(2);

                    artikli.Rows.Add(noviRed);
                }
            }
            catch (Error e)
            {
                throw new Error(e.Type, e.Message);
            }
            catch (Exception ex)
            {
                throw new Error(ErrorType.Stop, "Greška prilikom učitavanja proizvoda" + " " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                konekcija.zatvoriKonekciju();
            }
            return artikli;
        }
    }
}
