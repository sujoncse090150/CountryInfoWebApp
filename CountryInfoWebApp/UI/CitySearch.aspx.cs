using CityInfoWebApp.BLL;
using CountryInfoWebApp.BLL;
using CountryInfoWebApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CountryInfoWebApp.UI
{
    public partial class CitySearch : System.Web.UI.Page
    {
        CityManager _CityManager = new CityManager();
        CountryManager aManager = new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                ddlCountry.DataSource = aManager.GetCountries(); ;
                ddlCountry.DataTextField = "Name";
                ddlCountry.DataValueField = "ID";
                ddlCountry.DataBind();

                GrdCityList.DataSource = _CityManager.GetAllCities();
                GrdCityList.DataBind();
            }
        }

        protected void RdoCity_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoCity.Checked)
            {
                txtCityName.Enabled = true;
                ddlCountry.SelectedIndex = -1;
                ddlCountry.Enabled = false;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (RdoCity.Checked ==true &&  txtCityName.Text == "")
                {
                    alert.Show("Please enter yout City Name !");
                    txtCityName.Focus();
                    return;
                }
                if (RdoCountry.Checked == true && ddlCountry.SelectedIndex < 0)
                {
                    alert.Show("Please Slect Country Name !");
                    ddlCountry.Focus();
                    return;
                }
                City _City = new City();
                if(RdoCity.Checked)
                {
                _City.Name = txtCityName.Text.Trim();
                }
                else if (RdoCountry.Checked)
                {

                _City.Country_Id = Int16.Parse(ddlCountry.SelectedValue.ToString());
                }

                GrdCityList.DataSource = _CityManager.GetCityByName(_City);
                GrdCityList.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void RdoCountry_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoCountry.Checked)
            {
                txtCityName.Text = "";
                txtCityName.Enabled = false;
                ddlCountry.SelectedIndex = -1;
                ddlCountry.Enabled = true ;

            }
        }
    }
}