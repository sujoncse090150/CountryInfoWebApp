using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryInfoWebApp.DAL;
using CountryInfoWebApp.Model;

namespace CityInfoWebApp.BLL
{
    public class CityManager
    {

        private CityGateway aGateway = new CityGateway();

        public string Save(City aCity)
        {
            if (IsNameExists(aCity.Name))
            {
                return "Name Already Exists";
            }
            else
            {


                if (aGateway.Save(aCity) > 0)
                {
                    return "Saved Successfully";
                }
                else
                {
                    return "Failed";
                }
            }
        }

        public bool IsNameExists(string nametext)
        {
            return aGateway.Save(nametext);
        }

        public List<City> GetCities()
        {
            return aGateway.GetCity();
        }
        public List<City> GetAllCities()
        {
            return aGateway.GetAllCity();
        }

        public List<City> GetCityByName(City _City)
        {
            return aGateway.GetCityListByName(_City);
        }
    }
}