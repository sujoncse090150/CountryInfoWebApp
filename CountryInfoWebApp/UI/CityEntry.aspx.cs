using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryInfoWebApp.Model;
using CityInfoWebApp.BLL;
using CountryInfoWebApp.BLL;
namespace CountryInfoWebApp.UI
{
    public partial class CityEntry : System.Web.UI.Page
    {
        CityManager _CityManager = new CityManager();
        CountryManager aManager = new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblInvalidMessage.Text = "";
                msgLabel.Text = "";

                ddlCountry.DataSource = aManager.GetCountries(); ;
                ddlCountry.DataTextField = "Name";
                ddlCountry.DataValueField = "ID";
                ddlCountry.DataBind();

                GrdCityList.DataSource = _CityManager.GetAllCities();
                GrdCityList.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
           
            msgLabel.Text = "";
            if (txtCityName.Text.Trim() == "")
            {
                alert.Show("City Name Can't Be Empty !.");
                txtCityName.Focus();
                return;
            }
            if (txtAbout.Text.Trim() == "")
            {
                 alert.Show("Country About Can't Be Empty !.");
                txtAbout.Focus();
                return;
            }
            City aCity = new City();
            aCity.Name = txtCityName.Text;
            aCity.About = txtAbout.Text;
            aCity.Dwellers = Int16.Parse(txtDwellers.Text);
            aCity.Location = txtLocation.Text;
            aCity.Weather = txtWeather.Text;
            aCity.Country_Id =Int16.Parse(ddlCountry.SelectedValue.ToString());

            alert.Show(_CityManager.Save(aCity));

            GrdCityList.DataSource = _CityManager.GetAllCities();
            GrdCityList.DataBind();

        }
    }
}