using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Dependencies
{
    public static class Configuration
    {
        private static bool isConfigured = false;

        public static void Configure(IUnityContainer container)
        {
            if (isConfigured)
                return;

            BusinessLogic.Dependencies.Configuration.RegisterTypes(container);
            DataAccess.Dependencies.Configuration.RegisterTypes(container);
            Mapper.Dependencies.Configuration.RegisterTypes(container);


            isConfigured = true;
        }
    }
}