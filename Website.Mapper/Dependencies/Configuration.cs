using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Website.Mapper.Interfaces;
using Website.Mapper.Services;

namespace Website.Mapper.Dependencies
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class Configuration
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IMapperService, MapperService>(new ContainerControlledLifetimeManager());
        }
    }
}
