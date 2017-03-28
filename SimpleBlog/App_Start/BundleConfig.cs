using System;
using System.Web.Optimization;

namespace SimpleBlog.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //O parâmetro virtualPath é criado em tempo de execução, não tendo relação com path propriamente dito
            //Este StyleBundle pertence a area Admin do Site
            bundles.Add(new StyleBundle("~/admin/styles")
                .Include("~/content/styles/bootstrap.css")
                .Include("~/content/styles/Admin.css"));

            //O parâmetro virtualPath é criado em tempo de execução, não tendo relação com path propriamente dito
            //Este StyleBundle pertence as demais páginas do site.
            bundles.Add(new StyleBundle("~/styles")
                .Include("~/content/styles/bootstrap.css")
                .Include("~/content/styles/site.css"));
        }

        internal static void RegisterBundles(object bundleTables)
        {
            throw new NotImplementedException();
        }
    }
}