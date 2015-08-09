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
    public partial class CountryEntry : System.Web.UI.Page
    {
        CountryManager aManager = new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblInvalidMessage.Text = "";
                msgLabel.Text = "";
                GrdCountryList.DataSource = aManager.GetCountries();
                GrdCountryList.DataBind();
            }
        }
       
        protected void btnsave_Click(object sender, EventArgs e)
        {
            lblInvalidMessage.Text = "";
            msgLabel.Text = "";
            if (txtCountryName.Text.Trim() == "")
            {
               lblInvalidMessage.Text = "Country Name Can't Be Empty !.";
                txtCountryName.Focus();
                return;
            }
            if (txtAbout.Text.Trim() == "")
            {
                lblInvalidMessage.Text= "Country About Can't Be Empty !.";
                txtAbout.Focus();
                return;
            }
            Country aCountry = new Country();
            aCountry.Name = txtCountryName.Text;
            aCountry.About = txtAbout.Text;

           alert.Show(aManager.Save(aCountry));

            GrdCountryList.DataSource = aManager.GetCountries();
            GrdCountryList.DataBind();

        }

        protected void showCountryGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}