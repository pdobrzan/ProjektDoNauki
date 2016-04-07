using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website.DataAccess.Models;

namespace Website.DataAccess.Interfaces
{
    public interface IEntitiesFactory
    {
        CarAuctionEntities getContext();
    }
}
