using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Website.DataAccess.Interfaces;
using Website.DataAccess.Services;

namespace Website.DataAccess.Dependencies
{
    public class Configuration
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IEntitiesFactory, EntitiesFactory>();
        }
    }
}
