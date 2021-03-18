using System.Web;
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

            bundles.Add(new ScriptBundle("~/Scripts/bootstrap/js").Include(
                      "~/Scripts/bootstrap/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/Scriptw/owl-carousel/js").Include(
                      "~/Scripts/owl-carousel/owl.carousel.js"));

            bundles.Add(new ScriptBundle("~/Scripts/slitslider/js").Include(
                      "~/Scripts/slitslider/jquery.ba-cond.min.js",
                      "~/Scripts/slitslider/jquery.slitslider.js",
                      "~/Scripts/slitslider/modernizr.custom.79639.js" ));

            bundles.Add(new ScriptBundle("~/Scripts/js").Include(
                      "~/Scripts/script.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap/css").Include(
                      "~/Content/bootstrap/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/owl-carousel/css").Include(
            "~/Content/owl-carousel/owl.carousel.css",
            "~/Content/owl-carousel/owl.theme.css"
            ));

            bundles.Add(new StyleBundle("~/Content/slitslider/css").Include(
            "~/Content/slitslider/style.css",
            "~/Content/slitslider/custom.css"
            ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
            "~/Content/style.css"
            ));
        }
                //<script src = "http://code.jquery.com/jquery-1.9.1.min.js" ></ script >

    }
}