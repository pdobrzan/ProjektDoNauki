using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Website.BusinessLogic.Interfaces;
using Website.DataAccess.Interfaces;
using Website.DataAccess.Models;
using Website.DataTransferObjects.Models;
using Website.Mapper.Interfaces;

namespace Website.BusinessLogic.Services
{
    public class AuctionService : IAuctionService
    {
        private IEntitiesFactory entitiesFactory;
        private IMapperService mapperService;

        public AuctionService(IEntitiesFactory entitiesFactory, IMapperService mapperService)
        {
            this.entitiesFactory = entitiesFactory;
            this.mapperService = mapperService;
        }

        [HttpPost]
        public void AddCarAuction(CarAuctionDto item)
        {
            using (var context = entitiesFactory.getContext())
            {
                var auction = context.Auctions.Add(mapperService.Map<CarAuction>(item));
            }
        }

        public CarAuctionDto GetCarAuctionById(int auctionNumber)
        {
            using (var context = entitiesFactory.getContext())
            {
                var auction = context.Auctions.FirstOrDefault(a => a.AuctionNumber == auctionNumber);
                return mapperService.Map<CarAuctionDto>(auction);
            }
        }
    }
}
