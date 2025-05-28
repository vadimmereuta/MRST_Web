using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace eUseControl.web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // JQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-2.0.0.min.js",
                "~/Scripts/jquery.validate.min.js",
                "~/Scripts/jquery-ui-1.14.1.min.js"
            ));

            // Bootstrap JS
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.bundle.min.js"
            ));

            // (opțional) Bundle pentru toate JS-urile generale
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Scripts/jquery-2.0.0.min.js",
                "~/Scripts/bootstrap.bundle.min.js",
                "~/Scripts/jquery.validate.min.js",
                "~/Scripts/jquery-ui-1.14.1.min.js"
            ));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/Site.css",
                "~/Content/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                "~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));


            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include(
                "~/Content/font-awesome.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/toaster/css").Include(
                "~/Vendors/toastr/toastr.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/datatables/css").Include(
                "~/Vendors/datatables/datatables.min.css", new CssRewriteUrlTransform()));


            // Activează optimizările (bun pt. test și release)
            BundleTable.EnableOptimizations = false;
        }
    }
}