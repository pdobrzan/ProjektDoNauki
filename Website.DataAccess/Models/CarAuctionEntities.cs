using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website.DataAccess.Models
{
    public class CarAuctionEntities : DbContext
    {
        public CarAuctionEntities() : base("CarAuctionDatabaseContext")
        {
        }

        public virtual DbSet<CarAuction> Auctions { get; set; }
    }
}
