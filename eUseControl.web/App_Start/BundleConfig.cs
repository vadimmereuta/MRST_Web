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
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/Site.css",
                "~/Content/bootstrap.min.css"));

            //bundles.Add(new ScriptBundle("~/Scripts/js").Include(
            //     "~/Scripts/jquery-1.10.2.min.js",
            //     "~/Scripts/bootstrap.min.js"));



            // Activează optimizările (bun pt. test și release)
            BundleTable.EnableOptimizations = true;
        }
    }
}