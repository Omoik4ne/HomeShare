﻿using System.Web;
using System.Web.Optimization;

namespace HomeShare
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.ba-cond.min.js",
                        "~/Scripts/jquery.slitslider.js"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
            "~/Scripts/owl.carousel.js",
            "~/Scripts/modernizr.custom.79639.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/owl.carousel.css",
                        "~/Content/owl.theme.css",
                      "~/Content/custom.css",
                      "~/Content/style.css",
                      "~/Content/bootstrap.css",
                      "~/Content/general/style.css"));
        }
                //<script src = "http://code.jquery.com/jquery-1.9.1.min.js" ></ script >

    }
}