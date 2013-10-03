using System.Web;
using System.Web.Optimization;

namespace $safeprojectname$
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new ScriptBundle("~/Scripts/fmd").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/fmd-custom.js")
                );

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/font-awesome.css",
                "~/Content/font-awesome-ie7.css",
                "~/Content/fmd.css")
                );
        }
    }
}