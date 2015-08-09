using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryInfoWebApp.Model
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public int NoCity { get; set; }
        public int Dwellers { get; set; }
    }
}