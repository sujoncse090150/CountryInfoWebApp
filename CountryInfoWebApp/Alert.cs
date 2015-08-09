﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace CountryInfoWebApp
{
    public class alert
    {
        //public alert()
        //{
        //    //
        //    // TODO: Add constructor logic here
        //    //
        //}

        public static void Show(string message)
        {
            // Gets the executing web page 
            Page page = HttpContext.Current.CurrentHandler as Page;

            // Checks if the handler is a Page and that the script isn't allready on the Page 
            if (page != null)
            {
                //for normal
                //page.ClientScript.RegisterClientScriptBlock(typeof(Alert), "alert", script);
                //for ajax update panel
                ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", string.Format("alert('{0}');", message), true);
            }
        }
        public static void Redirect(string url, string target, string windowFeatures)
        {
            //ClientScriptManager cScrip = Page.ClientScript;
            //Type cType = this.GetType();
            //string Script = @"<script language=JavaScript> window.open('./report_viewer.aspx?IsPdf=1'); </script>";
            //if (!cScrip.IsClientScriptBlockRegistered(cType, "ViewReport"))
            //    cScrip.RegisterClientScriptBlock(cType, "ViewReport", Script);

            HttpContext context = HttpContext.Current;
            if ((String.IsNullOrEmpty(target) || target.Equals("_self", StringComparison.OrdinalIgnoreCase)) && String.IsNullOrEmpty(windowFeatures))
                context.Response.Redirect(url);
            else
            {
                Page page = (Page)context.Handler;

                if (page == null)
                    throw new InvalidOperationException("Cannot redirect to new window outside Page context.");


                url = page.ResolveClientUrl(url);

                string script;

                if (!String.IsNullOrEmpty(windowFeatures))
                    script = @"window.open(""{0}"", ""{1}"", ""{2}"");";
                else
                    script = @"window.open(""{0}"", ""{1}"");";


                script = String.Format(script, url, target, windowFeatures);

                ScriptManager.RegisterStartupScript(page, typeof(Page), "Redirect", script, true);
            }
        }
    }
}