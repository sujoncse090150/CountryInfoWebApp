﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryInfoWebApp.Model
{
    public class City
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }

        public int Dwellers { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }

        public int Country_Id { get; set; }
        public string CountryName {get;set; }
        public string CountryAbout { get; set; }
    }
}