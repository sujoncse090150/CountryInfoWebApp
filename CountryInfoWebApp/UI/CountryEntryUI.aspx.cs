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
    public partial class CountryEntryUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            showCountryGridView.DataSource = aManager.GetCountries();
            showCountryGridView.DataBind();
        }
        CountryManager aManager = new CountryManager();
        protected void saveButton_Click(object sender, EventArgs e)
        {
            Country aCountry = new Country();
            aCountry.Name = nameTextBox.Text;
            aCountry.About = aboutTextBox.Text;

            msgLabel.Text = aManager.Save(aCountry);

            showCountryGridView.DataSource = aManager.GetCountries();
            showCountryGridView.DataBind();

        }

        protected void showCountryGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}