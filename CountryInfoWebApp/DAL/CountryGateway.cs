using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using CountryInfoWebApp.Model;

namespace CountryInfoWebApp.DAL
{
    public class CountryGateway
    {
        private string connectionString =
            WebConfigurationManager.ConnectionStrings["CountryConnection"].ConnectionString;

        public int Save(Country aCountry)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO tbl_Country VALUES ('" + aCountry.Name + "', '" + aCountry.About + "')";
            SqlCommand aCommand = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = aCommand.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public List<Country> GetCountry()
        {
            List<Country> countryList = new List<Country>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM tbl_Country order By Name";
            SqlCommand aCommand = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            while (aReader.Read())
            {
                Country aCountry = new Country();
                aCountry.Id = (int) aReader["id"];
                aCountry.Name = (string) aReader["Name"];
                aCountry.About = (string) aReader["About"];
                countryList.Add(aCountry);
            }
            aReader.Close();
            connection.Close();

            return countryList;
        }

        public bool Save(string nametext)
        {
            bool isNameExists = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * from tbl_Country where Name ='" + nametext + "'", connection);
                connection.Open();
                SqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    isNameExists = true;
                    break;
                }
            }
            return isNameExists;
        }

        public List<Country> GetCountryListByName(Country _Country)
        {
            List<Country> countryList = new List<Country>();
            SqlConnection connection = new SqlConnection(connectionString);
             string query="";
             query = " SELECT cn.id,cn.Name,cn.About,isnull(ct.NoCity,0)NoCity,isnull(ct.Dwellers,0)Dwellers FROM tbl_Country cn Left join  (select t.Country_Id,Count(t.id) NoCity,SUM(t.Dwellers)Dwellers from dbo.tbl_CityEntry t group By t.Country_Id)ct on ct.Country_Id=cn.id";
            query = query+"  where cn.Name Like '" + _Country.Name.Trim() + "%'";
            SqlCommand aCommand = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            while (aReader.Read())
            {
                Country aCountry = new Country();
                aCountry.Id = (int)aReader["id"];
                aCountry.Name = (string)aReader["Name"];
                aCountry.About = (string)aReader["About"];
                aCountry.NoCity = (int)aReader["NoCity"];
                aCountry.Dwellers = (int)aReader["Dwellers"];
                countryList.Add(aCountry);
            }
            aReader.Close();
            connection.Close();

            return countryList;
        }
    }

}