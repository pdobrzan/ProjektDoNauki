using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Website.BusinessLogic.Interfaces;
using Website.BusinessLogic.Services;

namespace Website.BusinessLogic.Dependencies
{
    public class Configuration
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IAuctionService, AuctionService>();
        }
    }
}
