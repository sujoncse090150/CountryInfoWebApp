using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using CountryInfoWebApp.Model;

namespace CountryInfoWebApp.DAL
{
    public class CityGateway
    {
        private string connectionString =
          WebConfigurationManager.ConnectionStrings["CountryConnection"].ConnectionString;

        public int Save(City aCity)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO tbl_CityEntry VALUES ('" + aCity.Name + "', '" + aCity.About + "', '" + aCity.Dwellers + "', '" + aCity.Location + "', '" + aCity.Weather + "', '" + aCity.Country_Id + "')";
            SqlCommand aCommand = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = aCommand.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public List<City> GetCity()
        {
            List<City> CityList = new List<City>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM tbl_CityEntry order By Name";
            SqlCommand aCommand = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            while (aReader.Read())
            {
                City aCity = new City();
                aCity.Id = (int)aReader["id"];
                aCity.Name = (string)aReader["Name"];
                aCity.About = (string)aReader["About"];
                CityList.Add(aCity);
            }
            aReader.Close();
            connection.Close();

            return CityList;
        }

        public bool Save(string nametext)
        {
            bool isNameExists = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * from tbl_CityEntry where Name ='" + nametext + "'", connection);
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

        public List<City> GetCityListByName(City _City)
        {
            List<City> CityList = new List<City>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query="";
            string queryCond="";
            if (_City.Name != null && _City.Country_Id == 0)
            {
                queryCond = " ct.Name Like '" + _City.Name + "%'  order By ct.Name";
            }
            else if (_City.Name == null && _City.Country_Id > 0)
            {
                queryCond = " cn.id =" + _City.Country_Id + "  order By ct.Name";
            }
            else
            {
                queryCond = "";                    
            }
            query = "SELECT ct.[id],ct.[Name],ct.About,ct.[Dwellers],ct.Location,ct.Weather,ct.[Country_Id],cn.Name as CountryName,cn.About as CountryAbout FROM tbl_CityEntry ct inner join [dbo].[tbl_Country] cn on  cn.id=ct.[Country_Id] Where ";
            query = query + queryCond;
            SqlCommand aCommand = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            while (aReader.Read())
            {
                City aCity = new City();
                aCity.Id = (int)aReader["id"];
                aCity.Name = (string)aReader["Name"];
                aCity.About = (string)aReader["About"];
                aCity.Dwellers = (int)aReader["Dwellers"];
                aCity.Location = (string)aReader["Location"];
                aCity.Weather = (string)aReader["Weather"];
                aCity.Country_Id = (int)aReader["Country_Id"];
                aCity.CountryName = (string)aReader["CountryName"];
                aCity.CountryAbout = (string)aReader["CountryAbout"];

                CityList.Add(aCity);
            }
            aReader.Close();
            connection.Close();

            return CityList;
        }

        public List<City> GetAllCity()
        {
            List<City> CityList = new List<City>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT ct.[id],ct.[Name],ct.About,ct.[Dwellers],ct.Location,ct.Weather,ct.[Country_Id],cn.Name as CountryName,cn.About as CountryAbout FROM tbl_CityEntry ct inner join [dbo].[tbl_Country] cn on  cn.id=ct.[Country_Id] order By ct.Name";
            SqlCommand aCommand = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            while (aReader.Read())
            {
                City aCity = new City();
                aCity.Id = (int)aReader["id"];
                aCity.Name = (string)aReader["Name"];
                aCity.About = (string)aReader["About"];
                aCity.Dwellers = (int)aReader["Dwellers"];
                aCity.Location = (string)aReader["Location"];
                aCity.Weather = (string)aReader["Weather"];
                aCity.Country_Id = (int)aReader["Country_Id"];
                aCity.CountryName = (string)aReader["CountryName"];
                aCity.CountryAbout = (string)aReader["CountryAbout"];
                CityList.Add(aCity);
            }
            aReader.Close();
            connection.Close();

            return CityList;
        }
    }
}