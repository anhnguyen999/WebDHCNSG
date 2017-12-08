using System.Web;
using System.Web.Optimization;

namespace WebDienThoaiDiDong
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/responsiveslides").Include(
                     "~/Scripts/responsiveslides.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/style.css",
                      "~/Content/responsiveslides.css"));

            #region admin layout

            bundles.Add(new StyleBundle("~/Content/admin/css").Include(
                "~/Content/admin-theme/css/bootstrap.min.css",
                "~/Content/admin-theme/css/bootstrap-responsive.min.css",
                "~/Content/admin-theme/css/uniform.css",
                "~/Content/admin-theme/css/select2.css",
                "~/Content/admin-theme/css/maruti-style.css",
                "~/Content/admin-theme/css/maruti-media.css"));

            bundles.Add(new ScriptBundle("~/bundles/admin/jslibrary").Include(
                "~/Content/admin-theme/js/jquery.ui.custom.js",
                "~/Content/admin-theme/js/jquery.uniform.js",
                "~/Content/admin-theme/js/select2.min.js",
                "~/Content/admin-theme/js/jquery.dataTables.min.js",
                "~/Content/admin-theme/js/maruti.js",
                "~/Content/admin-theme/js/maruti.tables.js"));

            #endregion

            BundleTable.EnableOptimizations = false;
        }
    }
}
