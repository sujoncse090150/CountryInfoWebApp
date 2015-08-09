using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryInfoWebApp.BLL;
using CountryInfoWebApp.Model;

namespace CountryInfoWebApp.UI
{
    public partial class SearchCountry : System.Web.UI.Page
    {
        CountryManager aManager = new CountryManager();
         Country aCountry = new Country();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCountryName.Text == "")
                {
                    alert.Show("Please enter yout Country Name !");
                    txtCountryName.Focus();
                    return;
                }
                aCountry.Name = txtCountryName.Text.Trim();

                GrdCountryList.DataSource = aManager.GetCountriesByName(aCountry);
                GrdCountryList.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}