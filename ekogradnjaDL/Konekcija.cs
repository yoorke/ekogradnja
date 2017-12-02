using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace ekogradnjaDL
{
    class Konekcija
    {
        public SqlConnection objConn;
        string connectionStringStari = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\etnokeramika.mdf;Integrated Security=True;User Instance=True";
        //string connectionString = @"Server=localhost;Database=ekogradnja;Trusted_Connection=Yes;";
        //string connectionString = @"Server=gladiolus.arvixe.com;Database=ekogradnja;User id=yoorke;Password=DjD3jc38o;";
        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public void otvoriKonekciju()
        {
            try
            {
                objConn = new SqlConnection(connectionString);
                objConn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void zatvoriKonekciju()
        {
            try
            {
                if (objConn != null)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
