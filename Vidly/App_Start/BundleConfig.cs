using System.Web;
using System.Web.Optimization;

namespace Vidly
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                          "~/Scripts/jquery-{version}.js",
                          "~/Scripts/bootstrap.js",
                          "~/Scripts/bootbox.js",
                          "~/Scripts/respond.js",
                          "~/Scripts/datatables/jquery.datatables.js",
                          "~/Scripts/datatables/datatables.bootstrap.js",
                          "~/scripts/typeahead.bundle.js",
                          "~/scripts/toastr.js"
                          ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new Bundle("~/bundles/bootstrap").Include(
            //          ));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                        // Core Bootstrap 3 CSS:
                        "~/Content/bootstrap.css",

                        // Then your Lumen theme on top of it:
                        "~/Content/bootstrap-lumen.css",
                        "~/Content/bootstrap-theme.css",

                        // DataTables skin for Bootstrap 3:
                        "~/Content/datatables/css/datatables.bootstrap.css",
                        "~/Content/typeahead.css",
                        "~/content/toastr.css",
                        // Your custom site overrides:
                        "~/Content/site.css"
                    ));
        }
    }
}
