﻿using System.Web;
using System.Web.Optimization;

namespace WebApplicationMVC
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/assets/scripts/jquery/jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/assets/scripts/jquery-validate/jquery.validate*"));


            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/assets/scripts/bootstrap//bootstrap*"));

            bundles.Add(new StyleBundle("~/assets/css").Include(
                      "~/assets/css/bootstrap.css"));
        }
    }
}
