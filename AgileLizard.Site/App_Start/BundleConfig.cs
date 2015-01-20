using System.Web;
using System.Web.Optimization;

namespace AgileLizard.Site
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/reason").Include(
                "~/Content/js/jquery.min.js",
                "~/Content/js/jquery.cookie.js",
                "~/Content/js/bootstrap.min.js",
                "~/Content/js/bootstrap-switch.min.js",
                "~/Content/js/wow.min.js",
                "~/Content/js/slidebars.js",
                "~/Content/js/jquery.bxslider.min.js",
                "~/Content/js/holder.js",
                "~/Content/js/buttons.js",
                "~/Content/js/styleswitcher.js",
                "~/Content/js/jquery.mixitup.min.js",
                "~/Content/js/circles.min.js",
                "~/Content/js/syntaxhighlighter/shCore.js",
                "~/Content/js/syntaxhighlighter/shBrushXml.js",
                "~/Content/js/syntaxhighlighter/shBrushJScript.js",
                "~/Content/js/app.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/reasoncss").Include(
                "~/Content/css/preload.css",
                "~/Content/css/bootstrap.min.css",
                "~/Content/css/yamm.css",
                "~/Content/css/bootstrap-switch.min.css",
                "~/Content/css/font-awesome.min.css",
                "~/Content/css/animate.min.css",
                "~/Content/css/slidebars.css",
                "~/Content/css/lightbox.css",
                "~/Content/css/jquery.bxslider.css",
                "~/Content/css/syntaxhighlighter/shCore.css",
                "~/Content/css/style-blue2.css",
                "~/Content/css/width-full.css",
                "~/Content/css/buttons.css"
                ));
            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
