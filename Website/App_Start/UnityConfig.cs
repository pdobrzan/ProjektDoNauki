using Microsoft.Practices.Unity;
using System;
using System.Web.Http;
using Unity.WebApi;
using Website.Dependencies;

namespace Website
{
    public static class UnityConfig
    {

        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }


        public static void RegisterTypes(IUnityContainer container)
        {
            Configuration.Configure(container);
        }
    }
}