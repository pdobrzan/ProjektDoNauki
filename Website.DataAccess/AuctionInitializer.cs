using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website.DataAccess.Models;

namespace Website.DataAccess
{
    public class AuctionInitializaer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CarAuctionEntities>
    {
        protected override void Seed(CarAuctionEntities context)
        {
            var auctions = new List<CarAuction>
            {
            new CarAuction{AuctionNumber=1, Power=101, Price=11000 },
            new CarAuction{AuctionNumber=2, Power=200, Price=12000 },
            new CarAuction{AuctionNumber=3, Power=300, Price=13000 },
            new CarAuction{AuctionNumber=4, Power=400, Price=14000 },
            new CarAuction{AuctionNumber=5, Power=500, Price=15000 }
            };

            auctions.ForEach(s => context.Auctions.Add(s));
            context.SaveChanges();
        }
    }
}
