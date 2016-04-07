using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website.DataAccess.Interfaces;
using Website.DataAccess.Models;

namespace Website.DataAccess.Services
{
    public class EntitiesFactory : IEntitiesFactory
    {
        public CarAuctionEntities getContext()
        {
            return new CarAuctionEntities();
        }
    }
}
