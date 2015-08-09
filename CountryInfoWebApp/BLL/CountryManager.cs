using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Web;
using CountryInfoWebApp.DAL;
using CountryInfoWebApp.Model;

namespace CountryInfoWebApp.BLL
{
    public class CountryManager
    {
        private CountryGateway aGateway = new CountryGateway();

        public string Save(Country aCountry)
        {
            if (IsNameExists(aCountry.Name))
            {
                return "Name Already Exists";
            }
            else
            {


                if (aGateway.Save(aCountry) > 0)
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

        public List<Country> GetCountries()
        {
            return aGateway.GetCountry();
        }

        public List<Country> GetCountriesByName(Country _Country)
        {
            return aGateway.GetCountryListByName(_Country);
        }
    }
}