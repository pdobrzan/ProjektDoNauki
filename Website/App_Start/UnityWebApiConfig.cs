using System.Web.Http;
using Unity.WebApi;

namespace Website.App_Start
{
    public static class UnityWebApiConfig
    {
        public static void RegisterComponents()
        {
            var container = UnityConfig.GetConfiguredContainer();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}